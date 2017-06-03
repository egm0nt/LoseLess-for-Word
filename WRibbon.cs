using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace Lossless
{
    public partial class WRibbon
    {
        private int times = 0;

        private void WRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            recoverButton.SuperTip = recoverButton.SuperTip.Replace(">", Environment.NewLine);
        }

        private void undoRecoveryButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (times > 0)
            {
                object t = times;
                Globals.ThisAddIn.Application.ActiveDocument.Undo(ref t);
                times = 0;

                undoRecoveryButton.Enabled = false;
            }
        }

        private void recoverButton_Click(object sender, RibbonControlEventArgs e)
        {
            Dictionary<string, string> langSymbols = new Dictionary<string, string>();
            langSymbols.Add("ru", "йцукенгшщзхъ\\фывапролджэячсмитьбю.ёЙЦУКЕНГШЩЗХЪ/ФЫВАПРОЛДЖЭЯЧСМИТЬБЮ,Ё!\"№;%:?*()_+");
            langSymbols.Add("en", "qwertyuiop[]\\asdfghjkl;'zxcvbnm,./`QWERTYUIOP{}|ASDFGHJKL:\"ZXCVBNM<>?~!@#$%^&*()_+");

            object missing = Type.Missing;
            object replaceAll = Word.WdReplace.wdReplaceAll;

            string lang1 = "auto";
            string lang2 = "ru";

            if (langEnRuButton.Checked || langRuEnButton.Checked)
            {
                lang1 = (langEnRuButton.Checked) ? "en" : "ru";
                lang2 = (langEnRuButton.Checked) ? "ru" : "en";
            }

            try
            {
                int length = Globals.ThisAddIn.Application.Selection.Text.Length;
                string[] text = new string[length / 255 + 1];

                for (int i=0, j=0; i < length; i += 255, ++j)
                    text[j] = Globals.ThisAddIn.Application.Selection.Text.Substring(i, (length-i > 255) ? 255 : length-i);

                Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;

                foreach (string t in text)
                {
                    findObject.Text = t;
                    findObject.Replacement.Text = Translate(ref langSymbols, t, lang1, lang2);

                    findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                    times += 1;
                }
            }
            catch (Exception ex)
            { System.Windows.Forms.MessageBox.Show(ex.ToString()); }

            if (times > 0)
                undoRecoveryButton.Enabled = true;
        }

        private string Translate(ref Dictionary<string, string> langSymbols, string encoded, string fromLang, string toLang)
        {
            string decoded = "";

            // quotes bug in Word
            encoded = encoded.Replace('”', '"');
            encoded = encoded.Replace('‘', '\'');
            encoded = encoded.Replace("^", "\\^");

            try
            {
                if (fromLang == "auto")
                {
                    fromLang = "en";

                    if (langSymbols[toLang].IndexOf(encoded[0]) >= 0)
                    {
                        fromLang = toLang;
                        toLang = "en";
                    }
                }

                foreach (char c in encoded)
                {
                    int pos = langSymbols[fromLang].IndexOf(c);
                    decoded += (pos != -1) ? langSymbols[toLang][pos] : c;
                }

                decoded = (!ignoreCaseButton.Checked) ? makeCase(decoded) : decoded;
            }
            catch (Exception ex)
            { }

            return decoded;
        }

        private string makeCase(string input)
        {
            string output = "";
            bool newWord = true;

            foreach (char c in input)
            {
                if (newWord && c != ' ')
                {
                    output += char.ToUpper(c);
                    newWord = false;
                }
                else
                    output += char.ToLower(c);

                if (c == '.')
                    newWord = true;
            }

            return output;
        }

        private void langButtons_Click(object sender, RibbonControlEventArgs e)
        {
            switch (((RibbonToggleButton) sender).Description)
            {
                case "auto":
                    langEnRuButton.Checked = false;
                    langRuEnButton.Checked = false;
                    break;
                case "ru":
                    langAutoButton.Checked = false;
                    langEnRuButton.Checked = false;
                    break;
                case "en":
                    langAutoButton.Checked = false;
                    langRuEnButton.Checked = false;
                    break;
            }
        }
    }
}
