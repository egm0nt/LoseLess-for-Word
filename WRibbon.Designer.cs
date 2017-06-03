namespace Lossless
{
    partial class WRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WRibbon));
            this.recoveryTab = this.Factory.CreateRibbonTab();
            this.recoveryGroup = this.Factory.CreateRibbonGroup();
            this.recoverButton = this.Factory.CreateRibbonSplitButton();
            this.langAutoButton = this.Factory.CreateRibbonToggleButton();
            this.langEnRuButton = this.Factory.CreateRibbonToggleButton();
            this.langRuEnButton = this.Factory.CreateRibbonToggleButton();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.ignoreCaseButton = this.Factory.CreateRibbonToggleButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.undoRecoveryButton = this.Factory.CreateRibbonButton();
            this.recoveryTab.SuspendLayout();
            this.recoveryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // recoveryTab
            // 
            this.recoveryTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.recoveryTab.ControlId.OfficeId = "TabHome";
            this.recoveryTab.Groups.Add(this.recoveryGroup);
            resources.ApplyResources(this.recoveryTab, "recoveryTab");
            this.recoveryTab.Name = "recoveryTab";
            // 
            // recoveryGroup
            // 
            this.recoveryGroup.Items.Add(this.recoverButton);
            resources.ApplyResources(this.recoveryGroup, "recoveryGroup");
            this.recoveryGroup.Name = "recoveryGroup";
            // 
            // recoverButton
            // 
            this.recoverButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            resources.ApplyResources(this.recoverButton, "recoverButton");
            this.recoverButton.Image = global::Lossless.Properties.Resources.tabIcon;
            this.recoverButton.Items.Add(this.langAutoButton);
            this.recoverButton.Items.Add(this.langEnRuButton);
            this.recoverButton.Items.Add(this.langRuEnButton);
            this.recoverButton.Items.Add(this.separator3);
            this.recoverButton.Items.Add(this.ignoreCaseButton);
            this.recoverButton.Items.Add(this.separator2);
            this.recoverButton.Items.Add(this.undoRecoveryButton);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.recoverButton_Click);
            // 
            // langAutoButton
            // 
            this.langAutoButton.Checked = true;
            resources.ApplyResources(this.langAutoButton, "langAutoButton");
            this.langAutoButton.Name = "langAutoButton";
            this.langAutoButton.ShowImage = true;
            this.langAutoButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.langButtons_Click);
            // 
            // langEnRuButton
            // 
            resources.ApplyResources(this.langEnRuButton, "langEnRuButton");
            this.langEnRuButton.Name = "langEnRuButton";
            this.langEnRuButton.ShowImage = true;
            this.langEnRuButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.langButtons_Click);
            // 
            // langRuEnButton
            // 
            resources.ApplyResources(this.langRuEnButton, "langRuEnButton");
            this.langRuEnButton.Name = "langRuEnButton";
            this.langRuEnButton.ShowImage = true;
            this.langRuEnButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.langButtons_Click);
            // 
            // separator3
            // 
            resources.ApplyResources(this.separator3, "separator3");
            this.separator3.Name = "separator3";
            // 
            // ignoreCaseButton
            // 
            resources.ApplyResources(this.ignoreCaseButton, "ignoreCaseButton");
            this.ignoreCaseButton.Image = global::Lossless.Properties.Resources.caseIcon;
            this.ignoreCaseButton.Name = "ignoreCaseButton";
            this.ignoreCaseButton.ShowImage = true;
            // 
            // separator2
            // 
            resources.ApplyResources(this.separator2, "separator2");
            this.separator2.Name = "separator2";
            // 
            // undoRecoveryButton
            // 
            resources.ApplyResources(this.undoRecoveryButton, "undoRecoveryButton");
            this.undoRecoveryButton.Image = global::Lossless.Properties.Resources.undoIcon;
            this.undoRecoveryButton.Name = "undoRecoveryButton";
            this.undoRecoveryButton.ShowImage = true;
            this.undoRecoveryButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.undoRecoveryButton_Click);
            // 
            // WRibbon
            // 
            this.Name = "WRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.recoveryTab);
            resources.ApplyResources(this, "$this");
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WRibbon_Load);
            this.recoveryTab.ResumeLayout(false);
            this.recoveryTab.PerformLayout();
            this.recoveryGroup.ResumeLayout(false);
            this.recoveryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab recoveryTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup recoveryGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton recoverButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton langAutoButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton langEnRuButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton langRuEnButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton undoRecoveryButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ignoreCaseButton;
    }

    partial class ThisRibbonCollection
    {
        internal WRibbon WRibbon
        {
            get { return this.GetRibbon<WRibbon>(); }
        }
    }
}
