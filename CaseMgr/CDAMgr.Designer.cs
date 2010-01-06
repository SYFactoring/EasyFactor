namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDAMgr
    {
		#region Fields (59) 

        private DevComponents.DotNetBar.ButtonX btnCDAQuery;
        private System.Windows.Forms.ContextMenuStrip cmuCDAMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.LabelX lblBuyerName;
        private DevComponents.DotNetBar.LabelX lblContractCode;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblSellerName;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDANew;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDASelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAUpdate;
        private DevComponents.DotNetBar.PanelEx panelCDAQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyerName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSellerName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

		#endregion Fields 

		#region Methods (1) 

		// Protected Methods (1) 

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

		#endregion Methods 



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelCDAQuery = new DevComponents.DotNetBar.PanelEx();
            this.tbBuyerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbSellerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyerName = new DevComponents.DotNetBar.LabelX();
            this.lblSellerName = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnCDAQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContractCode = new DevComponents.DotNetBar.LabelX();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuCDAMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCDASelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDANew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDAUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADelete = new System.Windows.Forms.ToolStripMenuItem();
            this.colCDACode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecoarse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsCreditCoverRevolving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUGProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUGPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReassignGracePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceGracePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeductibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLossThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionTypeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFeeCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAValueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDADueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticePersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCDAQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.cmuCDAMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCDAQuery
            // 
            this.panelCDAQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCDAQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCDAQuery.Controls.Add(this.tbBuyerName);
            this.panelCDAQuery.Controls.Add(this.tbSellerName);
            this.panelCDAQuery.Controls.Add(this.lblBuyerName);
            this.panelCDAQuery.Controls.Add(this.lblSellerName);
            this.panelCDAQuery.Controls.Add(this.lblCount);
            this.panelCDAQuery.Controls.Add(this.btnCDAQuery);
            this.panelCDAQuery.Controls.Add(this.tbContractCode);
            this.panelCDAQuery.Controls.Add(this.lblContractCode);
            this.panelCDAQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCDAQuery.Location = new System.Drawing.Point(0, 0);
            this.panelCDAQuery.Name = "panelCDAQuery";
            this.panelCDAQuery.Size = new System.Drawing.Size(643, 54);
            this.panelCDAQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCDAQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCDAQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCDAQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCDAQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCDAQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCDAQuery.Style.GradientAngle = 90;
            this.panelCDAQuery.TabIndex = 0;
            // 
            // tbBuyerName
            // 
            // 
            // 
            // 
            this.tbBuyerName.Border.Class = "TextBoxBorder";
            this.tbBuyerName.Location = new System.Drawing.Point(229, 24);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.Size = new System.Drawing.Size(100, 20);
            this.tbBuyerName.TabIndex = 5;
            // 
            // tbSellerName
            // 
            // 
            // 
            // 
            this.tbSellerName.Border.Class = "TextBoxBorder";
            this.tbSellerName.Location = new System.Drawing.Point(86, 24);
            this.tbSellerName.Name = "tbSellerName";
            this.tbSellerName.Size = new System.Drawing.Size(100, 20);
            this.tbSellerName.TabIndex = 3;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            // 
            // 
            // 
            this.lblBuyerName.BackgroundStyle.Class = "";
            this.lblBuyerName.Location = new System.Drawing.Point(192, 25);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(31, 16);
            this.lblBuyerName.TabIndex = 4;
            this.lblBuyerName.Text = "买方";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            // 
            // 
            // 
            this.lblSellerName.BackgroundStyle.Class = "";
            this.lblSellerName.Location = new System.Drawing.Point(49, 28);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(31, 16);
            this.lblSellerName.TabIndex = 2;
            this.lblSellerName.Text = "卖方";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(419, 24);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 7;
            // 
            // btnCDAQuery
            // 
            this.btnCDAQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDAQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDAQuery.Location = new System.Drawing.Point(356, 3);
            this.btnCDAQuery.Name = "btnCDAQuery";
            this.btnCDAQuery.Size = new System.Drawing.Size(47, 45);
            this.btnCDAQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDAQuery.TabIndex = 6;
            this.btnCDAQuery.Text = "查询";
            this.btnCDAQuery.Click += new System.EventHandler(this.QueryCDAs);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.Location = new System.Drawing.Point(86, 3);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 20);
            this.tbContractCode.TabIndex = 1;
            // 
            // lblContractCode
            // 
            this.lblContractCode.AutoSize = true;
            // 
            // 
            // 
            this.lblContractCode.BackgroundStyle.Class = "";
            this.lblContractCode.Location = new System.Drawing.Point(3, 3);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(81, 16);
            this.lblContractCode.TabIndex = 0;
            this.lblContractCode.Text = "保理合同编号";
            // 
            // dgvCDAs
            // 
            this.dgvCDAs.AllowUserToAddRows = false;
            this.dgvCDAs.AllowUserToDeleteRows = false;
            this.dgvCDAs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDAs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDACode,
            this.colCaseCode,
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colTransactionType,
            this.colInvoiceCurrency,
            this.colIsRecoarse,
            this.colIsNotice,
            this.colAssignType,
            this.colCreditCoverCurr,
            this.colCreditCover,
            this.colIsCreditCoverRevolving,
            this.colApproveNumber,
            this.colPUGProportion,
            this.colCreditCoverPeriodBegin,
            this.colCreditCoverPeriodEnd,
            this.colPUGPeriod,
            this.colReassignGracePeriod,
            this.colFinanceLineCurr,
            this.colFinanceLine,
            this.colFinanceLinePeriodBegin,
            this.colFinanceLinePeriodEnd,
            this.colFinanceProportion,
            this.colOrderNumber,
            this.colPaymentTerms,
            this.colFinanceGracePeriod,
            this.colDeductibles,
            this.colLossThreshold,
            this.colPrice,
            this.colEFPrice,
            this.colIFPrice,
            this.colCommissionType,
            this.colCommissionTypeComment,
            this.colHandFeeCurr,
            this.colHandFee,
            this.colCDAValueDate,
            this.colCDADueDate,
            this.colCDAStatus,
            this.colNoticeMethod,
            this.colNoticePersion,
            this.colEmail,
            this.colFax,
            this.colComment,
            this.colCreateUserName});
            this.dgvCDAs.ContextMenuStrip = this.cmuCDAMgr;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(0, 54);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(643, 348);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCDAs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCDAs_CellFormatting);
            // 
            // cmuCDAMgr
            // 
            this.cmuCDAMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCDASelect,
            this.menuItemCDADetail,
            this.toolStripSeparator,
            this.menuItemCDANew,
            this.menuItemCDAUpdate,
            this.menuItemCDADelete});
            this.cmuCDAMgr.Name = "cmuContractMgr";
            this.cmuCDAMgr.Size = new System.Drawing.Size(123, 120);
            // 
            // menuItemCDASelect
            // 
            this.menuItemCDASelect.Name = "menuItemCDASelect";
            this.menuItemCDASelect.Size = new System.Drawing.Size(122, 22);
            this.menuItemCDASelect.Text = "选定CDA";
            this.menuItemCDASelect.Click += new System.EventHandler(this.SelectCDA);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(122, 22);
            this.menuItemCDADetail.Text = "详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemCDANew
            // 
            this.menuItemCDANew.Name = "menuItemCDANew";
            this.menuItemCDANew.Size = new System.Drawing.Size(122, 22);
            this.menuItemCDANew.Text = "新建CDA";
            this.menuItemCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // menuItemCDAUpdate
            // 
            this.menuItemCDAUpdate.Name = "menuItemCDAUpdate";
            this.menuItemCDAUpdate.Size = new System.Drawing.Size(122, 22);
            this.menuItemCDAUpdate.Text = "更新CDA";
            this.menuItemCDAUpdate.Click += new System.EventHandler(this.UpdateCDA);
            // 
            // menuItemCDADelete
            // 
            this.menuItemCDADelete.Name = "menuItemCDADelete";
            this.menuItemCDADelete.Size = new System.Drawing.Size(122, 22);
            this.menuItemCDADelete.Text = "删除CDA";
            this.menuItemCDADelete.Click += new System.EventHandler(this.DeleteCDA);
            // 
            // colCDACode
            // 
            this.colCDACode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCDACode.DataPropertyName = "CDACode";
            this.colCDACode.HeaderText = "CDA编号";
            this.colCDACode.Name = "colCDACode";
            this.colCDACode.ReadOnly = true;
            this.colCDACode.Width = 78;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.HeaderText = "卖方名称";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方名称";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            // 
            // colFactorName
            // 
            this.colFactorName.DataPropertyName = "FactorName";
            this.colFactorName.HeaderText = "保理商";
            this.colFactorName.Name = "colFactorName";
            this.colFactorName.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            // 
            // colIsRecoarse
            // 
            this.colIsRecoarse.DataPropertyName = "IsRecoarse";
            this.colIsRecoarse.HeaderText = "是否有追索权";
            this.colIsRecoarse.Name = "colIsRecoarse";
            this.colIsRecoarse.ReadOnly = true;
            this.colIsRecoarse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsRecoarse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIsNotice
            // 
            this.colIsNotice.DataPropertyName = "IsNotice";
            this.colIsNotice.HeaderText = "明/暗保理";
            this.colIsNotice.Name = "colIsNotice";
            this.colIsNotice.ReadOnly = true;
            this.colIsNotice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsNotice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAssignType
            // 
            this.colAssignType.DataPropertyName = "AssignType";
            this.colAssignType.HeaderText = "转让方式";
            this.colAssignType.Name = "colAssignType";
            this.colAssignType.ReadOnly = true;
            // 
            // colCreditCoverCurr
            // 
            this.colCreditCoverCurr.DataPropertyName = "CreditCoverCurr";
            this.colCreditCoverCurr.HeaderText = "买方风险额度币别";
            this.colCreditCoverCurr.Name = "colCreditCoverCurr";
            this.colCreditCoverCurr.ReadOnly = true;
            // 
            // colCreditCover
            // 
            this.colCreditCover.DataPropertyName = "CreditCover";
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.colCreditCover.DefaultCellStyle = dataGridViewCellStyle16;
            this.colCreditCover.HeaderText = "买方信用风险额度";
            this.colCreditCover.Name = "colCreditCover";
            this.colCreditCover.ReadOnly = true;
            // 
            // colIsCreditCoverRevolving
            // 
            this.colIsCreditCoverRevolving.DataPropertyName = "IsCreditCoverRevolving";
            this.colIsCreditCoverRevolving.HeaderText = "是否可循环";
            this.colIsCreditCoverRevolving.Name = "colIsCreditCoverRevolving";
            this.colIsCreditCoverRevolving.ReadOnly = true;
            this.colIsCreditCoverRevolving.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsCreditCoverRevolving.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colApproveNumber
            // 
            this.colApproveNumber.DataPropertyName = "ApproveNumber";
            this.colApproveNumber.HeaderText = "核准编号";
            this.colApproveNumber.Name = "colApproveNumber";
            this.colApproveNumber.ReadOnly = true;
            this.colApproveNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApproveNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPUGProportion
            // 
            this.colPUGProportion.DataPropertyName = "PUGProportion";
            dataGridViewCellStyle33.Format = "p";
            dataGridViewCellStyle33.NullValue = null;
            this.colPUGProportion.DefaultCellStyle = dataGridViewCellStyle33;
            this.colPUGProportion.HeaderText = "买方信用风险担保比例";
            this.colPUGProportion.Name = "colPUGProportion";
            this.colPUGProportion.ReadOnly = true;
            this.colPUGProportion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPUGProportion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreditCoverPeriodBegin
            // 
            this.colCreditCoverPeriodBegin.DataPropertyName = "CreditCoverPeriodBegin";
            dataGridViewCellStyle34.Format = "d";
            this.colCreditCoverPeriodBegin.DefaultCellStyle = dataGridViewCellStyle34;
            this.colCreditCoverPeriodBegin.HeaderText = "买方信用风险额度有效期限(始)";
            this.colCreditCoverPeriodBegin.Name = "colCreditCoverPeriodBegin";
            this.colCreditCoverPeriodBegin.ReadOnly = true;
            this.colCreditCoverPeriodBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreditCoverPeriodEnd
            // 
            this.colCreditCoverPeriodEnd.DataPropertyName = "CreditCoverPeriodEnd";
            dataGridViewCellStyle35.Format = "d";
            this.colCreditCoverPeriodEnd.DefaultCellStyle = dataGridViewCellStyle35;
            this.colCreditCoverPeriodEnd.HeaderText = "买方信用风险额度有效期限(终)";
            this.colCreditCoverPeriodEnd.Name = "colCreditCoverPeriodEnd";
            this.colCreditCoverPeriodEnd.ReadOnly = true;
            this.colCreditCoverPeriodEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPUGPeriod
            // 
            this.colPUGPeriod.DataPropertyName = "PUGPeriod";
            this.colPUGPeriod.HeaderText = "担保付款期限(天)";
            this.colPUGPeriod.Name = "colPUGPeriod";
            this.colPUGPeriod.ReadOnly = true;
            this.colPUGPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPUGPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colReassignGracePeriod
            // 
            this.colReassignGracePeriod.DataPropertyName = "ReassignGracePeriod";
            this.colReassignGracePeriod.HeaderText = "回购宽限期";
            this.colReassignGracePeriod.Name = "colReassignGracePeriod";
            this.colReassignGracePeriod.ReadOnly = true;
            this.colReassignGracePeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReassignGracePeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLineCurr
            // 
            this.colFinanceLineCurr.DataPropertyName = "FinanceLineCurr";
            this.colFinanceLineCurr.HeaderText = "预付款额度币别";
            this.colFinanceLineCurr.Name = "colFinanceLineCurr";
            this.colFinanceLineCurr.ReadOnly = true;
            this.colFinanceLineCurr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLineCurr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLine
            // 
            this.colFinanceLine.DataPropertyName = "FinanceLine";
            dataGridViewCellStyle36.Format = "N2";
            this.colFinanceLine.DefaultCellStyle = dataGridViewCellStyle36;
            this.colFinanceLine.HeaderText = "预付款额度";
            this.colFinanceLine.Name = "colFinanceLine";
            this.colFinanceLine.ReadOnly = true;
            this.colFinanceLine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLinePeriodBegin
            // 
            this.colFinanceLinePeriodBegin.DataPropertyName = "FinanceLinePeriodBegin";
            dataGridViewCellStyle37.Format = "d";
            this.colFinanceLinePeriodBegin.DefaultCellStyle = dataGridViewCellStyle37;
            this.colFinanceLinePeriodBegin.HeaderText = "预付款额度有效期限(始)";
            this.colFinanceLinePeriodBegin.Name = "colFinanceLinePeriodBegin";
            this.colFinanceLinePeriodBegin.ReadOnly = true;
            // 
            // colFinanceLinePeriodEnd
            // 
            this.colFinanceLinePeriodEnd.DataPropertyName = "FinanceLinePeriodEnd";
            dataGridViewCellStyle38.Format = "d";
            this.colFinanceLinePeriodEnd.DefaultCellStyle = dataGridViewCellStyle38;
            this.colFinanceLinePeriodEnd.HeaderText = "预付款额度有效期限(终)";
            this.colFinanceLinePeriodEnd.Name = "colFinanceLinePeriodEnd";
            this.colFinanceLinePeriodEnd.ReadOnly = true;
            // 
            // colFinanceProportion
            // 
            this.colFinanceProportion.DataPropertyName = "FinanceProportion";
            dataGridViewCellStyle39.Format = "p";
            this.colFinanceProportion.DefaultCellStyle = dataGridViewCellStyle39;
            this.colFinanceProportion.HeaderText = "预付比例";
            this.colFinanceProportion.Name = "colFinanceProportion";
            this.colFinanceProportion.ReadOnly = true;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DataPropertyName = "OrderNumber";
            this.colOrderNumber.HeaderText = "订单号";
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.ReadOnly = true;
            // 
            // colPaymentTerms
            // 
            this.colPaymentTerms.DataPropertyName = "PaymentTerms";
            this.colPaymentTerms.HeaderText = "付款条件";
            this.colPaymentTerms.Name = "colPaymentTerms";
            this.colPaymentTerms.ReadOnly = true;
            // 
            // colFinanceGracePeriod
            // 
            this.colFinanceGracePeriod.DataPropertyName = "FinanceGracePeriod";
            this.colFinanceGracePeriod.HeaderText = "融资宽限期";
            this.colFinanceGracePeriod.Name = "colFinanceGracePeriod";
            this.colFinanceGracePeriod.ReadOnly = true;
            // 
            // colDeductibles
            // 
            this.colDeductibles.DataPropertyName = "Deductibles";
            this.colDeductibles.HeaderText = "自负额";
            this.colDeductibles.Name = "colDeductibles";
            this.colDeductibles.ReadOnly = true;
            // 
            // colLossThreshold
            // 
            this.colLossThreshold.DataPropertyName = "LossThreshold";
            this.colLossThreshold.HeaderText = "最低损失门槛";
            this.colLossThreshold.Name = "colLossThreshold";
            this.colLossThreshold.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle40.Format = "p";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle40;
            this.colPrice.HeaderText = "总手续费率";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colEFPrice
            // 
            this.colEFPrice.DataPropertyName = "EFPrice";
            dataGridViewCellStyle41.Format = "p";
            this.colEFPrice.DefaultCellStyle = dataGridViewCellStyle41;
            this.colEFPrice.HeaderText = "卖方保理商手续费率";
            this.colEFPrice.Name = "colEFPrice";
            this.colEFPrice.ReadOnly = true;
            // 
            // colIFPrice
            // 
            this.colIFPrice.DataPropertyName = "IFPrice";
            dataGridViewCellStyle42.Format = "p";
            this.colIFPrice.DefaultCellStyle = dataGridViewCellStyle42;
            this.colIFPrice.HeaderText = "买方保理商手续费率";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            // 
            // colCommissionType
            // 
            this.colCommissionType.DataPropertyName = "CommissionType";
            this.colCommissionType.HeaderText = "计费方式";
            this.colCommissionType.Name = "colCommissionType";
            this.colCommissionType.ReadOnly = true;
            // 
            // colCommissionTypeComment
            // 
            this.colCommissionTypeComment.DataPropertyName = "CommissionTypeComment";
            this.colCommissionTypeComment.HeaderText = "计费说明";
            this.colCommissionTypeComment.Name = "colCommissionTypeComment";
            this.colCommissionTypeComment.ReadOnly = true;
            // 
            // colHandFeeCurr
            // 
            this.colHandFeeCurr.DataPropertyName = "HandFeeCurr";
            this.colHandFeeCurr.HeaderText = "单据处理费币别";
            this.colHandFeeCurr.Name = "colHandFeeCurr";
            this.colHandFeeCurr.ReadOnly = true;
            // 
            // colHandFee
            // 
            this.colHandFee.DataPropertyName = "HandFee";
            dataGridViewCellStyle43.Format = "N2";
            this.colHandFee.DefaultCellStyle = dataGridViewCellStyle43;
            this.colHandFee.HeaderText = "单据处理费(每张)";
            this.colHandFee.Name = "colHandFee";
            this.colHandFee.ReadOnly = true;
            // 
            // colCDAValueDate
            // 
            this.colCDAValueDate.DataPropertyName = "CDAValueDate";
            dataGridViewCellStyle44.Format = "d";
            this.colCDAValueDate.DefaultCellStyle = dataGridViewCellStyle44;
            this.colCDAValueDate.HeaderText = "合同生效日";
            this.colCDAValueDate.Name = "colCDAValueDate";
            this.colCDAValueDate.ReadOnly = true;
            // 
            // colCDADueDate
            // 
            this.colCDADueDate.DataPropertyName = "CDADueDate";
            dataGridViewCellStyle45.Format = "d";
            this.colCDADueDate.DefaultCellStyle = dataGridViewCellStyle45;
            this.colCDADueDate.HeaderText = "合同到期日";
            this.colCDADueDate.Name = "colCDADueDate";
            this.colCDADueDate.ReadOnly = true;
            // 
            // colCDAStatus
            // 
            this.colCDAStatus.DataPropertyName = "CDAStatus";
            this.colCDAStatus.HeaderText = "合同状态";
            this.colCDAStatus.Name = "colCDAStatus";
            this.colCDAStatus.ReadOnly = true;
            // 
            // colNoticeMethod
            // 
            this.colNoticeMethod.DataPropertyName = "NoticeMethod";
            this.colNoticeMethod.HeaderText = "通知方式";
            this.colNoticeMethod.Name = "colNoticeMethod";
            this.colNoticeMethod.ReadOnly = true;
            // 
            // colNoticePersion
            // 
            this.colNoticePersion.DataPropertyName = "NoticePerson";
            this.colNoticePersion.HeaderText = "通知人";
            this.colNoticePersion.Name = "colNoticePersion";
            this.colNoticePersion.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email地址";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colFax
            // 
            this.colFax.DataPropertyName = "Fax";
            this.colFax.HeaderText = "传真号码";
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // CDAMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCDAs);
            this.Controls.Add(this.panelCDAQuery);
            this.Name = "CDAMgr";
            this.Size = new System.Drawing.Size(643, 402);
            this.panelCDAQuery.ResumeLayout(false);
            this.panelCDAQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.cmuCDAMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsCreditCoverRevolving;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReassignGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionTypeComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFeeCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDADueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticePersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;




    }
}
