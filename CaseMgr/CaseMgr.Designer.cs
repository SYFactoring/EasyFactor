namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseMgr
    {
		#region?Fields?(62)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCurrency;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsLowRisk;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuContractMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCurrency;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblOPName;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaculateInvoices;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNegNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemLegerReport;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbOPName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbIsPool = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.cbIsContractSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.cbIsLowRisk = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCode = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCurrency = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.diEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbOPName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblOPName = new DevComponents.DotNetBar.LabelX();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetInterestIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarginIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHighestFinanceLineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuContractMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCaseSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCaseNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverNegNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLegerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLegerExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLegerExportLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaculateInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.cmuContractMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelQuery.Controls.Add(this.cbIsPool);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.cbCaseMark);
            this.panelQuery.Controls.Add(this.lblCaseMark);
            this.panelQuery.Controls.Add(this.cbIsContractSigned);
            this.panelQuery.Controls.Add(this.btnQueryReset);
            this.panelQuery.Controls.Add(this.cbIsLowRisk);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbCaseCode);
            this.panelQuery.Controls.Add(this.lblCaseCode);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.lblDate);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.cbCurrency);
            this.panelQuery.Controls.Add(this.lblCurrency);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.diEnd);
            this.panelQuery.Controls.Add(this.diBegin);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(819, 71);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // cbIsPool
            // 
            this.cbIsPool.AutoSize = true;
            // 
            // 
            // 
            this.cbIsPool.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsPool.Location = new System.Drawing.Point(524, 48);
            this.cbIsPool.Name = "cbIsPool";
            this.cbIsPool.Size = new System.Drawing.Size(88, 18);
            this.cbIsPool.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbIsPool.TabIndex = 21;
            this.cbIsPool.Text = "是否池融资";
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(59, 28);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(133, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(3, 30);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 18);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "所属公司";
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DisplayMember = "Text";
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.FormattingEnabled = true;
            this.cbCaseMark.ItemHeight = 14;
            this.cbCaseMark.Items.AddRange(new object[] {
            "全部",
            "申请案",
            "启动案",
            "已结案"});
            this.cbCaseMark.Location = new System.Drawing.Point(254, 26);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(133, 20);
            this.cbCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbCaseMark.TabIndex = 11;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseMark.Location = new System.Drawing.Point(198, 29);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(56, 18);
            this.lblCaseMark.TabIndex = 10;
            this.lblCaseMark.Text = "案件状态";
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsContractSigned.Location = new System.Drawing.Point(524, 5);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(125, 18);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbIsContractSigned.TabIndex = 19;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(656, 28);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 19);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQueryReset.TabIndex = 23;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsLowRisk
            // 
            this.cbIsLowRisk.AutoSize = true;
            // 
            // 
            // 
            this.cbIsLowRisk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsLowRisk.Location = new System.Drawing.Point(524, 27);
            this.cbIsLowRisk.Name = "cbIsLowRisk";
            this.cbIsLowRisk.Size = new System.Drawing.Size(88, 18);
            this.cbIsLowRisk.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbIsLowRisk.TabIndex = 20;
            this.cbIsLowRisk.Text = "是否低风险";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(59, 6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(133, 21);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(3, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "客户名称";
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseCode.Location = new System.Drawing.Point(254, 5);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.Size = new System.Drawing.Size(133, 21);
            this.tbCaseCode.TabIndex = 3;
            // 
            // lblCaseCode
            // 
            this.lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseCode.Location = new System.Drawing.Point(198, 6);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(56, 18);
            this.lblCaseCode.TabIndex = 2;
            this.lblCaseCode.Text = "案件编号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(656, 51);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 18);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "获得 条记录";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(198, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 18);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "查询期限";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(656, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 19);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 22;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryCase);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Text";
            this.cbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.ItemHeight = 14;
            this.cbCurrency.Location = new System.Drawing.Point(430, 4);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(79, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbCurrency.TabIndex = 18;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCurrency.Location = new System.Drawing.Point(393, 6);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(31, 18);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "币别";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Items.AddRange(new object[] {
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(59, 46);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(133, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbTransactionType.TabIndex = 13;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTransactionType.Location = new System.Drawing.Point(3, 49);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(56, 18);
            this.lblTransactionType.TabIndex = 12;
            this.lblTransactionType.Text = "业务类别";
            // 
            // diEnd
            // 
            // 
            // 
            // 
            this.diEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diEnd.ButtonDropDown.Visible = true;
            this.diEnd.ButtonFreeText.Checked = true;
            this.diEnd.FreeTextEntryMode = true;
            this.diEnd.IsPopupCalendarOpen = false;
            this.diEnd.Location = new System.Drawing.Point(360, 47);
            // 
            // 
            // 
            this.diEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.MonthCalendar.TodayButtonVisible = true;
            this.diEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diEnd.Name = "diEnd";
            this.diEnd.Size = new System.Drawing.Size(100, 21);
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.diEnd.TabIndex = 16;
            // 
            // diBegin
            // 
            // 
            // 
            // 
            this.diBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diBegin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diBegin.ButtonDropDown.Visible = true;
            this.diBegin.ButtonFreeText.Checked = true;
            this.diBegin.FreeTextEntryMode = true;
            this.diBegin.IsPopupCalendarOpen = false;
            this.diBegin.Location = new System.Drawing.Point(254, 47);
            // 
            // 
            // 
            this.diBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diBegin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.MonthCalendar.TodayButtonVisible = true;
            this.diBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diBegin.Name = "diBegin";
            this.diBegin.Size = new System.Drawing.Size(100, 21);
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.diBegin.TabIndex = 15;
            // 
            // tbOPName
            // 
            // 
            // 
            // 
            this.tbOPName.Border.Class = "TextBoxBorder";
            this.tbOPName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbOPName.Location = new System.Drawing.Point(460, 6);
            this.tbOPName.Name = "tbOPName";
            this.tbOPName.Size = new System.Drawing.Size(133, 20);
            this.tbOPName.TabIndex = 5;
            // 
            // lblOPName
            // 
            this.lblOPName.AutoSize = true;
            // 
            // 
            // 
            this.lblOPName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOPName.Location = new System.Drawing.Point(404, 7);
            this.lblOPName.Name = "lblOPName";
            this.lblOPName.Size = new System.Drawing.Size(0, 0);
            this.lblOPName.TabIndex = 4;
            this.lblOPName.Text = "OP人员";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseCode,
            this.colSellerClient,
            this.colSellerFactor,
            this.colBuyerClient,
            this.colBuyerFactor,
            this.colInvoiceCurrency,
            this.colTransactionType,
            this.colIsPool,
            this.colAppDate,
            this.colCaseMark,
            this.colAssignAmount,
            this.colFinanceAmount,
            this.colCommissionIncome,
            this.colNetInterestIncome,
            this.colMarginIncome,
            this.colTotalIncome,
            this.colAssignOutstanding,
            this.colTotalAssignOutstanding,
            this.colCreditCoverOutstanding,
            this.colFinanceOutstanding,
            this.colTotalFinanceOutstanding,
            this.colFinanceLineOutstanding,
            this.colHighestFinanceLineAmount});
            this.dgvCases.ContextMenuStrip = this.cmuContractMgr;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.Location = new System.Drawing.Point(0, 71);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCases.Size = new System.Drawing.Size(819, 284);
            this.dgvCases.TabIndex = 1;
            this.dgvCases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCases.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCaseCellFormatting);
            this.dgvCases.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCasesRowPostPaint);
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.Frozen = true;
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            this.colCaseCode.Width = 80;
            // 
            // colSellerClient
            // 
            this.colSellerClient.DataPropertyName = "SellerClientName";
            this.colSellerClient.Frozen = true;
            this.colSellerClient.HeaderText = "卖方名称";
            this.colSellerClient.Name = "colSellerClient";
            this.colSellerClient.ReadOnly = true;
            this.colSellerClient.Width = 80;
            // 
            // colSellerFactor
            // 
            this.colSellerFactor.DataPropertyName = "SellerFactorName";
            this.colSellerFactor.HeaderText = "卖方保理商";
            this.colSellerFactor.Name = "colSellerFactor";
            this.colSellerFactor.ReadOnly = true;
            this.colSellerFactor.Width = 92;
            // 
            // colBuyerClient
            // 
            this.colBuyerClient.DataPropertyName = "BuyerClientName";
            this.colBuyerClient.HeaderText = "买方名称";
            this.colBuyerClient.Name = "colBuyerClient";
            this.colBuyerClient.ReadOnly = true;
            this.colBuyerClient.Width = 80;
            // 
            // colBuyerFactor
            // 
            this.colBuyerFactor.DataPropertyName = "BuyerFactorName";
            this.colBuyerFactor.HeaderText = "买方保理商";
            this.colBuyerFactor.Name = "colBuyerFactor";
            this.colBuyerFactor.ReadOnly = true;
            this.colBuyerFactor.Width = 92;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Width = 80;
            // 
            // colIsPool
            // 
            this.colIsPool.DataPropertyName = "IsPool";
            this.colIsPool.HeaderText = "池融资";
            this.colIsPool.Name = "colIsPool";
            this.colIsPool.ReadOnly = true;
            // 
            // colAppDate
            // 
            this.colAppDate.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle32.Format = "d";
            this.colAppDate.DefaultCellStyle = dataGridViewCellStyle32;
            this.colAppDate.HeaderText = "申请日期";
            this.colAppDate.Name = "colAppDate";
            this.colAppDate.ReadOnly = true;
            this.colAppDate.Width = 80;
            // 
            // colCaseMark
            // 
            this.colCaseMark.DataPropertyName = "CaseMark";
            this.colCaseMark.HeaderText = "案件状态";
            this.colCaseMark.Name = "colCaseMark";
            this.colCaseMark.ReadOnly = true;
            this.colCaseMark.Width = 80;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmountByDate";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N2";
            dataGridViewCellStyle33.NullValue = null;
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle33;
            this.colAssignAmount.HeaderText = "转让量";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Visible = false;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmountByDate";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N2";
            dataGridViewCellStyle34.NullValue = null;
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle34;
            this.colFinanceAmount.HeaderText = "融资量";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Visible = false;
            // 
            // colCommissionIncome
            // 
            this.colCommissionIncome.DataPropertyName = "CommissionIncomeByDate";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "N2";
            dataGridViewCellStyle35.NullValue = null;
            this.colCommissionIncome.DefaultCellStyle = dataGridViewCellStyle35;
            this.colCommissionIncome.HeaderText = "保理费收入";
            this.colCommissionIncome.Name = "colCommissionIncome";
            this.colCommissionIncome.ReadOnly = true;
            this.colCommissionIncome.Visible = false;
            // 
            // colNetInterestIncome
            // 
            this.colNetInterestIncome.DataPropertyName = "NetInterestIncomeByDate";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N2";
            this.colNetInterestIncome.DefaultCellStyle = dataGridViewCellStyle36;
            this.colNetInterestIncome.HeaderText = "净利息收入";
            this.colNetInterestIncome.Name = "colNetInterestIncome";
            this.colNetInterestIncome.ReadOnly = true;
            this.colNetInterestIncome.Visible = false;
            // 
            // colMarginIncome
            // 
            this.colMarginIncome.DataPropertyName = "MarginIncomeByDate";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle37.Format = "N2";
            this.colMarginIncome.DefaultCellStyle = dataGridViewCellStyle37;
            this.colMarginIncome.HeaderText = "代付利差收入";
            this.colMarginIncome.Name = "colMarginIncome";
            this.colMarginIncome.ReadOnly = true;
            this.colMarginIncome.Visible = false;
            // 
            // colTotalIncome
            // 
            this.colTotalIncome.DataPropertyName = "TotalIncomeByDate";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.Format = "N2";
            this.colTotalIncome.DefaultCellStyle = dataGridViewCellStyle38;
            this.colTotalIncome.HeaderText = "总收入";
            this.colTotalIncome.Name = "colTotalIncome";
            this.colTotalIncome.ReadOnly = true;
            this.colTotalIncome.Visible = false;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle39;
            this.colAssignOutstanding.HeaderText = "应收帐款余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colTotalAssignOutstanding
            // 
            this.colTotalAssignOutstanding.DataPropertyName = "TotalAssignOutstanding";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewCellStyle40.NullValue = null;
            this.colTotalAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle40;
            this.colTotalAssignOutstanding.HeaderText = "总帐款余额";
            this.colTotalAssignOutstanding.Name = "colTotalAssignOutstanding";
            this.colTotalAssignOutstanding.ReadOnly = true;
            // 
            // colCreditCoverOutstanding
            // 
            this.colCreditCoverOutstanding.DataPropertyName = "CreditCoverOutstanding";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N2";
            this.colCreditCoverOutstanding.DefaultCellStyle = dataGridViewCellStyle41;
            this.colCreditCoverOutstanding.HeaderText = "剩余信用风险额度";
            this.colCreditCoverOutstanding.Name = "colCreditCoverOutstanding";
            this.colCreditCoverOutstanding.ReadOnly = true;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N2";
            dataGridViewCellStyle42.NullValue = null;
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle42;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colTotalFinanceOutstanding
            // 
            this.colTotalFinanceOutstanding.DataPropertyName = "TotalFinanceOutstanding";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle43.Format = "N2";
            this.colTotalFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle43;
            this.colTotalFinanceOutstanding.HeaderText = "总融资余额";
            this.colTotalFinanceOutstanding.Name = "colTotalFinanceOutstanding";
            this.colTotalFinanceOutstanding.ReadOnly = true;
            // 
            // colFinanceLineOutstanding
            // 
            this.colFinanceLineOutstanding.DataPropertyName = "FinanceLineOutstanding";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.Format = "N2";
            this.colFinanceLineOutstanding.DefaultCellStyle = dataGridViewCellStyle44;
            this.colFinanceLineOutstanding.HeaderText = "剩余关联融资额度";
            this.colFinanceLineOutstanding.Name = "colFinanceLineOutstanding";
            this.colFinanceLineOutstanding.ReadOnly = true;
            // 
            // colHighestFinanceLineAmount
            // 
            this.colHighestFinanceLineAmount.DataPropertyName = "HighestFinanceLineAmount";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.Format = "N2";
            this.colHighestFinanceLineAmount.DefaultCellStyle = dataGridViewCellStyle45;
            this.colHighestFinanceLineAmount.HeaderText = "最高融资额度";
            this.colHighestFinanceLineAmount.Name = "colHighestFinanceLineAmount";
            this.colHighestFinanceLineAmount.ReadOnly = true;
            // 
            // cmuContractMgr
            // 
            this.cmuContractMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCaseSelect,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemCaseNew,
            this.menuItemCreditCoverNegNew,
            this.menuItemCaseDelete,
            this.toolStripSeparator1,
            this.menuItemLegerReport,
            this.menuItemCaseExport,
            this.menuItemCaculateInvoices});
            this.cmuContractMgr.Name = "cmuContractMgr";
            this.cmuContractMgr.Size = new System.Drawing.Size(149, 192);
            // 
            // menuItemCaseSelect
            // 
            this.menuItemCaseSelect.Name = "menuItemCaseSelect";
            this.menuItemCaseSelect.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseSelect.Text = "选定案件";
            this.menuItemCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseDetail.Text = "详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // menuItemCaseNew
            // 
            this.menuItemCaseNew.Name = "menuItemCaseNew";
            this.menuItemCaseNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseNew.Text = "新建案件";
            this.menuItemCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // menuItemCreditCoverNegNew
            // 
            this.menuItemCreditCoverNegNew.Name = "menuItemCreditCoverNegNew";
            this.menuItemCreditCoverNegNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditCoverNegNew.Text = "新建额度申请";
            this.menuItemCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // menuItemCaseDelete
            // 
            this.menuItemCaseDelete.Name = "menuItemCaseDelete";
            this.menuItemCaseDelete.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseDelete.Text = "删除案件";
            this.menuItemCaseDelete.Click += new System.EventHandler(this.DeleteCase);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuItemLegerReport
            // 
            this.menuItemLegerReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLegerExportAll,
            this.menuItemLegerExportLeft});
            this.menuItemLegerReport.Name = "menuItemLegerReport";
            this.menuItemLegerReport.Size = new System.Drawing.Size(148, 22);
            this.menuItemLegerReport.Text = "导出台帐";
            // 
            // menuItemLegerExportAll
            // 
            this.menuItemLegerExportAll.Name = "menuItemLegerExportAll";
            this.menuItemLegerExportAll.Size = new System.Drawing.Size(112, 22);
            this.menuItemLegerExportAll.Text = "全部";
            this.menuItemLegerExportAll.Click += new System.EventHandler(this.ReportLegerAll);
            // 
            // menuItemLegerExportLeft
            // 
            this.menuItemLegerExportLeft.Name = "menuItemLegerExportLeft";
            this.menuItemLegerExportLeft.Size = new System.Drawing.Size(112, 22);
            this.menuItemLegerExportLeft.Text = "未结清";
            this.menuItemLegerExportLeft.Click += new System.EventHandler(this.ReportLegerLeft);
            // 
            // menuItemCaseExport
            // 
            this.menuItemCaseExport.Name = "menuItemCaseExport";
            this.menuItemCaseExport.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseExport.Text = "导出案子";
            this.menuItemCaseExport.Click += new System.EventHandler(this.ExportCases);
            // 
            // menuItemCaculateInvoices
            // 
            this.menuItemCaculateInvoices.Name = "menuItemCaculateInvoices";
            this.menuItemCaculateInvoices.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaculateInvoices.Text = "重新计算数值";
            this.menuItemCaculateInvoices.Click += new System.EventHandler(this.CaculateInvoices);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SellerClientName";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "卖方名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SellerFactorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "卖方保理商";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 92;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuyerClient";
            this.dataGridViewTextBoxColumn4.HeaderText = "买方名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BuyerFactor";
            this.dataGridViewTextBoxColumn5.HeaderText = "买方保理商";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InvoiceCurrency";
            this.dataGridViewTextBoxColumn6.HeaderText = "发票币别";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn7.HeaderText = "业务类别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IsPool";
            this.dataGridViewTextBoxColumn8.HeaderText = "池融资";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OperationType";
            this.dataGridViewTextBoxColumn9.HeaderText = "操作类型";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OwnerDepartment";
            this.dataGridViewTextBoxColumn10.HeaderText = "业务归属机构";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 104;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle1.Format = "d";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn11.HeaderText = "申请日期";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CaseMark";
            this.dataGridViewTextBoxColumn12.HeaderText = "案件状态";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AssignAmountByDate";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn13.HeaderText = "转让量";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FinanceAmountByDate";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle47.Format = "N2";
            dataGridViewCellStyle47.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewTextBoxColumn14.HeaderText = "融资量";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CommissionIncomeByDate";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "N2";
            dataGridViewCellStyle48.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewTextBoxColumn15.HeaderText = "保理费收入";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NetInterestIncomeByDate";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.Format = "N2";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridViewTextBoxColumn16.HeaderText = "净利息收入";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MarginIncomeByDate";
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle50.Format = "N2";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewTextBoxColumn17.HeaderText = "代付利差收入";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TotalIncomeByDate";
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle51.Format = "N2";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle51;
            this.dataGridViewTextBoxColumn18.HeaderText = "总收入";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle52.Format = "N2";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle52;
            this.dataGridViewTextBoxColumn19.HeaderText = "应收帐款余额";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TotalAssignOutstanding";
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle53.Format = "N2";
            dataGridViewCellStyle53.NullValue = null;
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle53;
            this.dataGridViewTextBoxColumn20.HeaderText = "总帐款余额";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "CreditCoverOutstanding";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle54.Format = "N2";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle54;
            this.dataGridViewTextBoxColumn21.HeaderText = "剩余信用风险额度";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle55.Format = "N2";
            dataGridViewCellStyle55.NullValue = null;
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridViewTextBoxColumn22.HeaderText = "融资余额";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TotalFinanceOutstanding";
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle56.Format = "N2";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridViewTextBoxColumn23.HeaderText = "总融资余额";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FinanceLineOutstanding";
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle57.Format = "N2";
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridViewTextBoxColumn24.HeaderText = "剩余关联融资额度";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "HighestFinanceLineAmount";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.Format = "N2";
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridViewTextBoxColumn25.HeaderText = "最高融资额度";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // CaseMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCases);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CaseMgr";
            this.Size = new System.Drawing.Size(819, 355);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.cmuContractMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItemLegerExportAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemLegerExportLeft;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsPool;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsPool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetInterestIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarginIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHighestFinanceLineAmount;
    }
}
