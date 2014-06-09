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
        private DevComponents.DotNetBar.Controls.ComboTree cbOwnerDepts;
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
        private DevComponents.DotNetBar.LabelX lblOnwerDept;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbIsPool = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.tbOPName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblOPName = new DevComponents.DotNetBar.LabelX();
            this.cbOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblOnwerDept = new DevComponents.DotNetBar.LabelX();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelQuery.Controls.Add(this.cbOwnerDepts);
            this.panelQuery.Controls.Add(this.lblOnwerDept);
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
            this.cbIsPool.Location = new System.Drawing.Point(599, 49);
            this.cbIsPool.Name = "cbIsPool";
            this.cbIsPool.Size = new System.Drawing.Size(88, 18);
            this.cbIsPool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsPool.TabIndex = 21;
            this.cbIsPool.Text = "�Ƿ������";
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DisplayMember = "Text";
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCaseMark.FormattingEnabled = true;
            this.cbCaseMark.ItemHeight = 14;
            this.cbCaseMark.Items.AddRange(new object[] {
            "ȫ��",
            "���밸",
            "������",
            "�ѽ᰸"});
            this.cbCaseMark.Location = new System.Drawing.Point(460, 26);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(133, 20);
            this.cbCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseMark.TabIndex = 11;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseMark.Location = new System.Drawing.Point(398, 27);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(56, 18);
            this.lblCaseMark.TabIndex = 10;
            this.lblCaseMark.Text = "����״̬";
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsContractSigned.Location = new System.Drawing.Point(599, 6);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(125, 18);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 19;
            this.cbIsContractSigned.Text = "�Ƿ�ǩ�������ͬ";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(731, 29);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 19);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 23;
            this.btnQueryReset.Text = "����";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsLowRisk
            // 
            this.cbIsLowRisk.AutoSize = true;
            // 
            // 
            // 
            this.cbIsLowRisk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsLowRisk.Location = new System.Drawing.Point(599, 28);
            this.cbIsLowRisk.Name = "cbIsLowRisk";
            this.cbIsLowRisk.Size = new System.Drawing.Size(88, 18);
            this.cbIsLowRisk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsLowRisk.TabIndex = 20;
            this.cbIsLowRisk.Text = "�Ƿ�ͷ���";
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
            this.lblClientName.Text = "�ͻ�����";
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
            this.lblCaseCode.Text = "�������";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(731, 52);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 18);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "��� ����¼";
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
            this.lblDate.Text = "��ѯ����";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(731, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 19);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 22;
            this.btnQuery.Text = "��ѯ";
            this.btnQuery.Click += new System.EventHandler(this.QueryCase);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Text";
            this.cbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.ItemHeight = 14;
            this.cbCurrency.Location = new System.Drawing.Point(514, 47);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(79, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCurrency.TabIndex = 18;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCurrency.Location = new System.Drawing.Point(477, 49);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(31, 18);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "�ұ�";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Items.AddRange(new object[] {
            "������������",
            "�����򷽱���",
            "���ڱ���",
            "���ڱ���"});
            this.cbTransactionType.Location = new System.Drawing.Point(59, 46);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(133, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.lblTransactionType.Text = "ҵ�����";
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
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diBegin.TabIndex = 15;
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(59, 28);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(133, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "ҵ�����";
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
            this.lblOPName.TabIndex = 4;
            this.lblOPName.Text = "OP��Ա";
            // 
            // cbOwnerDepts
            // 
            this.cbOwnerDepts.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbOwnerDepts.BackgroundStyle.Class = "TextBoxBorder";
            this.cbOwnerDepts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbOwnerDepts.ButtonDropDown.Visible = true;
            this.cbOwnerDepts.Location = new System.Drawing.Point(254, 27);
            this.cbOwnerDepts.Name = "cbOwnerDepts";
            this.cbOwnerDepts.Size = new System.Drawing.Size(133, 22);
            this.cbOwnerDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbOwnerDepts.TabIndex = 9;
            // 
            // lblOnwerDept
            // 
            this.lblOnwerDept.AutoSize = true;
            // 
            // 
            // 
            this.lblOnwerDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOnwerDept.Location = new System.Drawing.Point(198, 29);
            this.lblOnwerDept.Name = "lblOnwerDept";
            this.lblOnwerDept.TabIndex = 8;
            this.lblOnwerDept.Text = "ҵ�����";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle16;
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
            this.menuItemCaseSelect.Text = "ѡ������";
            this.menuItemCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseDetail.Text = "��ϸ��Ϣ";
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
            this.menuItemCaseNew.Text = "�½�����";
            this.menuItemCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // menuItemCreditCoverNegNew
            // 
            this.menuItemCreditCoverNegNew.Name = "menuItemCreditCoverNegNew";
            this.menuItemCreditCoverNegNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditCoverNegNew.Text = "�½��������";
            this.menuItemCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // menuItemCaseDelete
            // 
            this.menuItemCaseDelete.Name = "menuItemCaseDelete";
            this.menuItemCaseDelete.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseDelete.Text = "ɾ������";
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
            this.menuItemLegerReport.Text = "����̨��";
            // 
            // menuItemLegerExportAll
            // 
            this.menuItemLegerExportAll.Name = "menuItemLegerExportAll";
            this.menuItemLegerExportAll.Size = new System.Drawing.Size(112, 22);
            this.menuItemLegerExportAll.Text = "ȫ��";
            this.menuItemLegerExportAll.Click += new System.EventHandler(this.ReportLegerAll);
            // 
            // menuItemLegerExportLeft
            // 
            this.menuItemLegerExportLeft.Name = "menuItemLegerExportLeft";
            this.menuItemLegerExportLeft.Size = new System.Drawing.Size(112, 22);
            this.menuItemLegerExportLeft.Text = "δ����";
            this.menuItemLegerExportLeft.Click += new System.EventHandler(this.ReportLegerLeft);
            // 
            // menuItemCaseExport
            // 
            this.menuItemCaseExport.Name = "menuItemCaseExport";
            this.menuItemCaseExport.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaseExport.Text = "��������";
            this.menuItemCaseExport.Click += new System.EventHandler(this.ExportCases);
            // 
            // menuItemCaculateInvoices
            // 
            this.menuItemCaculateInvoices.Name = "menuItemCaculateInvoices";
            this.menuItemCaculateInvoices.Size = new System.Drawing.Size(148, 22);
            this.menuItemCaculateInvoices.Text = "���¼�����ֵ";
            this.menuItemCaculateInvoices.Click += new System.EventHandler(this.CaculateInvoices);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "�������";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SellerClientName";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "��������";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SellerFactorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "����������";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 92;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuyerClient";
            this.dataGridViewTextBoxColumn4.HeaderText = "������";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BuyerFactor";
            this.dataGridViewTextBoxColumn5.HeaderText = "�򷽱�����";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InvoiceCurrency";
            this.dataGridViewTextBoxColumn6.HeaderText = "��Ʊ�ұ�";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn7.HeaderText = "ҵ�����";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IsPool";
            this.dataGridViewTextBoxColumn8.HeaderText = "������";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OperationType";
            this.dataGridViewTextBoxColumn9.HeaderText = "��������";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OwnerDepartment";
            this.dataGridViewTextBoxColumn10.HeaderText = "ҵ���������";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 104;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle17.Format = "d";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn11.HeaderText = "��������";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CaseMark";
            this.dataGridViewTextBoxColumn12.HeaderText = "����״̬";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AssignAmountByDate";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn13.HeaderText = "ת����";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FinanceAmountByDate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn14.HeaderText = "������";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CommissionIncomeByDate";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn15.HeaderText = "���������";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NetInterestIncomeByDate";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn16.HeaderText = "����Ϣ����";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MarginIncomeByDate";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn17.HeaderText = "������������";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TotalIncomeByDate";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn18.HeaderText = "������";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn19.HeaderText = "Ӧ���ʿ����";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TotalAssignOutstanding";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn20.HeaderText = "���ʿ����";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "CreditCoverOutstanding";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn21.HeaderText = "ʣ�����÷��ն��";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn22.HeaderText = "�������";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TotalFinanceOutstanding";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn23.HeaderText = "���������";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FinanceLineOutstanding";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "N2";
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn24.HeaderText = "ʣ��������ʶ��";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "HighestFinanceLineAmount";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Format = "N2";
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn25.HeaderText = "������ʶ��";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.Frozen = true;
            this.colCaseCode.HeaderText = "�������";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            this.colCaseCode.Width = 80;
            // 
            // colSellerClient
            // 
            this.colSellerClient.DataPropertyName = "SellerClientName";
            this.colSellerClient.Frozen = true;
            this.colSellerClient.HeaderText = "��������";
            this.colSellerClient.Name = "colSellerClient";
            this.colSellerClient.ReadOnly = true;
            this.colSellerClient.Width = 80;
            // 
            // colSellerFactor
            // 
            this.colSellerFactor.DataPropertyName = "SellerFactorName";
            this.colSellerFactor.HeaderText = "����������";
            this.colSellerFactor.Name = "colSellerFactor";
            this.colSellerFactor.ReadOnly = true;
            this.colSellerFactor.Width = 92;
            // 
            // colBuyerClient
            // 
            this.colBuyerClient.DataPropertyName = "BuyerClientName";
            this.colBuyerClient.HeaderText = "������";
            this.colBuyerClient.Name = "colBuyerClient";
            this.colBuyerClient.ReadOnly = true;
            this.colBuyerClient.Width = 80;
            // 
            // colBuyerFactor
            // 
            this.colBuyerFactor.DataPropertyName = "BuyerFactorName";
            this.colBuyerFactor.HeaderText = "�򷽱�����";
            this.colBuyerFactor.Name = "colBuyerFactor";
            this.colBuyerFactor.ReadOnly = true;
            this.colBuyerFactor.Width = 92;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "��Ʊ�ұ�";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "ҵ�����";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Width = 80;
            // 
            // colIsPool
            // 
            this.colIsPool.DataPropertyName = "IsPool";
            this.colIsPool.HeaderText = "������";
            this.colIsPool.Name = "colIsPool";
            this.colIsPool.ReadOnly = true;
            // 
            // colAppDate
            // 
            this.colAppDate.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle2.Format = "d";
            this.colAppDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAppDate.HeaderText = "��������";
            this.colAppDate.Name = "colAppDate";
            this.colAppDate.ReadOnly = true;
            this.colAppDate.Width = 80;
            // 
            // colCaseMark
            // 
            this.colCaseMark.DataPropertyName = "CaseMark";
            this.colCaseMark.HeaderText = "����״̬";
            this.colCaseMark.Name = "colCaseMark";
            this.colCaseMark.ReadOnly = true;
            this.colCaseMark.Width = 80;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmountByDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignAmount.HeaderText = "ת����";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Visible = false;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmountByDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinanceAmount.HeaderText = "������";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Visible = false;
            // 
            // colCommissionIncome
            // 
            this.colCommissionIncome.DataPropertyName = "CommissionIncomeByDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colCommissionIncome.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCommissionIncome.HeaderText = "���������";
            this.colCommissionIncome.Name = "colCommissionIncome";
            this.colCommissionIncome.ReadOnly = true;
            this.colCommissionIncome.Visible = false;
            // 
            // colNetInterestIncome
            // 
            this.colNetInterestIncome.DataPropertyName = "NetInterestIncomeByDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.colNetInterestIncome.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNetInterestIncome.HeaderText = "����Ϣ����";
            this.colNetInterestIncome.Name = "colNetInterestIncome";
            this.colNetInterestIncome.ReadOnly = true;
            this.colNetInterestIncome.Visible = false;
            // 
            // colMarginIncome
            // 
            this.colMarginIncome.DataPropertyName = "MarginIncomeByDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.colMarginIncome.DefaultCellStyle = dataGridViewCellStyle7;
            this.colMarginIncome.HeaderText = "������������";
            this.colMarginIncome.Name = "colMarginIncome";
            this.colMarginIncome.ReadOnly = true;
            this.colMarginIncome.Visible = false;
            // 
            // colTotalIncome
            // 
            this.colTotalIncome.DataPropertyName = "TotalIncomeByDate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.colTotalIncome.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTotalIncome.HeaderText = "������";
            this.colTotalIncome.Name = "colTotalIncome";
            this.colTotalIncome.ReadOnly = true;
            this.colTotalIncome.Visible = false;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle9;
            this.colAssignOutstanding.HeaderText = "Ӧ���ʿ����";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colTotalAssignOutstanding
            // 
            this.colTotalAssignOutstanding.DataPropertyName = "TotalAssignOutstanding";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.colTotalAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTotalAssignOutstanding.HeaderText = "���ʿ����";
            this.colTotalAssignOutstanding.Name = "colTotalAssignOutstanding";
            this.colTotalAssignOutstanding.ReadOnly = true;
            // 
            // colCreditCoverOutstanding
            // 
            this.colCreditCoverOutstanding.DataPropertyName = "CreditCoverOutstanding";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.colCreditCoverOutstanding.DefaultCellStyle = dataGridViewCellStyle11;
            this.colCreditCoverOutstanding.HeaderText = "ʣ�����÷��ն��";
            this.colCreditCoverOutstanding.Name = "colCreditCoverOutstanding";
            this.colCreditCoverOutstanding.ReadOnly = true;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle12;
            this.colFinanceOutstanding.HeaderText = "�������";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colTotalFinanceOutstanding
            // 
            this.colTotalFinanceOutstanding.DataPropertyName = "TotalFinanceOutstanding";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            this.colTotalFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTotalFinanceOutstanding.HeaderText = "���������";
            this.colTotalFinanceOutstanding.Name = "colTotalFinanceOutstanding";
            this.colTotalFinanceOutstanding.ReadOnly = true;
            // 
            // colFinanceLineOutstanding
            // 
            this.colFinanceLineOutstanding.DataPropertyName = "FinanceLineOutstanding";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.colFinanceLineOutstanding.DefaultCellStyle = dataGridViewCellStyle14;
            this.colFinanceLineOutstanding.HeaderText = "ʣ��������ʶ��";
            this.colFinanceLineOutstanding.Name = "colFinanceLineOutstanding";
            this.colFinanceLineOutstanding.ReadOnly = true;
            // 
            // colHighestFinanceLineAmount
            // 
            this.colHighestFinanceLineAmount.DataPropertyName = "HighestFinanceLineAmount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "N2";
            this.colHighestFinanceLineAmount.DefaultCellStyle = dataGridViewCellStyle15;
            this.colHighestFinanceLineAmount.HeaderText = "������ʶ��";
            this.colHighestFinanceLineAmount.Name = "colHighestFinanceLineAmount";
            this.colHighestFinanceLineAmount.ReadOnly = true;
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
