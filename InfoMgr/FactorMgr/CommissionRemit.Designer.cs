//-----------------------------------------------------------------------
// <copyright file="CommissionRemit.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommissionRemit
    {
		#region?Fields?(44)?

        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.ExpandablePanel panelFactorSelect;
        private DevComponents.DotNetBar.PanelEx panelInvoiceMgr;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            DevComponents.DotNetBar.LabelX lblFactorCode;
            DevComponents.DotNetBar.LabelX lblRemitCurrency;
            DevComponents.DotNetBar.LabelX lbcRemitAmount;
            DevComponents.DotNetBar.LabelX lblMsgCurrency;
            DevComponents.DotNetBar.LabelX lblMsgType;
            DevComponents.DotNetBar.LabelX lblCommmissionCreateUserName;
            DevComponents.DotNetBar.LabelX lblCommissionComment;
            DevComponents.DotNetBar.LabelX lblMsgDate;
            DevComponents.DotNetBar.LabelX lblRemitDate;
            DevComponents.DotNetBar.LabelX lblMsgAmount;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommissionRemit));
            DevComponents.DotNetBar.LabelX lblIFCommission;
            DevComponents.DotNetBar.LabelX lblTotalCommission;
            this.panelFactorSelect = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCompanyNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCompanyNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelInvoiceMgr = new DevComponents.DotNetBar.PanelEx();
            this.dgvBatches = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorCommissionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelCommissionRemit = new DevComponents.DotNetBar.PanelEx();
            this.btnCommissionRemitSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitSave = new DevComponents.DotNetBar.ButtonX();
            this.cbRemitCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.commissionRemitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRemitAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMsgCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbMsgType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCommissionCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCommissionComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diMsgDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diRemitDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbMsgAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commissionRemitValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.tbIFCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            lblFactorCode = new DevComponents.DotNetBar.LabelX();
            lblRemitCurrency = new DevComponents.DotNetBar.LabelX();
            lbcRemitAmount = new DevComponents.DotNetBar.LabelX();
            lblMsgCurrency = new DevComponents.DotNetBar.LabelX();
            lblMsgType = new DevComponents.DotNetBar.LabelX();
            lblCommmissionCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblCommissionComment = new DevComponents.DotNetBar.LabelX();
            lblMsgDate = new DevComponents.DotNetBar.LabelX();
            lblRemitDate = new DevComponents.DotNetBar.LabelX();
            lblMsgAmount = new DevComponents.DotNetBar.LabelX();
            lblIFCommission = new DevComponents.DotNetBar.LabelX();
            lblTotalCommission = new DevComponents.DotNetBar.LabelX();
            this.panelFactorSelect.SuspendLayout();
            this.panelInvoiceMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingNavigator)).BeginInit();
            this.batchBindingNavigator.SuspendLayout();
            this.panelCommissionRemit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFactorCode
            // 
            lblFactorCode.AutoSize = true;
            // 
            // 
            // 
            lblFactorCode.BackgroundStyle.Class = "";
            lblFactorCode.Location = new System.Drawing.Point(54, 2);
            lblFactorCode.Name = "lblFactorCode";
            lblFactorCode.Size = new System.Drawing.Size(44, 16);
            lblFactorCode.TabIndex = 65;
            lblFactorCode.Text = "保理商";
            // 
            // lblRemitCurrency
            // 
            lblRemitCurrency.AutoSize = true;
            lblRemitCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitCurrency.BackgroundStyle.Class = "";
            lblRemitCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblRemitCurrency.Location = new System.Drawing.Point(387, 31);
            lblRemitCurrency.Name = "lblRemitCurrency";
            lblRemitCurrency.Size = new System.Drawing.Size(59, 16);
            lblRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblRemitCurrency.TabIndex = 49;
            lblRemitCurrency.Text = "汇款币别:";
            // 
            // lbcRemitAmount
            // 
            lbcRemitAmount.AutoSize = true;
            lbcRemitAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lbcRemitAmount.BackgroundStyle.Class = "";
            lbcRemitAmount.Location = new System.Drawing.Point(543, 30);
            lbcRemitAmount.Name = "lbcRemitAmount";
            lbcRemitAmount.Size = new System.Drawing.Size(59, 16);
            lbcRemitAmount.TabIndex = 47;
            lbcRemitAmount.Text = "汇款金额:";
            // 
            // lblMsgCurrency
            // 
            lblMsgCurrency.AutoSize = true;
            lblMsgCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgCurrency.BackgroundStyle.Class = "";
            lblMsgCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgCurrency.Location = new System.Drawing.Point(387, 7);
            lblMsgCurrency.Name = "lblMsgCurrency";
            lblMsgCurrency.Size = new System.Drawing.Size(57, 15);
            lblMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblMsgCurrency.TabIndex = 45;
            lblMsgCurrency.Text = "<font color=\'red\'>*</font>消息币别:";
            // 
            // lblMsgType
            // 
            lblMsgType.AutoSize = true;
            lblMsgType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgType.BackgroundStyle.Class = "";
            lblMsgType.Location = new System.Drawing.Point(41, 7);
            lblMsgType.Name = "lblMsgType";
            lblMsgType.Size = new System.Drawing.Size(57, 15);
            lblMsgType.TabIndex = 33;
            lblMsgType.Text = "<font color=\'red\'>*</font>消息类型:";
            // 
            // lblCommmissionCreateUserName
            // 
            lblCommmissionCreateUserName.AutoSize = true;
            lblCommmissionCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommmissionCreateUserName.BackgroundStyle.Class = "";
            lblCommmissionCreateUserName.Location = new System.Drawing.Point(555, 54);
            lblCommmissionCreateUserName.Name = "lblCommmissionCreateUserName";
            lblCommmissionCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCommmissionCreateUserName.TabIndex = 43;
            lblCommmissionCreateUserName.Text = "经办人:";
            // 
            // lblCommissionComment
            // 
            lblCommissionComment.AutoSize = true;
            lblCommissionComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommissionComment.BackgroundStyle.Class = "";
            lblCommissionComment.Location = new System.Drawing.Point(66, 54);
            lblCommissionComment.Name = "lblCommissionComment";
            lblCommissionComment.Size = new System.Drawing.Size(34, 16);
            lblCommissionComment.TabIndex = 41;
            lblCommissionComment.Text = "备注:";
            // 
            // lblMsgDate
            // 
            lblMsgDate.AutoSize = true;
            lblMsgDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgDate.BackgroundStyle.Class = "";
            lblMsgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgDate.Location = new System.Drawing.Point(208, 7);
            lblMsgDate.Name = "lblMsgDate";
            lblMsgDate.Size = new System.Drawing.Size(57, 15);
            lblMsgDate.TabIndex = 35;
            lblMsgDate.Text = "<font color=\'red\'>*</font>消息日期:";
            // 
            // lblRemitDate
            // 
            lblRemitDate.AutoSize = true;
            lblRemitDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitDate.BackgroundStyle.Class = "";
            lblRemitDate.Location = new System.Drawing.Point(209, 30);
            lblRemitDate.Name = "lblRemitDate";
            lblRemitDate.Size = new System.Drawing.Size(59, 16);
            lblRemitDate.TabIndex = 39;
            lblRemitDate.Text = "汇款日期:";
            // 
            // lblMsgAmount
            // 
            lblMsgAmount.AutoSize = true;
            lblMsgAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgAmount.BackgroundStyle.Class = "";
            lblMsgAmount.Location = new System.Drawing.Point(541, 7);
            lblMsgAmount.Name = "lblMsgAmount";
            lblMsgAmount.Size = new System.Drawing.Size(57, 15);
            lblMsgAmount.TabIndex = 37;
            lblMsgAmount.Text = "<font color=\'red\'>*</font>消息金额:";
            // 
            // panelFactorSelect
            // 
            this.panelFactorSelect.AutoScroll = true;
            this.panelFactorSelect.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFactorSelect.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFactorSelect.Controls.Add(this.btnFactorSelect);
            this.panelFactorSelect.Controls.Add(this.tbFactorCode);
            this.panelFactorSelect.Controls.Add(lblFactorCode);
            this.panelFactorSelect.Controls.Add(this.tbCompanyNameCN);
            this.panelFactorSelect.Controls.Add(this.tbCompanyNameEN);
            this.panelFactorSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFactorSelect.ExpandOnTitleClick = true;
            this.panelFactorSelect.Location = new System.Drawing.Point(0, 0);
            this.panelFactorSelect.Margin = new System.Windows.Forms.Padding(0);
            this.panelFactorSelect.Name = "panelFactorSelect";
            this.panelFactorSelect.Size = new System.Drawing.Size(1254, 48);
            this.panelFactorSelect.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFactorSelect.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFactorSelect.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFactorSelect.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFactorSelect.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFactorSelect.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFactorSelect.Style.GradientAngle = 90;
            this.panelFactorSelect.TabIndex = 0;
            this.panelFactorSelect.TitleHeight = 15;
            this.panelFactorSelect.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFactorSelect.TitleText = "Title Bar";
            // 
            // btnFactorSelect
            // 
            this.btnFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSelect.Location = new System.Drawing.Point(13, 3);
            this.btnFactorSelect.Name = "btnFactorSelect";
            this.btnFactorSelect.Size = new System.Drawing.Size(32, 29);
            this.btnFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorSelect.TabIndex = 62;
            this.btnFactorSelect.Text = "...";
            this.btnFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // tbFactorCode
            // 
            // 
            // 
            // 
            this.tbFactorCode.Border.Class = "TextBoxBorder";
            this.tbFactorCode.Location = new System.Drawing.Point(102, 2);
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.ReadOnly = true;
            this.tbFactorCode.Size = new System.Drawing.Size(99, 20);
            this.tbFactorCode.TabIndex = 66;
            this.tbFactorCode.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // tbCompanyNameCN
            // 
            // 
            // 
            // 
            this.tbCompanyNameCN.Border.Class = "TextBoxBorder";
            this.tbCompanyNameCN.Location = new System.Drawing.Point(102, 23);
            this.tbCompanyNameCN.Name = "tbCompanyNameCN";
            this.tbCompanyNameCN.ReadOnly = true;
            this.tbCompanyNameCN.Size = new System.Drawing.Size(150, 20);
            this.tbCompanyNameCN.TabIndex = 67;
            this.tbCompanyNameCN.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // tbCompanyNameEN
            // 
            // 
            // 
            // 
            this.tbCompanyNameEN.Border.Class = "TextBoxBorder";
            this.tbCompanyNameEN.Location = new System.Drawing.Point(258, 23);
            this.tbCompanyNameEN.Name = "tbCompanyNameEN";
            this.tbCompanyNameEN.ReadOnly = true;
            this.tbCompanyNameEN.Size = new System.Drawing.Size(150, 20);
            this.tbCompanyNameEN.TabIndex = 70;
            this.tbCompanyNameEN.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // panelInvoiceMgr
            // 
            this.panelInvoiceMgr.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelInvoiceMgr.Controls.Add(this.dgvBatches);
            this.panelInvoiceMgr.Controls.Add(this.batchBindingNavigator);
            this.panelInvoiceMgr.Controls.Add(this.panelCommissionRemit);
            this.panelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceMgr.Location = new System.Drawing.Point(0, 48);
            this.panelInvoiceMgr.Name = "panelInvoiceMgr";
            this.panelInvoiceMgr.Size = new System.Drawing.Size(1254, 263);
            this.panelInvoiceMgr.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelInvoiceMgr.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelInvoiceMgr.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelInvoiceMgr.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelInvoiceMgr.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelInvoiceMgr.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelInvoiceMgr.Style.GradientAngle = 90;
            this.panelInvoiceMgr.TabIndex = 0;
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.AllowUserToDeleteRows = false;
            this.dgvBatches.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colSellerName,
            this.colBuyerName,
            this.colTransactionType,
            this.colAssignBatchNo,
            this.colBatchCount,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colAssignDate,
            this.colCommissionPrice,
            this.colFactorCommissionPrice,
            this.colCommissionAmount,
            this.colFactorCommissionAmount});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatches.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBatches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBatches.Location = new System.Drawing.Point(0, 141);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatches.Size = new System.Drawing.Size(1254, 122);
            this.dgvBatches.TabIndex = 5;
            this.dgvBatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBatchesCellContentClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            this.colCheckBox.Width = 20;
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.HeaderText = "卖方";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类型";
            this.colTransactionType.Name = "colTransactionType";
            // 
            // colAssignBatchNo
            // 
            this.colAssignBatchNo.DataPropertyName = "AssignBatchNo";
            this.colAssignBatchNo.HeaderText = "业务编号";
            this.colAssignBatchNo.Name = "colAssignBatchNo";
            this.colAssignBatchNo.ReadOnly = true;
            // 
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "发票笔数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
            // 
            // colCommissionPrice
            // 
            this.colCommissionPrice.DataPropertyName = "CommissionPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "p4";
            this.colCommissionPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCommissionPrice.HeaderText = "总手续费率";
            this.colCommissionPrice.Name = "colCommissionPrice";
            this.colCommissionPrice.ReadOnly = true;
            // 
            // colFactorCommissionPrice
            // 
            this.colFactorCommissionPrice.DataPropertyName = "FactorCommissionPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "p4";
            this.colFactorCommissionPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFactorCommissionPrice.HeaderText = "IF手续费率";
            this.colFactorCommissionPrice.Name = "colFactorCommissionPrice";
            this.colFactorCommissionPrice.ReadOnly = true;
            // 
            // colCommissionAmount
            // 
            this.colCommissionAmount.DataPropertyName = "CommissionAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.colCommissionAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCommissionAmount.HeaderText = "总手续费";
            this.colCommissionAmount.Name = "colCommissionAmount";
            this.colCommissionAmount.ReadOnly = true;
            // 
            // colFactorCommissionAmount
            // 
            this.colFactorCommissionAmount.DataPropertyName = "FactorCommissionAmount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.colFactorCommissionAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFactorCommissionAmount.HeaderText = "IF手续费";
            this.colFactorCommissionAmount.Name = "colFactorCommissionAmount";
            this.colFactorCommissionAmount.ReadOnly = true;
            // 
            // batchBindingNavigator
            // 
            this.batchBindingNavigator.AddNewItem = null;
            this.batchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.batchBindingNavigator.DeleteItem = null;
            this.batchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.batchBindingNavigator.Location = new System.Drawing.Point(0, 116);
            this.batchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.batchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.batchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.batchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.batchBindingNavigator.Name = "batchBindingNavigator";
            this.batchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.batchBindingNavigator.Size = new System.Drawing.Size(1254, 25);
            this.batchBindingNavigator.TabIndex = 4;
            this.batchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panelCommissionRemit
            // 
            this.panelCommissionRemit.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCommissionRemit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCommissionRemit.Controls.Add(this.tbIFCommission);
            this.panelCommissionRemit.Controls.Add(this.tbTotalCommission);
            this.panelCommissionRemit.Controls.Add(lblIFCommission);
            this.panelCommissionRemit.Controls.Add(lblTotalCommission);
            this.panelCommissionRemit.Controls.Add(this.btnCommissionRemitSelect);
            this.panelCommissionRemit.Controls.Add(this.btnCommissionRemitNew);
            this.panelCommissionRemit.Controls.Add(this.btnCommissionRemitSave);
            this.panelCommissionRemit.Controls.Add(this.cbRemitCurrency);
            this.panelCommissionRemit.Controls.Add(lblRemitCurrency);
            this.panelCommissionRemit.Controls.Add(lbcRemitAmount);
            this.panelCommissionRemit.Controls.Add(this.tbRemitAmount);
            this.panelCommissionRemit.Controls.Add(this.cbMsgCurrency);
            this.panelCommissionRemit.Controls.Add(lblMsgCurrency);
            this.panelCommissionRemit.Controls.Add(lblMsgType);
            this.panelCommissionRemit.Controls.Add(this.tbMsgType);
            this.panelCommissionRemit.Controls.Add(lblCommmissionCreateUserName);
            this.panelCommissionRemit.Controls.Add(this.tbCommissionCreateUserName);
            this.panelCommissionRemit.Controls.Add(lblCommissionComment);
            this.panelCommissionRemit.Controls.Add(this.tbCommissionComment);
            this.panelCommissionRemit.Controls.Add(lblMsgDate);
            this.panelCommissionRemit.Controls.Add(this.diMsgDate);
            this.panelCommissionRemit.Controls.Add(lblRemitDate);
            this.panelCommissionRemit.Controls.Add(this.diRemitDate);
            this.panelCommissionRemit.Controls.Add(lblMsgAmount);
            this.panelCommissionRemit.Controls.Add(this.tbMsgAmount);
            this.panelCommissionRemit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommissionRemit.Location = new System.Drawing.Point(0, 0);
            this.panelCommissionRemit.Name = "panelCommissionRemit";
            this.panelCommissionRemit.Size = new System.Drawing.Size(1254, 116);
            this.panelCommissionRemit.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCommissionRemit.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCommissionRemit.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCommissionRemit.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCommissionRemit.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCommissionRemit.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCommissionRemit.Style.GradientAngle = 90;
            this.panelCommissionRemit.TabIndex = 3;
            // 
            // btnCommissionRemitSelect
            // 
            this.btnCommissionRemitSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitSelect.Location = new System.Drawing.Point(860, 7);
            this.btnCommissionRemitSelect.Name = "btnCommissionRemitSelect";
            this.btnCommissionRemitSelect.Size = new System.Drawing.Size(61, 23);
            this.btnCommissionRemitSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitSelect.TabIndex = 53;
            this.btnCommissionRemitSelect.Text = "选择";
            this.btnCommissionRemitSelect.Click += new System.EventHandler(this.SelectCommissionRemit);
            // 
            // btnCommissionRemitNew
            // 
            this.btnCommissionRemitNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitNew.Location = new System.Drawing.Point(726, 7);
            this.btnCommissionRemitNew.Name = "btnCommissionRemitNew";
            this.btnCommissionRemitNew.Size = new System.Drawing.Size(61, 23);
            this.btnCommissionRemitNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitNew.TabIndex = 52;
            this.btnCommissionRemitNew.Text = "新建";
            this.btnCommissionRemitNew.Click += new System.EventHandler(this.NewCommissionRemit);
            // 
            // btnCommissionRemitSave
            // 
            this.btnCommissionRemitSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitSave.Location = new System.Drawing.Point(793, 7);
            this.btnCommissionRemitSave.Name = "btnCommissionRemitSave";
            this.btnCommissionRemitSave.Size = new System.Drawing.Size(61, 23);
            this.btnCommissionRemitSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitSave.TabIndex = 51;
            this.btnCommissionRemitSave.Text = "保存";
            this.btnCommissionRemitSave.Click += new System.EventHandler(this.SaveCommissionRemit);
            // 
            // cbRemitCurrency
            // 
            this.cbRemitCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRemitCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRemitCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "RemitCurrency", true));
            this.cbRemitCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRemitCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemitCurrency.ItemHeight = 14;
            this.cbRemitCurrency.Location = new System.Drawing.Point(450, 28);
            this.cbRemitCurrency.Name = "cbRemitCurrency";
            this.cbRemitCurrency.Size = new System.Drawing.Size(85, 20);
            this.cbRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRemitCurrency.TabIndex = 50;
            // 
            // commissionRemitBindingSource
            // 
            this.commissionRemitBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CommissionRemittance);
            // 
            // tbRemitAmount
            // 
            // 
            // 
            // 
            this.tbRemitAmount.Border.Class = "TextBoxBorder";
            this.tbRemitAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbRemitAmount.Location = new System.Drawing.Point(611, 28);
            this.tbRemitAmount.Name = "tbRemitAmount";
            this.tbRemitAmount.Size = new System.Drawing.Size(100, 20);
            this.tbRemitAmount.TabIndex = 48;
            // 
            // cbMsgCurrency
            // 
            this.cbMsgCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMsgCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMsgCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "MsgCurrency", true));
            this.cbMsgCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMsgCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMsgCurrency.ItemHeight = 14;
            this.cbMsgCurrency.Location = new System.Drawing.Point(450, 5);
            this.cbMsgCurrency.Name = "cbMsgCurrency";
            this.cbMsgCurrency.Size = new System.Drawing.Size(85, 20);
            this.cbMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMsgCurrency.TabIndex = 46;
            this.commissionRemitValidator.SetValidator1(this.cbMsgCurrency, this.requiredFieldValidator3);
            // 
            // tbMsgType
            // 
            // 
            // 
            // 
            this.tbMsgType.Border.Class = "TextBoxBorder";
            this.tbMsgType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgType", true));
            this.tbMsgType.Location = new System.Drawing.Point(102, 5);
            this.tbMsgType.Name = "tbMsgType";
            this.tbMsgType.Size = new System.Drawing.Size(100, 20);
            this.tbMsgType.TabIndex = 34;
            this.commissionRemitValidator.SetValidator1(this.tbMsgType, this.requiredFieldValidator1);
            // 
            // tbCommissionCreateUserName
            // 
            // 
            // 
            // 
            this.tbCommissionCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCommissionCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "CreateUserName", true));
            this.tbCommissionCreateUserName.Location = new System.Drawing.Point(611, 50);
            this.tbCommissionCreateUserName.Name = "tbCommissionCreateUserName";
            this.tbCommissionCreateUserName.ReadOnly = true;
            this.tbCommissionCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCommissionCreateUserName.TabIndex = 44;
            // 
            // tbCommissionComment
            // 
            // 
            // 
            // 
            this.tbCommissionComment.Border.Class = "";
            this.tbCommissionComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "Comment", true));
            this.tbCommissionComment.Location = new System.Drawing.Point(102, 53);
            this.tbCommissionComment.Multiline = true;
            this.tbCommissionComment.Name = "tbCommissionComment";
            this.tbCommissionComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCommissionComment.Size = new System.Drawing.Size(433, 57);
            this.tbCommissionComment.TabIndex = 42;
            // 
            // diMsgDate
            // 
            // 
            // 
            // 
            this.diMsgDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diMsgDate.ButtonDropDown.Visible = true;
            this.diMsgDate.ButtonFreeText.Checked = true;
            this.diMsgDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgDate", true));
            this.diMsgDate.FreeTextEntryMode = true;
            this.diMsgDate.Location = new System.Drawing.Point(269, 5);
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diMsgDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diMsgDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diMsgDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.TodayButtonVisible = true;
            this.diMsgDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diMsgDate.Name = "diMsgDate";
            this.diMsgDate.Size = new System.Drawing.Size(103, 20);
            this.diMsgDate.TabIndex = 36;
            this.commissionRemitValidator.SetValidator1(this.diMsgDate, this.requiredFieldValidator2);
            // 
            // diRemitDate
            // 
            // 
            // 
            // 
            this.diRemitDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRemitDate.ButtonDropDown.Visible = true;
            this.diRemitDate.ButtonFreeText.Checked = true;
            this.diRemitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitDate", true));
            this.diRemitDate.FreeTextEntryMode = true;
            this.diRemitDate.Location = new System.Drawing.Point(268, 28);
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diRemitDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diRemitDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diRemitDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.TodayButtonVisible = true;
            this.diRemitDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diRemitDate.Name = "diRemitDate";
            this.diRemitDate.Size = new System.Drawing.Size(103, 20);
            this.diRemitDate.TabIndex = 40;
            // 
            // tbMsgAmount
            // 
            // 
            // 
            // 
            this.tbMsgAmount.Border.Class = "TextBoxBorder";
            this.tbMsgAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbMsgAmount.Location = new System.Drawing.Point(611, 5);
            this.tbMsgAmount.Name = "tbMsgAmount";
            this.tbMsgAmount.Size = new System.Drawing.Size(100, 20);
            this.tbMsgAmount.TabIndex = 38;
            this.commissionRemitValidator.SetValidator1(this.tbMsgAmount, this.requiredFieldValidator4);
            // 
            // commissionRemitValidator
            // 
            this.commissionRemitValidator.ErrorProvider = this.errorProvider;
            this.commissionRemitValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // tbIFCommission
            // 
            // 
            // 
            // 
            this.tbIFCommission.Border.Class = "TextBoxBorder";
            this.tbIFCommission.Location = new System.Drawing.Point(1026, 29);
            this.tbIFCommission.Name = "tbIFCommission";
            this.tbIFCommission.ReadOnly = true;
            this.tbIFCommission.Size = new System.Drawing.Size(89, 20);
            this.tbIFCommission.TabIndex = 57;
            // 
            // tbTotalCommission
            // 
            // 
            // 
            // 
            this.tbTotalCommission.Border.Class = "TextBoxBorder";
            this.tbTotalCommission.Location = new System.Drawing.Point(1026, 6);
            this.tbTotalCommission.Name = "tbTotalCommission";
            this.tbTotalCommission.ReadOnly = true;
            this.tbTotalCommission.Size = new System.Drawing.Size(89, 20);
            this.tbTotalCommission.TabIndex = 56;
            // 
            // lblIFCommission
            // 
            lblIFCommission.AutoSize = true;
            // 
            // 
            // 
            lblIFCommission.BackgroundStyle.Class = "";
            lblIFCommission.Location = new System.Drawing.Point(941, 30);
            lblIFCommission.Name = "lblIFCommission";
            lblIFCommission.Size = new System.Drawing.Size(79, 16);
            lblIFCommission.TabIndex = 55;
            lblIFCommission.Text = "本次IF手续费";
            // 
            // lblTotalCommission
            // 
            lblTotalCommission.AutoSize = true;
            // 
            // 
            // 
            lblTotalCommission.BackgroundStyle.Class = "";
            lblTotalCommission.Location = new System.Drawing.Point(939, 8);
            lblTotalCommission.Name = "lblTotalCommission";
            lblTotalCommission.Size = new System.Drawing.Size(81, 16);
            lblTotalCommission.TabIndex = 54;
            lblTotalCommission.Text = "本次总手续费";
            // 
            // CommissionRemit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInvoiceMgr);
            this.Controls.Add(this.panelFactorSelect);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CommissionRemit";
            this.Size = new System.Drawing.Size(1254, 311);
            this.panelFactorSelect.ResumeLayout(false);
            this.panelFactorSelect.PerformLayout();
            this.panelInvoiceMgr.ResumeLayout(false);
            this.panelInvoiceMgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingNavigator)).EndInit();
            this.batchBindingNavigator.ResumeLayout(false);
            this.batchBindingNavigator.PerformLayout();
            this.panelCommissionRemit.ResumeLayout(false);
            this.panelCommissionRemit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.ButtonX btnFactorSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCompanyNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCompanyNameEN;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBatches;
        private System.Windows.Forms.BindingNavigator batchBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.PanelEx panelCommissionRemit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRemitCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRemitAmount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMsgCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionComment;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diMsgDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diRemitDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgAmount;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitSelect;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitNew;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitSave;
        private System.Windows.Forms.BindingSource commissionRemitBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator commissionRemitValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorCommissionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorCommissionAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIFCommission;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalCommission;
    }
}
