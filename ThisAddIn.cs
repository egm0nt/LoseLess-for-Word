using System;

namespace Lossless
{
    public partial class ThisAddIn
    {
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        { }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        { }
    }
}
