namespace CMBC.EasyFactor.ARMgr
{
    partial class WorkAlert
    {
		#region?Fields?(39)?

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonX btnDueAssign;
        private DevComponents.DotNetBar.ButtonX btnDueAssign0;
        private DevComponents.DotNetBar.ButtonX btnDueAssign7;
        private DevComponents.DotNetBar.ButtonX btnDuplicateInvoice;
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
        private DevComponents.DotNetBar.ExpandablePanel panelAssignDue;
        private DevComponents.DotNetBar.ExpandablePanel panelFinanceDue;
        private DevComponents.DotNetBar.ExpandablePanel panelOtherDue;
        private DevComponents.DotNetBar.PanelEx panelTop;
        private DevComponents.DotNetBar.PanelEx panelBottom;
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
            this.panelTop = new DevComponents.DotNetBar.PanelEx();
            this.panelCDADue = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckCDA = new DevComponents.DotNetBar.ButtonX();
            this.panelOtherDue = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnDueFactorCreditLine = new DevComponents.DotNetBar.ButtonX();
            this.btnDueContract = new DevComponents.DotNetBar.ButtonX();
            this.btnDueCDA = new DevComponents.DotNetBar.ButtonX();
            this.btnDueClientCreditLine = new DevComponents.DotNetBar.ButtonX();
            this.panelFinanceDue = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnDueFinance = new DevComponents.DotNetBar.ButtonX();
            this.btnDueFinance0 = new DevComponents.DotNetBar.ButtonX();
            this.btnDueFinance7 = new DevComponents.DotNetBar.ButtonX();
            this.panelAssignDue = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnInvoiceDispute = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign0 = new DevComponents.DotNetBar.ButtonX();
            this.btnDueAssign7 = new DevComponents.DotNetBar.ButtonX();
            this.btnDuplicateInvoice = new DevComponents.DotNetBar.ButtonX();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.panelCheckRefundBatch = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckRefundBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckRefundBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckRefundBatch = new DevComponents.DotNetBar.ButtonX();
            this.panelCheckPaymentBatch = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckPaymentBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckPaymentBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckPaymentBatch = new DevComponents.DotNetBar.ButtonX();
            this.panelCheckFinanceBatch = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckFinanceBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckFinanceBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckFinanceBatch = new DevComponents.DotNetBar.ButtonX();
            this.panelCheckAssignBatch = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectCheckAssignBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitCheckAssignBatch = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedCheckAssignBatch = new DevComponents.DotNetBar.ButtonX();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelFlaw = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectFlawCheck = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitFlawCheck = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedFlawCheck = new DevComponents.DotNetBar.ButtonX();
            this.panelDispute = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRejectDisputeCheck = new DevComponents.DotNetBar.ButtonX();
            this.btnWaitDisputeCheck = new DevComponents.DotNetBar.ButtonX();
            this.btnNeedDisputeCheck = new DevComponents.DotNetBar.ButtonX();
            this.panelTop.SuspendLayout();
            this.panelCDADue.SuspendLayout();
            this.panelOtherDue.SuspendLayout();
            this.panelFinanceDue.SuspendLayout();
            this.panelAssignDue.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCheckRefundBatch.SuspendLayout();
            this.panelCheckPaymentBatch.SuspendLayout();
            this.panelCheckFinanceBatch.SuspendLayout();
            this.panelCheckAssignBatch.SuspendLayout();
            this.panelFlaw.SuspendLayout();
            this.panelDispute.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelTop.Controls.Add(this.panelFlaw);
            this.panelTop.Controls.Add(this.panelCDADue);
            this.panelTop.Controls.Add(this.panelOtherDue);
            this.panelTop.Controls.Add(this.panelFinanceDue);
            this.panelTop.Controls.Add(this.panelAssignDue);
            this.panelTop.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1001, 184);
            this.panelTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTop.Style.GradientAngle = 90;
            this.panelTop.TabIndex = 2;
            // 
            // panelCDADue
            // 
            this.panelCDADue.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCDADue.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCDADue.Controls.Add(this.btnRejectCheckCDA);
            this.panelCDADue.Controls.Add(this.btnWaitCheckCDA);
            this.panelCDADue.Controls.Add(this.btnNeedCheckCDA);
            this.panelCDADue.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCDADue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCDADue.ExpandOnTitleClick = true;
            this.panelCDADue.Location = new System.Drawing.Point(600, 0);
            this.panelCDADue.Name = "panelCDADue";
            this.panelCDADue.Size = new System.Drawing.Size(200, 184);
            this.panelCDADue.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCDADue.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCDADue.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCDADue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCDADue.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCDADue.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCDADue.Style.GradientAngle = 90;
            this.panelCDADue.TabIndex = 3;
            this.panelCDADue.TitleHeight = 24;
            this.panelCDADue.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCDADue.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCDADue.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCDADue.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCDADue.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCDADue.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCDADue.TitleStyle.GradientAngle = 90;
            this.panelCDADue.TitleText = "额度通知书";
            // 
            // btnRejectCheckCDA
            // 
            this.btnRejectCheckCDA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckCDA.AutoExpandOnClick = true;
            this.btnRejectCheckCDA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckCDA.Location = new System.Drawing.Point(15, 80);
            this.btnRejectCheckCDA.Name = "btnRejectCheckCDA";
            this.btnRejectCheckCDA.Size = new System.Drawing.Size(140, 23);
            this.btnRejectCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnWaitCheckCDA.Location = new System.Drawing.Point(15, 54);
            this.btnWaitCheckCDA.Name = "btnWaitCheckCDA";
            this.btnWaitCheckCDA.Size = new System.Drawing.Size(140, 23);
            this.btnWaitCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnNeedCheckCDA.Location = new System.Drawing.Point(15, 27);
            this.btnNeedCheckCDA.Name = "btnNeedCheckCDA";
            this.btnNeedCheckCDA.Size = new System.Drawing.Size(140, 23);
            this.btnNeedCheckCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedCheckCDA.TabIndex = 0;
            this.btnNeedCheckCDA.Text = "a) 需要放行";
            this.btnNeedCheckCDA.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckCDA.Click += new System.EventHandler(this.QueryNeedCheckCDAs);
            // 
            // panelOtherDue
            // 
            this.panelOtherDue.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelOtherDue.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelOtherDue.Controls.Add(this.btnDueFactorCreditLine);
            this.panelOtherDue.Controls.Add(this.btnDueContract);
            this.panelOtherDue.Controls.Add(this.btnDueCDA);
            this.panelOtherDue.Controls.Add(this.btnDueClientCreditLine);
            this.panelOtherDue.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelOtherDue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOtherDue.ExpandOnTitleClick = true;
            this.panelOtherDue.Location = new System.Drawing.Point(400, 0);
            this.panelOtherDue.Name = "panelOtherDue";
            this.panelOtherDue.Size = new System.Drawing.Size(200, 184);
            this.panelOtherDue.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelOtherDue.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelOtherDue.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelOtherDue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelOtherDue.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelOtherDue.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelOtherDue.Style.GradientAngle = 90;
            this.panelOtherDue.TabIndex = 2;
            this.panelOtherDue.TitleHeight = 24;
            this.panelOtherDue.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelOtherDue.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelOtherDue.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelOtherDue.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelOtherDue.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelOtherDue.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelOtherDue.TitleStyle.GradientAngle = 90;
            this.panelOtherDue.TitleText = "其它信息提示";
            // 
            // btnDueFactorCreditLine
            // 
            this.btnDueFactorCreditLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFactorCreditLine.AutoExpandOnClick = true;
            this.btnDueFactorCreditLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFactorCreditLine.Location = new System.Drawing.Point(15, 54);
            this.btnDueFactorCreditLine.Name = "btnDueFactorCreditLine";
            this.btnDueFactorCreditLine.Size = new System.Drawing.Size(160, 23);
            this.btnDueFactorCreditLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueContract.Location = new System.Drawing.Point(15, 106);
            this.btnDueContract.Name = "btnDueContract";
            this.btnDueContract.Size = new System.Drawing.Size(160, 23);
            this.btnDueContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueCDA.Location = new System.Drawing.Point(15, 79);
            this.btnDueCDA.Name = "btnDueCDA";
            this.btnDueCDA.Size = new System.Drawing.Size(160, 23);
            this.btnDueCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueClientCreditLine.Location = new System.Drawing.Point(15, 27);
            this.btnDueClientCreditLine.Name = "btnDueClientCreditLine";
            this.btnDueClientCreditLine.Size = new System.Drawing.Size(160, 23);
            this.btnDueClientCreditLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDueClientCreditLine.TabIndex = 0;
            this.btnDueClientCreditLine.Text = "a) 客户额度到期";
            this.btnDueClientCreditLine.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueClientCreditLine.Click += new System.EventHandler(this.QueryClientCreditLineDue);
            // 
            // panelFinanceDue
            // 
            this.panelFinanceDue.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceDue.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFinanceDue.Controls.Add(this.btnDueFinance);
            this.panelFinanceDue.Controls.Add(this.btnDueFinance0);
            this.panelFinanceDue.Controls.Add(this.btnDueFinance7);
            this.panelFinanceDue.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFinanceDue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFinanceDue.ExpandOnTitleClick = true;
            this.panelFinanceDue.Location = new System.Drawing.Point(200, 0);
            this.panelFinanceDue.Name = "panelFinanceDue";
            this.panelFinanceDue.Size = new System.Drawing.Size(200, 184);
            this.panelFinanceDue.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceDue.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceDue.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceDue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceDue.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFinanceDue.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFinanceDue.Style.GradientAngle = 90;
            this.panelFinanceDue.TabIndex = 1;
            this.panelFinanceDue.TitleHeight = 24;
            this.panelFinanceDue.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceDue.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceDue.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceDue.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFinanceDue.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceDue.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceDue.TitleStyle.GradientAngle = 90;
            this.panelFinanceDue.TitleText = "融资信息预警提示";
            // 
            // btnDueFinance
            // 
            this.btnDueFinance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDueFinance.AutoExpandOnClick = true;
            this.btnDueFinance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDueFinance.Location = new System.Drawing.Point(15, 79);
            this.btnDueFinance.Name = "btnDueFinance";
            this.btnDueFinance.Size = new System.Drawing.Size(140, 23);
            this.btnDueFinance.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueFinance0.Location = new System.Drawing.Point(15, 54);
            this.btnDueFinance0.Name = "btnDueFinance0";
            this.btnDueFinance0.Size = new System.Drawing.Size(140, 23);
            this.btnDueFinance0.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueFinance7.Location = new System.Drawing.Point(15, 27);
            this.btnDueFinance7.Name = "btnDueFinance7";
            this.btnDueFinance7.Size = new System.Drawing.Size(140, 23);
            this.btnDueFinance7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDueFinance7.TabIndex = 0;
            this.btnDueFinance7.Text = "a) 7日内到期";
            this.btnDueFinance7.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueFinance7.Click += new System.EventHandler(this.QueryInvoiceFinanceDueBy7);
            // 
            // panelAssignDue
            // 
            this.panelAssignDue.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelAssignDue.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelAssignDue.Controls.Add(this.btnInvoiceDispute);
            this.panelAssignDue.Controls.Add(this.btnDueAssign);
            this.panelAssignDue.Controls.Add(this.btnDueAssign0);
            this.panelAssignDue.Controls.Add(this.btnDueAssign7);
            this.panelAssignDue.Controls.Add(this.btnDuplicateInvoice);
            this.panelAssignDue.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelAssignDue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAssignDue.ExpandOnTitleClick = true;
            this.panelAssignDue.Location = new System.Drawing.Point(0, 0);
            this.panelAssignDue.Name = "panelAssignDue";
            this.panelAssignDue.Size = new System.Drawing.Size(200, 184);
            this.panelAssignDue.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAssignDue.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelAssignDue.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelAssignDue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelAssignDue.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelAssignDue.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelAssignDue.Style.GradientAngle = 90;
            this.panelAssignDue.TabIndex = 0;
            this.panelAssignDue.TitleHeight = 24;
            this.panelAssignDue.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAssignDue.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelAssignDue.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelAssignDue.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelAssignDue.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelAssignDue.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelAssignDue.TitleStyle.GradientAngle = 90;
            this.panelAssignDue.TitleText = "应收账款预警提示";
            // 
            // btnInvoiceDispute
            // 
            this.btnInvoiceDispute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceDispute.AutoExpandOnClick = true;
            this.btnInvoiceDispute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceDispute.Location = new System.Drawing.Point(15, 106);
            this.btnInvoiceDispute.Name = "btnInvoiceDispute";
            this.btnInvoiceDispute.Size = new System.Drawing.Size(140, 23);
            this.btnInvoiceDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueAssign.Location = new System.Drawing.Point(15, 79);
            this.btnDueAssign.Name = "btnDueAssign";
            this.btnDueAssign.Size = new System.Drawing.Size(140, 23);
            this.btnDueAssign.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueAssign0.Location = new System.Drawing.Point(15, 54);
            this.btnDueAssign0.Name = "btnDueAssign0";
            this.btnDueAssign0.Size = new System.Drawing.Size(140, 23);
            this.btnDueAssign0.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnDueAssign7.Location = new System.Drawing.Point(15, 27);
            this.btnDueAssign7.Name = "btnDueAssign7";
            this.btnDueAssign7.Size = new System.Drawing.Size(140, 23);
            this.btnDueAssign7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDueAssign7.TabIndex = 0;
            this.btnDueAssign7.Text = "a) 7日内到期";
            this.btnDueAssign7.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDueAssign7.Click += new System.EventHandler(this.QueryInvoiceAssignDueBy7);
            // 
            // btnDuplicateInvoice
            // 
            this.btnDuplicateInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDuplicateInvoice.AutoExpandOnClick = true;
            this.btnDuplicateInvoice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDuplicateInvoice.Location = new System.Drawing.Point(15, 132);
            this.btnDuplicateInvoice.Name = "btnDuplicateInvoice";
            this.btnDuplicateInvoice.Size = new System.Drawing.Size(140, 23);
            this.btnDuplicateInvoice.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDuplicateInvoice.TabIndex = 3;
            this.btnDuplicateInvoice.Text = "e) 重复发票";
            this.btnDuplicateInvoice.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDuplicateInvoice.Click += new System.EventHandler(this.QueryDuplicateInvoice);
            // 
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBottom.Controls.Add(this.panelDispute);
            this.panelBottom.Controls.Add(this.panelCheckRefundBatch);
            this.panelBottom.Controls.Add(this.panelCheckPaymentBatch);
            this.panelBottom.Controls.Add(this.panelCheckFinanceBatch);
            this.panelBottom.Controls.Add(this.panelCheckAssignBatch);
            this.panelBottom.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 184);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1001, 202);
            this.panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBottom.Style.GradientAngle = 90;
            this.panelBottom.TabIndex = 3;
            // 
            // panelCheckRefundBatch
            // 
            this.panelCheckRefundBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCheckRefundBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCheckRefundBatch.Controls.Add(this.btnRejectCheckRefundBatch);
            this.panelCheckRefundBatch.Controls.Add(this.btnWaitCheckRefundBatch);
            this.panelCheckRefundBatch.Controls.Add(this.btnNeedCheckRefundBatch);
            this.panelCheckRefundBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCheckRefundBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCheckRefundBatch.ExpandOnTitleClick = true;
            this.panelCheckRefundBatch.Location = new System.Drawing.Point(600, 0);
            this.panelCheckRefundBatch.Name = "panelCheckRefundBatch";
            this.panelCheckRefundBatch.Size = new System.Drawing.Size(200, 202);
            this.panelCheckRefundBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckRefundBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckRefundBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckRefundBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCheckRefundBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCheckRefundBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCheckRefundBatch.Style.GradientAngle = 90;
            this.panelCheckRefundBatch.TabIndex = 4;
            this.panelCheckRefundBatch.TitleHeight = 24;
            this.panelCheckRefundBatch.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckRefundBatch.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckRefundBatch.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckRefundBatch.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCheckRefundBatch.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCheckRefundBatch.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCheckRefundBatch.TitleStyle.GradientAngle = 90;
            this.panelCheckRefundBatch.TitleText = "还款";
            // 
            // btnRejectCheckRefundBatch
            // 
            this.btnRejectCheckRefundBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckRefundBatch.AutoExpandOnClick = true;
            this.btnRejectCheckRefundBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckRefundBatch.Location = new System.Drawing.Point(15, 80);
            this.btnRejectCheckRefundBatch.Name = "btnRejectCheckRefundBatch";
            this.btnRejectCheckRefundBatch.Size = new System.Drawing.Size(140, 23);
            this.btnRejectCheckRefundBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectCheckRefundBatch.TabIndex = 0;
            this.btnRejectCheckRefundBatch.Text = "c) 拒绝放行";
            this.btnRejectCheckRefundBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectCheckRefundBatch.Click += new System.EventHandler(this.QueryRejectCheckRefundBatch);
            // 
            // btnWaitCheckRefundBatch
            // 
            this.btnWaitCheckRefundBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitCheckRefundBatch.AutoExpandOnClick = true;
            this.btnWaitCheckRefundBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitCheckRefundBatch.Location = new System.Drawing.Point(15, 54);
            this.btnWaitCheckRefundBatch.Name = "btnWaitCheckRefundBatch";
            this.btnWaitCheckRefundBatch.Size = new System.Drawing.Size(140, 23);
            this.btnWaitCheckRefundBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitCheckRefundBatch.TabIndex = 0;
            this.btnWaitCheckRefundBatch.Text = "b) 等待放行";
            this.btnWaitCheckRefundBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitCheckRefundBatch.Click += new System.EventHandler(this.QueryWaitCheckRefundBatch);
            // 
            // btnNeedCheckRefundBatch
            // 
            this.btnNeedCheckRefundBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedCheckRefundBatch.AutoExpandOnClick = true;
            this.btnNeedCheckRefundBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedCheckRefundBatch.Location = new System.Drawing.Point(15, 27);
            this.btnNeedCheckRefundBatch.Name = "btnNeedCheckRefundBatch";
            this.btnNeedCheckRefundBatch.Size = new System.Drawing.Size(140, 23);
            this.btnNeedCheckRefundBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedCheckRefundBatch.TabIndex = 0;
            this.btnNeedCheckRefundBatch.Text = "a) 需要放行";
            this.btnNeedCheckRefundBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckRefundBatch.Click += new System.EventHandler(this.QueryNeedCheckRefundBatch);
            // 
            // panelCheckPaymentBatch
            // 
            this.panelCheckPaymentBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCheckPaymentBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCheckPaymentBatch.Controls.Add(this.btnRejectCheckPaymentBatch);
            this.panelCheckPaymentBatch.Controls.Add(this.btnWaitCheckPaymentBatch);
            this.panelCheckPaymentBatch.Controls.Add(this.btnNeedCheckPaymentBatch);
            this.panelCheckPaymentBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCheckPaymentBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCheckPaymentBatch.ExpandOnTitleClick = true;
            this.panelCheckPaymentBatch.Location = new System.Drawing.Point(400, 0);
            this.panelCheckPaymentBatch.Name = "panelCheckPaymentBatch";
            this.panelCheckPaymentBatch.Size = new System.Drawing.Size(200, 202);
            this.panelCheckPaymentBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckPaymentBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckPaymentBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckPaymentBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCheckPaymentBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCheckPaymentBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCheckPaymentBatch.Style.GradientAngle = 90;
            this.panelCheckPaymentBatch.TabIndex = 4;
            this.panelCheckPaymentBatch.TitleHeight = 24;
            this.panelCheckPaymentBatch.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckPaymentBatch.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckPaymentBatch.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckPaymentBatch.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCheckPaymentBatch.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCheckPaymentBatch.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCheckPaymentBatch.TitleStyle.GradientAngle = 90;
            this.panelCheckPaymentBatch.TitleText = "付款";
            // 
            // btnRejectCheckPaymentBatch
            // 
            this.btnRejectCheckPaymentBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckPaymentBatch.AutoExpandOnClick = true;
            this.btnRejectCheckPaymentBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckPaymentBatch.Location = new System.Drawing.Point(15, 80);
            this.btnRejectCheckPaymentBatch.Name = "btnRejectCheckPaymentBatch";
            this.btnRejectCheckPaymentBatch.Size = new System.Drawing.Size(140, 23);
            this.btnRejectCheckPaymentBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectCheckPaymentBatch.TabIndex = 0;
            this.btnRejectCheckPaymentBatch.Text = "c) 拒绝放行";
            this.btnRejectCheckPaymentBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectCheckPaymentBatch.Click += new System.EventHandler(this.QueryRejectCheckPaymentBatch);
            // 
            // btnWaitCheckPaymentBatch
            // 
            this.btnWaitCheckPaymentBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitCheckPaymentBatch.AutoExpandOnClick = true;
            this.btnWaitCheckPaymentBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitCheckPaymentBatch.Location = new System.Drawing.Point(15, 54);
            this.btnWaitCheckPaymentBatch.Name = "btnWaitCheckPaymentBatch";
            this.btnWaitCheckPaymentBatch.Size = new System.Drawing.Size(140, 23);
            this.btnWaitCheckPaymentBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitCheckPaymentBatch.TabIndex = 0;
            this.btnWaitCheckPaymentBatch.Text = "b) 等待放行";
            this.btnWaitCheckPaymentBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitCheckPaymentBatch.Click += new System.EventHandler(this.QueryWaitCheckPaymentBatch);
            // 
            // btnNeedCheckPaymentBatch
            // 
            this.btnNeedCheckPaymentBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedCheckPaymentBatch.AutoExpandOnClick = true;
            this.btnNeedCheckPaymentBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedCheckPaymentBatch.Location = new System.Drawing.Point(15, 27);
            this.btnNeedCheckPaymentBatch.Name = "btnNeedCheckPaymentBatch";
            this.btnNeedCheckPaymentBatch.Size = new System.Drawing.Size(140, 23);
            this.btnNeedCheckPaymentBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedCheckPaymentBatch.TabIndex = 0;
            this.btnNeedCheckPaymentBatch.Text = "a) 需要放行";
            this.btnNeedCheckPaymentBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckPaymentBatch.Click += new System.EventHandler(this.QueryNeedCheckPaymentBatch);
            // 
            // panelCheckFinanceBatch
            // 
            this.panelCheckFinanceBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCheckFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCheckFinanceBatch.Controls.Add(this.btnRejectCheckFinanceBatch);
            this.panelCheckFinanceBatch.Controls.Add(this.btnWaitCheckFinanceBatch);
            this.panelCheckFinanceBatch.Controls.Add(this.btnNeedCheckFinanceBatch);
            this.panelCheckFinanceBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCheckFinanceBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCheckFinanceBatch.ExpandOnTitleClick = true;
            this.panelCheckFinanceBatch.Location = new System.Drawing.Point(200, 0);
            this.panelCheckFinanceBatch.Name = "panelCheckFinanceBatch";
            this.panelCheckFinanceBatch.Size = new System.Drawing.Size(200, 202);
            this.panelCheckFinanceBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckFinanceBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckFinanceBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckFinanceBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCheckFinanceBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCheckFinanceBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCheckFinanceBatch.Style.GradientAngle = 90;
            this.panelCheckFinanceBatch.TabIndex = 4;
            this.panelCheckFinanceBatch.TitleHeight = 24;
            this.panelCheckFinanceBatch.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckFinanceBatch.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckFinanceBatch.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckFinanceBatch.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCheckFinanceBatch.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCheckFinanceBatch.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCheckFinanceBatch.TitleStyle.GradientAngle = 90;
            this.panelCheckFinanceBatch.TitleText = "融资";
            // 
            // btnRejectCheckFinanceBatch
            // 
            this.btnRejectCheckFinanceBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckFinanceBatch.AutoExpandOnClick = true;
            this.btnRejectCheckFinanceBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckFinanceBatch.Location = new System.Drawing.Point(15, 80);
            this.btnRejectCheckFinanceBatch.Name = "btnRejectCheckFinanceBatch";
            this.btnRejectCheckFinanceBatch.Size = new System.Drawing.Size(140, 23);
            this.btnRejectCheckFinanceBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectCheckFinanceBatch.TabIndex = 0;
            this.btnRejectCheckFinanceBatch.Text = "c) 拒绝放行";
            this.btnRejectCheckFinanceBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectCheckFinanceBatch.Click += new System.EventHandler(this.QueryRejectCheckFinanceBatch);
            // 
            // btnWaitCheckFinanceBatch
            // 
            this.btnWaitCheckFinanceBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitCheckFinanceBatch.AutoExpandOnClick = true;
            this.btnWaitCheckFinanceBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitCheckFinanceBatch.Location = new System.Drawing.Point(15, 54);
            this.btnWaitCheckFinanceBatch.Name = "btnWaitCheckFinanceBatch";
            this.btnWaitCheckFinanceBatch.Size = new System.Drawing.Size(140, 23);
            this.btnWaitCheckFinanceBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitCheckFinanceBatch.TabIndex = 0;
            this.btnWaitCheckFinanceBatch.Text = "b) 等待放行";
            this.btnWaitCheckFinanceBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitCheckFinanceBatch.Click += new System.EventHandler(this.QueryWaitCheckFinanceBatch);
            // 
            // btnNeedCheckFinanceBatch
            // 
            this.btnNeedCheckFinanceBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedCheckFinanceBatch.AutoExpandOnClick = true;
            this.btnNeedCheckFinanceBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedCheckFinanceBatch.Location = new System.Drawing.Point(15, 27);
            this.btnNeedCheckFinanceBatch.Name = "btnNeedCheckFinanceBatch";
            this.btnNeedCheckFinanceBatch.Size = new System.Drawing.Size(140, 23);
            this.btnNeedCheckFinanceBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedCheckFinanceBatch.TabIndex = 0;
            this.btnNeedCheckFinanceBatch.Text = "a) 需要放行";
            this.btnNeedCheckFinanceBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckFinanceBatch.Click += new System.EventHandler(this.QueryNeedCheckFinanceBatch);
            // 
            // panelCheckAssignBatch
            // 
            this.panelCheckAssignBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCheckAssignBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCheckAssignBatch.Controls.Add(this.btnRejectCheckAssignBatch);
            this.panelCheckAssignBatch.Controls.Add(this.btnWaitCheckAssignBatch);
            this.panelCheckAssignBatch.Controls.Add(this.btnNeedCheckAssignBatch);
            this.panelCheckAssignBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCheckAssignBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCheckAssignBatch.ExpandOnTitleClick = true;
            this.panelCheckAssignBatch.Location = new System.Drawing.Point(0, 0);
            this.panelCheckAssignBatch.Name = "panelCheckAssignBatch";
            this.panelCheckAssignBatch.Size = new System.Drawing.Size(200, 202);
            this.panelCheckAssignBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckAssignBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckAssignBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckAssignBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCheckAssignBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCheckAssignBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCheckAssignBatch.Style.GradientAngle = 90;
            this.panelCheckAssignBatch.TabIndex = 4;
            this.panelCheckAssignBatch.TitleHeight = 24;
            this.panelCheckAssignBatch.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCheckAssignBatch.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCheckAssignBatch.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCheckAssignBatch.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCheckAssignBatch.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCheckAssignBatch.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCheckAssignBatch.TitleStyle.GradientAngle = 90;
            this.panelCheckAssignBatch.TitleText = "转让";
            // 
            // btnRejectCheckAssignBatch
            // 
            this.btnRejectCheckAssignBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectCheckAssignBatch.AutoExpandOnClick = true;
            this.btnRejectCheckAssignBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectCheckAssignBatch.Location = new System.Drawing.Point(15, 80);
            this.btnRejectCheckAssignBatch.Name = "btnRejectCheckAssignBatch";
            this.btnRejectCheckAssignBatch.Size = new System.Drawing.Size(140, 23);
            this.btnRejectCheckAssignBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectCheckAssignBatch.TabIndex = 0;
            this.btnRejectCheckAssignBatch.Text = "c) 拒绝放行";
            this.btnRejectCheckAssignBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectCheckAssignBatch.Click += new System.EventHandler(this.QueryRejectCheckAssignBatch);
            // 
            // btnWaitCheckAssignBatch
            // 
            this.btnWaitCheckAssignBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitCheckAssignBatch.AutoExpandOnClick = true;
            this.btnWaitCheckAssignBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitCheckAssignBatch.Location = new System.Drawing.Point(15, 54);
            this.btnWaitCheckAssignBatch.Name = "btnWaitCheckAssignBatch";
            this.btnWaitCheckAssignBatch.Size = new System.Drawing.Size(140, 23);
            this.btnWaitCheckAssignBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitCheckAssignBatch.TabIndex = 0;
            this.btnWaitCheckAssignBatch.Text = "b) 等待放行";
            this.btnWaitCheckAssignBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitCheckAssignBatch.Click += new System.EventHandler(this.QueryWaitCheckAssignBatch);
            // 
            // btnNeedCheckAssignBatch
            // 
            this.btnNeedCheckAssignBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedCheckAssignBatch.AutoExpandOnClick = true;
            this.btnNeedCheckAssignBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedCheckAssignBatch.Location = new System.Drawing.Point(15, 27);
            this.btnNeedCheckAssignBatch.Name = "btnNeedCheckAssignBatch";
            this.btnNeedCheckAssignBatch.Size = new System.Drawing.Size(140, 23);
            this.btnNeedCheckAssignBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedCheckAssignBatch.TabIndex = 0;
            this.btnNeedCheckAssignBatch.Text = "a) 需要放行";
            this.btnNeedCheckAssignBatch.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedCheckAssignBatch.Click += new System.EventHandler(this.QueryNeedCheckAssignBatch);
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.Text = "";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
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
            // panelFlaw
            // 
            this.panelFlaw.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFlaw.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFlaw.Controls.Add(this.btnRejectFlawCheck);
            this.panelFlaw.Controls.Add(this.btnWaitFlawCheck);
            this.panelFlaw.Controls.Add(this.btnNeedFlawCheck);
            this.panelFlaw.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFlaw.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFlaw.ExpandOnTitleClick = true;
            this.panelFlaw.Location = new System.Drawing.Point(800, 0);
            this.panelFlaw.Name = "panelFlaw";
            this.panelFlaw.Size = new System.Drawing.Size(200, 184);
            this.panelFlaw.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFlaw.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFlaw.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFlaw.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFlaw.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFlaw.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFlaw.Style.GradientAngle = 90;
            this.panelFlaw.TabIndex = 4;
            this.panelFlaw.TitleHeight = 24;
            this.panelFlaw.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFlaw.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFlaw.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFlaw.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFlaw.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFlaw.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFlaw.TitleStyle.GradientAngle = 90;
            this.panelFlaw.TitleText = "瑕疵";
            // 
            // btnRejectFlawCheck
            // 
            this.btnRejectFlawCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectFlawCheck.AutoExpandOnClick = true;
            this.btnRejectFlawCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectFlawCheck.Location = new System.Drawing.Point(15, 80);
            this.btnRejectFlawCheck.Name = "btnRejectFlawCheck";
            this.btnRejectFlawCheck.Size = new System.Drawing.Size(140, 23);
            this.btnRejectFlawCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectFlawCheck.TabIndex = 0;
            this.btnRejectFlawCheck.Text = "c) 拒绝放行";
            this.btnRejectFlawCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectFlawCheck.Click += new System.EventHandler(this.QueryRejectFlawCheck);
            // 
            // btnWaitFlawCheck
            // 
            this.btnWaitFlawCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitFlawCheck.AutoExpandOnClick = true;
            this.btnWaitFlawCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitFlawCheck.Location = new System.Drawing.Point(15, 54);
            this.btnWaitFlawCheck.Name = "btnWaitFlawCheck";
            this.btnWaitFlawCheck.Size = new System.Drawing.Size(140, 23);
            this.btnWaitFlawCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitFlawCheck.TabIndex = 0;
            this.btnWaitFlawCheck.Text = "b) 等待放行";
            this.btnWaitFlawCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitFlawCheck.Click += new System.EventHandler(this.QueryWaitFlawCheck);
            // 
            // btnNeedFlawCheck
            // 
            this.btnNeedFlawCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedFlawCheck.AutoExpandOnClick = true;
            this.btnNeedFlawCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedFlawCheck.Location = new System.Drawing.Point(15, 27);
            this.btnNeedFlawCheck.Name = "btnNeedFlawCheck";
            this.btnNeedFlawCheck.Size = new System.Drawing.Size(140, 23);
            this.btnNeedFlawCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedFlawCheck.TabIndex = 0;
            this.btnNeedFlawCheck.Text = "a) 需要放行";
            this.btnNeedFlawCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedFlawCheck.Click += new System.EventHandler(this.QueryNeedFlawCheck);
            // 
            // panelDispute
            // 
            this.panelDispute.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelDispute.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelDispute.Controls.Add(this.btnRejectDisputeCheck);
            this.panelDispute.Controls.Add(this.btnWaitDisputeCheck);
            this.panelDispute.Controls.Add(this.btnNeedDisputeCheck);
            this.panelDispute.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDispute.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDispute.ExpandOnTitleClick = true;
            this.panelDispute.Location = new System.Drawing.Point(800, 0);
            this.panelDispute.Name = "panelDispute";
            this.panelDispute.Size = new System.Drawing.Size(200, 202);
            this.panelDispute.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDispute.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDispute.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDispute.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelDispute.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDispute.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDispute.Style.GradientAngle = 90;
            this.panelDispute.TabIndex = 5;
            this.panelDispute.TitleHeight = 24;
            this.panelDispute.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDispute.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDispute.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDispute.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelDispute.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelDispute.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelDispute.TitleStyle.GradientAngle = 90;
            this.panelDispute.TitleText = "商纠";
            // 
            // btnRejectDisputeCheck
            // 
            this.btnRejectDisputeCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRejectDisputeCheck.AutoExpandOnClick = true;
            this.btnRejectDisputeCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRejectDisputeCheck.Location = new System.Drawing.Point(15, 80);
            this.btnRejectDisputeCheck.Name = "btnRejectDisputeCheck";
            this.btnRejectDisputeCheck.Size = new System.Drawing.Size(140, 23);
            this.btnRejectDisputeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnRejectDisputeCheck.TabIndex = 0;
            this.btnRejectDisputeCheck.Text = "c) 拒绝放行";
            this.btnRejectDisputeCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRejectDisputeCheck.Click += new System.EventHandler(this.QueryRejectDisputeCheck);
            // 
            // btnWaitDisputeCheck
            // 
            this.btnWaitDisputeCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaitDisputeCheck.AutoExpandOnClick = true;
            this.btnWaitDisputeCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaitDisputeCheck.Location = new System.Drawing.Point(15, 54);
            this.btnWaitDisputeCheck.Name = "btnWaitDisputeCheck";
            this.btnWaitDisputeCheck.Size = new System.Drawing.Size(140, 23);
            this.btnWaitDisputeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnWaitDisputeCheck.TabIndex = 0;
            this.btnWaitDisputeCheck.Text = "b) 等待放行";
            this.btnWaitDisputeCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnWaitDisputeCheck.Click += new System.EventHandler(this.QueryWaitDisputeCheck);
            // 
            // btnNeedDisputeCheck
            // 
            this.btnNeedDisputeCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNeedDisputeCheck.AutoExpandOnClick = true;
            this.btnNeedDisputeCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNeedDisputeCheck.Location = new System.Drawing.Point(15, 27);
            this.btnNeedDisputeCheck.Name = "btnNeedDisputeCheck";
            this.btnNeedDisputeCheck.Size = new System.Drawing.Size(140, 23);
            this.btnNeedDisputeCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnNeedDisputeCheck.TabIndex = 0;
            this.btnNeedDisputeCheck.Text = "a) 需要放行";
            this.btnNeedDisputeCheck.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNeedDisputeCheck.Click += new System.EventHandler(this.QueryNeedDisputeCheck);
            // 
            // WorkAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "WorkAlert";
            this.Size = new System.Drawing.Size(1001, 386);
            this.panelTop.ResumeLayout(false);
            this.panelCDADue.ResumeLayout(false);
            this.panelOtherDue.ResumeLayout(false);
            this.panelFinanceDue.ResumeLayout(false);
            this.panelAssignDue.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelCheckRefundBatch.ResumeLayout(false);
            this.panelCheckPaymentBatch.ResumeLayout(false);
            this.panelCheckFinanceBatch.ResumeLayout(false);
            this.panelCheckAssignBatch.ResumeLayout(false);
            this.panelFlaw.ResumeLayout(false);
            this.panelDispute.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel panelCDADue;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckCDA;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckCDA;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckCDA;

        private DevComponents.DotNetBar.ExpandablePanel panelCheckAssignBatch;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckAssignBatch;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckAssignBatch;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckAssignBatch;

        private DevComponents.DotNetBar.ExpandablePanel panelCheckFinanceBatch;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckFinanceBatch;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckFinanceBatch;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckFinanceBatch;

        private DevComponents.DotNetBar.ExpandablePanel panelCheckPaymentBatch;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckPaymentBatch;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckPaymentBatch;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckPaymentBatch;

        private DevComponents.DotNetBar.ExpandablePanel panelCheckRefundBatch;
        private DevComponents.DotNetBar.ButtonX btnRejectCheckRefundBatch;
        private DevComponents.DotNetBar.ButtonX btnWaitCheckRefundBatch;
        private DevComponents.DotNetBar.ButtonX btnNeedCheckRefundBatch;
        private DevComponents.DotNetBar.ExpandablePanel panelFlaw;
        private DevComponents.DotNetBar.ButtonX btnRejectFlawCheck;
        private DevComponents.DotNetBar.ButtonX btnWaitFlawCheck;
        private DevComponents.DotNetBar.ButtonX btnNeedFlawCheck;
        private DevComponents.DotNetBar.ExpandablePanel panelDispute;
        private DevComponents.DotNetBar.ButtonX btnRejectDisputeCheck;
        private DevComponents.DotNetBar.ButtonX btnWaitDisputeCheck;
        private DevComponents.DotNetBar.ButtonX btnNeedDisputeCheck;
    }
}
