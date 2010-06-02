namespace CMBC.EasyFactor.ARMgr
{
    partial class WorkAlert
    {
		#region?Fields?(39)?

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonX btnDueAssign;
        private DevComponents.DotNetBar.ButtonX btnDueAssign0;
        private DevComponents.DotNetBar.ButtonX btnDueAssign7;
        private DevComponents.DotNetBar.ButtonX btnDueCDA;
        private DevComponents.DotNetBar.ButtonX btnDueClientCreditLine;
        private DevComponents.DotNetBar.ButtonX btnDueContract;
        private DevComponents.DotNetBar.ButtonX btnDueFactorCreditLine;
        private DevComponents.DotNetBar.ButtonX btnDueFinance;
        private DevComponents.DotNetBar.ButtonX btnDueFinance0;
        private DevComponents.DotNetBar.ButtonX btnDueFinance7;
        private DevComponents.DotNetBar.ButtonX btnInvoiceDispute;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.ExpandablePanel panelAssign;
        private DevComponents.DotNetBar.ExpandablePanel panelFinance;
        private DevComponents.DotNetBar.ExpandablePanel panelOther;
        private DevComponents.DotNetBar.PanelEx panelRight;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelRight = new DevComponents.DotNetBar.PanelEx();
            this.panelCDA = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.panelOther = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnDueFactorCreditLine = new DevComponents.DotNetBar.ButtonX();
            this.btnDueContract = new DevComponents.DotNetBar.ButtonX();
            this.btnDueCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnDueClientCreditLine = new DevComponents.DotNetBar.ButtonX();
            this.panelFinance = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnDueFinance = new DevComponents.DotNetBar.ButtonX();
            this.btnDueFinance0 = new DevComponents.DotNetBar.ButtonX();
            this.btnDueFinance7 = new DevComponents.DotNetBar.ButtonX();
            this.panelAssign = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnInvoiceDispute = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign0 = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign7 = new DevComponents.DotNetBar.ButtonX();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelRight.SuspendLayout();
            this.panelCDA.SuspendLayout();
            this.panelOther.SuspendLayout();
            this.panelFinance.SuspendLayout();
            this.panelAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelRight.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelRight.Controls.Add(this.panelCDA);
            this.panelRight.Controls.Add(this.panelOther);
            this.panelRight.Controls.Add(this.panelFinance);
            this.panelRight.Controls.Add(this.panelAssign);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(801, 219);
            this.panelRight.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelRight.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelRight.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelRight.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelRight.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelRight.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelRight.Style.GradientAngle = 90;
            this.panelRight.TabIndex = 2;
            // 
            // panelCDA
            // 
            this.panelCDA.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCDA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCDA.Controls.Add(this.btnRejectCheckCDA);
            this.panelCDA.Controls.Add(this.btnWaitCheckCDA);
            this.panelCDA.Controls.Add(this.btnNeedCheckCDA);
            this.panelCDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCDA.ExpandOnTitleClick = true;
            this.panelCDA.Location = new System.Drawing.Point(600, 0);
            this.panelCDA.Name = "panelCDA";
            this.panelCDA.Size = new System.Drawing.Size(200, 219);
            this.panelCDA.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCDA.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCDA.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCDA.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCDA.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCDA.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCDA.Style.GradientAngle = 90;
            this.panelCDA.TabIndex = 3;
            this.panelCDA.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCDA.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCDA.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCDA.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCDA.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCDA.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCDA.TitleStyle.GradientAngle = 90;
            this.panelCDA.TitleText = "额度通知书";
            // 
            // btnRejectCheckCDA
            // 
            this.btnRejectCheckCDA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckCDA.AutoExpandOnClick = true;
            this.btnRejectCheckCDA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckCDA.Location = new System.Drawing.Point(15, 87);
            this.btnRejectCheckCDA.Name = "btnRejectCheckCDA";
            this.btnRejectCheckCDA.Size = new System.Drawing.Size(140, 25);
            this.btnRejectCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRejectCheckCDA.TabIndex = 0;
            this.btnRejectCheckCDA.Text = "c) 拒绝放行";
            this.btnRejectCheckCDA.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectCheckCDA.Click += new System.EventHandler(this.QueryRejectCheckCDAs);
            // 
            // btnWaitCheckCDA
            // 
            this.btnWaitCheckCDA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitCheckCDA.AutoExpandOnClick = true;
            this.btnWaitCheckCDA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitCheckCDA.Location = new System.Drawing.Point(15, 58);
            this.btnWaitCheckCDA.Name = "btnWaitCheckCDA";
            this.btnWaitCheckCDA.Size = new System.Drawing.Size(140, 25);
            this.btnWaitCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWaitCheckCDA.TabIndex = 0;
            this.btnWaitCheckCDA.Text = "b) 等待放行";
            this.btnWaitCheckCDA.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitCheckCDA.Click += new System.EventHandler(this.QueryWaitCheckCDAs);
            // 
            // btnNeedCheckCDA
            // 
            this.btnNeedCheckCDA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedCheckCDA.AutoExpandOnClick = true;
            this.btnNeedCheckCDA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedCheckCDA.Location = new System.Drawing.Point(15, 29);
            this.btnNeedCheckCDA.Name = "btnNeedCheckCDA";
            this.btnNeedCheckCDA.Size = new System.Drawing.Size(140, 25);
            this.btnNeedCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNeedCheckCDA.TabIndex = 0;
            this.btnNeedCheckCDA.Text = "a) 需要放行";
            this.btnNeedCheckCDA.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckCDA.Click += new System.EventHandler(this.QueryNeedCheckCDAs);
            // 
            // panelOther
            // 
            this.panelOther.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelOther.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelOther.Controls.Add(this.btnDueFactorCreditLine);
            this.panelOther.Controls.Add(this.btnDueContract);
            this.panelOther.Controls.Add(this.btnDueCDA);
            this.panelOther.Controls.Add(this.btnDueClientCreditLine);
            this.panelOther.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOther.ExpandOnTitleClick = true;
            this.panelOther.Location = new System.Drawing.Point(400, 0);
            this.panelOther.Name = "panelOther";
            this.panelOther.Size = new System.Drawing.Size(200, 219);
            this.panelOther.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelOther.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelOther.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelOther.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelOther.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelOther.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelOther.Style.GradientAngle = 90;
            this.panelOther.TabIndex = 2;
            this.panelOther.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelOther.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelOther.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelOther.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelOther.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelOther.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelOther.TitleStyle.GradientAngle = 90;
            this.panelOther.TitleText = "其它信息提示";
            // 
            // btnDueFactorCreditLine
            // 
            this.btnDueFactorCreditLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFactorCreditLine.AutoExpandOnClick = true;
            this.btnDueFactorCreditLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFactorCreditLine.Location = new System.Drawing.Point(15, 58);
            this.btnDueFactorCreditLine.Name = "btnDueFactorCreditLine";
            this.btnDueFactorCreditLine.Size = new System.Drawing.Size(160, 25);
            this.btnDueFactorCreditLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueFactorCreditLine.TabIndex = 1;
            this.btnDueFactorCreditLine.Text = "b) 保理商额度到期";
            this.btnDueFactorCreditLine.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueFactorCreditLine.Click += new System.EventHandler(this.QueryFactorCreditLineDue);
            // 
            // btnDueContract
            // 
            this.btnDueContract.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueContract.AutoExpandOnClick = true;
            this.btnDueContract.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueContract.Location = new System.Drawing.Point(15, 115);
            this.btnDueContract.Name = "btnDueContract";
            this.btnDueContract.Size = new System.Drawing.Size(160, 25);
            this.btnDueContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueContract.TabIndex = 3;
            this.btnDueContract.Text = "d) 保理合同到期";
            this.btnDueContract.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueContract.Click += new System.EventHandler(this.QueryContractDue);
            // 
            // btnDueCDA
            // 
            this.btnDueCDA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueCDA.AutoExpandOnClick = true;
            this.btnDueCDA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueCDA.Location = new System.Drawing.Point(15, 86);
            this.btnDueCDA.Name = "btnDueCDA";
            this.btnDueCDA.Size = new System.Drawing.Size(160, 25);
            this.btnDueCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueCDA.TabIndex = 2;
            this.btnDueCDA.Text = "c) 额度通知书到期";
            this.btnDueCDA.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueCDA.Click += new System.EventHandler(this.QueryCDADue);
            // 
            // btnDueClientCreditLine
            // 
            this.btnDueClientCreditLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueClientCreditLine.AutoExpandOnClick = true;
            this.btnDueClientCreditLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueClientCreditLine.Location = new System.Drawing.Point(15, 29);
            this.btnDueClientCreditLine.Name = "btnDueClientCreditLine";
            this.btnDueClientCreditLine.Size = new System.Drawing.Size(160, 25);
            this.btnDueClientCreditLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueClientCreditLine.TabIndex = 0;
            this.btnDueClientCreditLine.Text = "a) 客户额度到期";
            this.btnDueClientCreditLine.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueClientCreditLine.Click += new System.EventHandler(this.QueryClientCreditLineDue);
            // 
            // panelFinance
            // 
            this.panelFinance.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinance.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFinance.Controls.Add(this.btnDueFinance);
            this.panelFinance.Controls.Add(this.btnDueFinance0);
            this.panelFinance.Controls.Add(this.btnDueFinance7);
            this.panelFinance.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFinance.ExpandOnTitleClick = true;
            this.panelFinance.Location = new System.Drawing.Point(200, 0);
            this.panelFinance.Name = "panelFinance";
            this.panelFinance.Size = new System.Drawing.Size(200, 219);
            this.panelFinance.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinance.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinance.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinance.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinance.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFinance.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFinance.Style.GradientAngle = 90;
            this.panelFinance.TabIndex = 1;
            this.panelFinance.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinance.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinance.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinance.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFinance.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinance.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinance.TitleStyle.GradientAngle = 90;
            this.panelFinance.TitleText = "融资信息预警提示";
            // 
            // btnDueFinance
            // 
            this.btnDueFinance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFinance.AutoExpandOnClick = true;
            this.btnDueFinance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFinance.Location = new System.Drawing.Point(15, 86);
            this.btnDueFinance.Name = "btnDueFinance";
            this.btnDueFinance.Size = new System.Drawing.Size(140, 25);
            this.btnDueFinance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueFinance.TabIndex = 2;
            this.btnDueFinance.Text = "c) 已经逾期";
            this.btnDueFinance.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueFinance.Click += new System.EventHandler(this.QueryInvoiceFinanceDue);
            // 
            // btnDueFinance0
            // 
            this.btnDueFinance0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFinance0.AutoExpandOnClick = true;
            this.btnDueFinance0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFinance0.Location = new System.Drawing.Point(15, 58);
            this.btnDueFinance0.Name = "btnDueFinance0";
            this.btnDueFinance0.Size = new System.Drawing.Size(140, 25);
            this.btnDueFinance0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueFinance0.TabIndex = 1;
            this.btnDueFinance0.Text = "b) 今日到期";
            this.btnDueFinance0.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueFinance0.Click += new System.EventHandler(this.QueryInvoiceFinanceDueBy0);
            // 
            // btnDueFinance7
            // 
            this.btnDueFinance7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFinance7.AutoExpandOnClick = true;
            this.btnDueFinance7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFinance7.Location = new System.Drawing.Point(15, 29);
            this.btnDueFinance7.Name = "btnDueFinance7";
            this.btnDueFinance7.Size = new System.Drawing.Size(140, 25);
            this.btnDueFinance7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueFinance7.TabIndex = 0;
            this.btnDueFinance7.Text = "a) 7日内到期";
            this.btnDueFinance7.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueFinance7.Click += new System.EventHandler(this.QueryInvoiceFinanceDueBy7);
            // 
            // panelAssign
            // 
            this.panelAssign.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelAssign.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelAssign.Controls.Add(this.btnInvoiceDispute);
            this.panelAssign.Controls.Add(this.btnDueAssign);
            this.panelAssign.Controls.Add(this.btnDueAssign0);
            this.panelAssign.Controls.Add(this.btnDueAssign7);
            this.panelAssign.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAssign.ExpandOnTitleClick = true;
            this.panelAssign.Location = new System.Drawing.Point(0, 0);
            this.panelAssign.Name = "panelAssign";
            this.panelAssign.Size = new System.Drawing.Size(200, 219);
            this.panelAssign.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAssign.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelAssign.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelAssign.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelAssign.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelAssign.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelAssign.Style.GradientAngle = 90;
            this.panelAssign.TabIndex = 0;
            this.panelAssign.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAssign.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelAssign.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelAssign.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelAssign.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelAssign.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelAssign.TitleStyle.GradientAngle = 90;
            this.panelAssign.TitleText = "应收账款预警提示";
            // 
            // btnInvoiceDispute
            // 
            this.btnInvoiceDispute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceDispute.AutoExpandOnClick = true;
            this.btnInvoiceDispute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceDispute.Location = new System.Drawing.Point(15, 115);
            this.btnInvoiceDispute.Name = "btnInvoiceDispute";
            this.btnInvoiceDispute.Size = new System.Drawing.Size(140, 25);
            this.btnInvoiceDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceDispute.TabIndex = 3;
            this.btnInvoiceDispute.Text = "d) 商纠账款";
            this.btnInvoiceDispute.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnInvoiceDispute.Click += new System.EventHandler(this.QueryInvoiceDispute);
            // 
            // btnDueAssign
            // 
            this.btnDueAssign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueAssign.AutoExpandOnClick = true;
            this.btnDueAssign.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueAssign.Location = new System.Drawing.Point(15, 86);
            this.btnDueAssign.Name = "btnDueAssign";
            this.btnDueAssign.Size = new System.Drawing.Size(140, 25);
            this.btnDueAssign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueAssign.TabIndex = 2;
            this.btnDueAssign.Text = "c) 已经逾期";
            this.btnDueAssign.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueAssign.Click += new System.EventHandler(this.QueryInvoiceAssignDue);
            // 
            // btnDueAssign0
            // 
            this.btnDueAssign0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueAssign0.AutoExpandOnClick = true;
            this.btnDueAssign0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueAssign0.Location = new System.Drawing.Point(15, 58);
            this.btnDueAssign0.Name = "btnDueAssign0";
            this.btnDueAssign0.Size = new System.Drawing.Size(140, 25);
            this.btnDueAssign0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueAssign0.TabIndex = 1;
            this.btnDueAssign0.Text = "b) 今日到期";
            this.btnDueAssign0.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueAssign0.Click += new System.EventHandler(this.QueryInvoiceAssignDueBy0);
            // 
            // btnDueAssign7
            // 
            this.btnDueAssign7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueAssign7.AutoExpandOnClick = true;
            this.btnDueAssign7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueAssign7.Location = new System.Drawing.Point(15, 29);
            this.btnDueAssign7.Name = "btnDueAssign7";
            this.btnDueAssign7.Size = new System.Drawing.Size(140, 25);
            this.btnDueAssign7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDueAssign7.TabIndex = 0;
            this.btnDueAssign7.Text = "a) 7日内到期";
            this.btnDueAssign7.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueAssign7.Click += new System.EventHandler(this.QueryInvoiceAssignDueBy7);
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.Text = "";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // WorkAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Name = "WorkAlert";
            this.Size = new System.Drawing.Size(801, 219);
            this.panelRight.ResumeLayout(false);
            this.panelCDA.ResumeLayout(false);
            this.panelOther.ResumeLayout(false);
            this.panelFinance.ResumeLayout(false);
            this.panelAssign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel panelCDA;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckCDA;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckCDA;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckCDA;

    }
}
