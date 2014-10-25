namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceRefund
    {
		#region?Fields?(45)?

        private System.Windows.Forms.BindingSource batchBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchExport;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchImport;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchNew;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchSave;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchSelect;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRefundType;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceRefund;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLogs;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private DevComponents.DotNetBar.LabelX lblTotalRefund;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelRefundBatch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput paymentDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX refundBatchNoTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalRefund;

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

            if (this._context != null)
            {
                this._context.Dispose();
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
            DevComponents.DotNetBar.LabelX refundBatchNoLabel;
            DevComponents.DotNetBar.LabelX refundDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX lblRefundType;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRefund));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRefundBatch = new DevComponents.DotNetBar.PanelEx();
            this.tbTotalInterest = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTotalInterest = new DevComponents.DotNetBar.LabelX();
            this.btnPaymentBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnPaymentBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnPaymentBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.lblTotalRefund = new DevComponents.DotNetBar.LabelX();
            this.tbTotalRefund = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPaymentBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.cbRefundType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPaymentBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.refundBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFinanceBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReassginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRateType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectPaymentOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenaltyInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceRefund = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            refundBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            refundDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblRefundType = new DevComponents.DotNetBar.LabelX();
            this.panelRefundBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.cmuInvoiceRefund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // refundBatchNoLabel
            // 
            refundBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            refundBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            refundBatchNoLabel.Location = new System.Drawing.Point(25, 6);
            refundBatchNoLabel.Name = "refundBatchNoLabel";
            refundBatchNoLabel.Size = new System.Drawing.Size(56, 18);
            refundBatchNoLabel.TabIndex = 0;
            refundBatchNoLabel.Text = "还款批号";
            // 
            // refundDateLabel
            // 
            refundDateLabel.AutoSize = true;
            // 
            // 
            // 
            refundDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            refundDateLabel.Location = new System.Drawing.Point(206, 6);
            refundDateLabel.Name = "refundDateLabel";
            refundDateLabel.Size = new System.Drawing.Size(50, 18);
            refundDateLabel.TabIndex = 2;
            refundDateLabel.Text = "还款日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            commentLabel.Location = new System.Drawing.Point(169, 51);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(31, 18);
            commentLabel.TabIndex = 9;
            commentLabel.Text = "备注";
            // 
            // lblRefundType
            // 
            lblRefundType.AutoSize = true;
            // 
            // 
            // 
            lblRefundType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblRefundType.Location = new System.Drawing.Point(25, 29);
            lblRefundType.Name = "lblRefundType";
            lblRefundType.Size = new System.Drawing.Size(56, 18);
            lblRefundType.TabIndex = 4;
            lblRefundType.Text = "还款类型";
            // 
            // panelRefundBatch
            // 
            this.panelRefundBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelRefundBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelRefundBatch.Controls.Add(this.tbTotalInterest);
            this.panelRefundBatch.Controls.Add(this.lblTotalInterest);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchImport);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchExport);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchSelect);
            this.panelRefundBatch.Controls.Add(this.lblTotalRefund);
            this.panelRefundBatch.Controls.Add(this.tbTotalRefund);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchNew);
            this.panelRefundBatch.Controls.Add(this.cbRefundType);
            this.panelRefundBatch.Controls.Add(lblRefundType);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchSave);
            this.panelRefundBatch.Controls.Add(commentLabel);
            this.panelRefundBatch.Controls.Add(this.commentTextBox);
            this.panelRefundBatch.Controls.Add(refundDateLabel);
            this.panelRefundBatch.Controls.Add(this.paymentDateDateTimePicker);
            this.panelRefundBatch.Controls.Add(refundBatchNoLabel);
            this.panelRefundBatch.Controls.Add(this.refundBatchNoTextBox);
            this.panelRefundBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelRefundBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRefundBatch.Location = new System.Drawing.Point(0, 0);
            this.panelRefundBatch.Name = "panelRefundBatch";
            this.panelRefundBatch.Size = new System.Drawing.Size(1069, 75);
            this.panelRefundBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelRefundBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelRefundBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelRefundBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelRefundBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelRefundBatch.Style.GradientAngle = 90;
            this.panelRefundBatch.TabIndex = 0;
            // 
            // tbTotalInterest
            // 
            this.tbTotalInterest.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTotalInterest.Border.Class = "TextBoxBorder";
            this.tbTotalInterest.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalInterest.DisabledBackColor = System.Drawing.Color.White;
            this.tbTotalInterest.ForeColor = System.Drawing.Color.Black;
            this.tbTotalInterest.Location = new System.Drawing.Point(879, 48);
            this.tbTotalInterest.Name = "tbTotalInterest";
            this.tbTotalInterest.ReadOnly = true;
            this.tbTotalInterest.Size = new System.Drawing.Size(100, 21);
            this.tbTotalInterest.TabIndex = 19;
            this.tbTotalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            // 
            // 
            // 
            this.lblTotalInterest.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalInterest.Location = new System.Drawing.Point(791, 48);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(81, 18);
            this.lblTotalInterest.TabIndex = 18;
            this.lblTotalInterest.Text = "本次利息收入";
            // 
            // btnPaymentBatchImport
            // 
            this.btnPaymentBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchImport.Location = new System.Drawing.Point(586, 32);
            this.btnPaymentBatchImport.Name = "btnPaymentBatchImport";
            this.btnPaymentBatchImport.Size = new System.Drawing.Size(61, 21);
            this.btnPaymentBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPaymentBatchImport.TabIndex = 17;
            this.btnPaymentBatchImport.Text = "导入批次";
            this.btnPaymentBatchImport.Click += new System.EventHandler(this.ImportBatch);
            // 
            // btnPaymentBatchExport
            // 
            this.btnPaymentBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchExport.Location = new System.Drawing.Point(519, 32);
            this.btnPaymentBatchExport.Name = "btnPaymentBatchExport";
            this.btnPaymentBatchExport.Size = new System.Drawing.Size(61, 21);
            this.btnPaymentBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPaymentBatchExport.TabIndex = 16;
            this.btnPaymentBatchExport.Text = "导出批次";
            this.btnPaymentBatchExport.Click += new System.EventHandler(this.ExportBatch);
            // 
            // btnPaymentBatchSelect
            // 
            this.btnPaymentBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchSelect.Enabled = false;
            this.btnPaymentBatchSelect.Location = new System.Drawing.Point(653, 6);
            this.btnPaymentBatchSelect.Name = "btnPaymentBatchSelect";
            this.btnPaymentBatchSelect.Size = new System.Drawing.Size(61, 21);
            this.btnPaymentBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPaymentBatchSelect.TabIndex = 15;
            this.btnPaymentBatchSelect.Text = "选择批次";
            this.btnPaymentBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // lblTotalRefund
            // 
            this.lblTotalRefund.AutoSize = true;
            // 
            // 
            // 
            this.lblTotalRefund.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalRefund.Location = new System.Drawing.Point(791, 27);
            this.lblTotalRefund.Name = "lblTotalRefund";
            this.lblTotalRefund.Size = new System.Drawing.Size(81, 18);
            this.lblTotalRefund.TabIndex = 13;
            this.lblTotalRefund.Text = "本次还本金额";
            // 
            // tbTotalRefund
            // 
            this.tbTotalRefund.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTotalRefund.Border.Class = "TextBoxBorder";
            this.tbTotalRefund.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalRefund.DisabledBackColor = System.Drawing.Color.White;
            this.tbTotalRefund.ForeColor = System.Drawing.Color.Black;
            this.tbTotalRefund.Location = new System.Drawing.Point(879, 26);
            this.tbTotalRefund.Name = "tbTotalRefund";
            this.tbTotalRefund.ReadOnly = true;
            this.tbTotalRefund.Size = new System.Drawing.Size(100, 21);
            this.tbTotalRefund.TabIndex = 14;
            this.tbTotalRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPaymentBatchNew
            // 
            this.btnPaymentBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchNew.Location = new System.Drawing.Point(519, 6);
            this.btnPaymentBatchNew.Name = "btnPaymentBatchNew";
            this.btnPaymentBatchNew.Size = new System.Drawing.Size(61, 21);
            this.btnPaymentBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPaymentBatchNew.TabIndex = 12;
            this.btnPaymentBatchNew.Text = "新建批次";
            this.btnPaymentBatchNew.Click += new System.EventHandler(this.NewBatch);
            // 
            // cbRefundType
            // 
            this.cbRefundType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RefundType", true));
            this.cbRefundType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRefundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRefundType.FormattingEnabled = true;
            this.cbRefundType.ItemHeight = 15;
            this.cbRefundType.Items.AddRange(new object[] {
            "买方直接付款",
            "卖方还款"});
            this.cbRefundType.Location = new System.Drawing.Point(90, 27);
            this.cbRefundType.Name = "cbRefundType";
            this.cbRefundType.Size = new System.Drawing.Size(100, 21);
            this.cbRefundType.TabIndex = 5;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceRefundBatch);
            // 
            // btnPaymentBatchSave
            // 
            this.btnPaymentBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchSave.Location = new System.Drawing.Point(586, 6);
            this.btnPaymentBatchSave.Name = "btnPaymentBatchSave";
            this.btnPaymentBatchSave.Size = new System.Drawing.Size(61, 21);
            this.btnPaymentBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPaymentBatchSave.TabIndex = 11;
            this.btnPaymentBatchSave.Text = "保存批次";
            this.btnPaymentBatchSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.commentTextBox.ForeColor = System.Drawing.Color.Black;
            this.commentTextBox.Location = new System.Drawing.Point(206, 26);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(307, 40);
            this.commentTextBox.TabIndex = 10;
            // 
            // paymentDateDateTimePicker
            // 
            // 
            // 
            // 
            this.paymentDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paymentDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.ButtonDropDown.Visible = true;
            this.paymentDateDateTimePicker.ButtonFreeText.Checked = true;
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "RefundDate", true));
            this.paymentDateDateTimePicker.Enabled = false;
            this.paymentDateDateTimePicker.FreeTextEntryMode = true;
            this.paymentDateDateTimePicker.IsPopupCalendarOpen = false;
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(259, 4);
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.paymentDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.paymentDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.paymentDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(120, 21);
            this.paymentDateDateTimePicker.TabIndex = 3;
            // 
            // refundBatchNoTextBox
            // 
            this.refundBatchNoTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.refundBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.refundBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RefundBatchNo", true));
            this.refundBatchNoTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.refundBatchNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.refundBatchNoTextBox.Location = new System.Drawing.Point(90, 3);
            this.refundBatchNoTextBox.Name = "refundBatchNoTextBox";
            this.refundBatchNoTextBox.ReadOnly = true;
            this.refundBatchNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.refundBatchNoTextBox.TabIndex = 1;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = null;
            this.invoiceBindingNavigator.BindingSource = this.logsBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = null;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 75);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1069, 25);
            this.invoiceBindingNavigator.TabIndex = 1;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
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
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colFinanceBatchNo,
            this.colInvoiceNo,
            this.colRefundCurrency,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colFinanceDate,
            this.colReassginDate,
            this.colFinanceRate,
            this.colFinanceRateType1,
            this.colDirectPaymentOutstanding,
            this.colInvoiceRefundAmount,
            this.colRefundAmount,
            this.colInterest,
            this.colPenaltyInterest,
            this.colComment});
            this.dgvLogs.ContextMenuStrip = this.cmuInvoiceRefund;
            this.dgvLogs.DataSource = this.logsBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLogs.Location = new System.Drawing.Point(0, 100);
            this.dgvLogs.Name = "dgvLogs";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1069, 386);
            this.dgvLogs.TabIndex = 2;
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellContentClick);
            this.dgvLogs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvInvoicesCellFormatting);
            this.dgvLogs.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DgvInvoicesCellParsing);
            this.dgvLogs.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvInvoicesCellValidating);
            this.dgvLogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellValueChanged);
            this.dgvLogs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInvoicesRowHeaderMouseDoubleClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Width = 20;
            // 
            // colFinanceBatchNo
            // 
            this.colFinanceBatchNo.DataPropertyName = "FinanceBatchNo";
            this.colFinanceBatchNo.HeaderText = "融资批号";
            this.colFinanceBatchNo.Name = "colFinanceBatchNo";
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo2";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            // 
            // colRefundCurrency
            // 
            this.colRefundCurrency.DataPropertyName = "RefundCurrency";
            this.colRefundCurrency.HeaderText = "币别";
            this.colRefundCurrency.Name = "colRefundCurrency";
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            // 
            // colReassginDate
            // 
            this.colReassginDate.DataPropertyName = "ReassignDate";
            this.colReassginDate.HeaderText = "预计回购日";
            this.colReassginDate.Name = "colReassginDate";
            // 
            // colFinanceRate
            // 
            this.colFinanceRate.DataPropertyName = "FinanceRate";
            dataGridViewCellStyle4.Format = "p2";
            this.colFinanceRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinanceRate.HeaderText = "融资利息";
            this.colFinanceRate.Name = "colFinanceRate";
            // 
            // colFinanceRateType1
            // 
            this.colFinanceRateType1.DataPropertyName = "FinanceRateType1";
            this.colFinanceRateType1.HeaderText = "收息方式";
            this.colFinanceRateType1.Name = "colFinanceRateType1";
            // 
            // colDirectPaymentOutstanding
            // 
            this.colDirectPaymentOutstanding.DataPropertyName = "DirectPaymentOutstanding";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colDirectPaymentOutstanding.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDirectPaymentOutstanding.HeaderText = "直接付款余额";
            this.colDirectPaymentOutstanding.Name = "colDirectPaymentOutstanding";
            // 
            // colInvoiceRefundAmount
            // 
            this.colInvoiceRefundAmount.DataPropertyName = "InvoiceRefundAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colInvoiceRefundAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInvoiceRefundAmount.HeaderText = "已还款金额";
            this.colInvoiceRefundAmount.Name = "colInvoiceRefundAmount";
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colRefundAmount.HeaderText = "本次还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle8;
            this.colInterest.HeaderText = "本次利息";
            this.colInterest.Name = "colInterest";
            // 
            // colPenaltyInterest
            // 
            this.colPenaltyInterest.DataPropertyName = "PenaltyInterest";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.colPenaltyInterest.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPenaltyInterest.HeaderText = "本次罚息";
            this.colPenaltyInterest.Name = "colPenaltyInterest";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            // 
            // cmuInvoiceRefund
            // 
            this.cmuInvoiceRefund.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail});
            this.cmuInvoiceRefund.Name = "cmuInvoiceFinance";
            this.cmuInvoiceRefund.Size = new System.Drawing.Size(185, 70);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDADetail.Text = "额度通知书详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemCaseDetail.Text = "案子详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo2";
            this.dataGridViewTextBoxColumn1.HeaderText = "发票号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RefundCurrency";
            this.dataGridViewTextBoxColumn2.HeaderText = "币别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "融资金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn4.HeaderText = "融资余额";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FinanceDate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn5.HeaderText = "融资日";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FinanceDueDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "融资到期日";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InvoiceRefundAmount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn7.HeaderText = "已还款金额";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn8.HeaderText = "本次还款金额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Interest";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn9.HeaderText = "本次利息";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Comment";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn10.HeaderText = "备注";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "InvoiceRefundAmount";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn11.HeaderText = "已还款金额";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn12.HeaderText = "本次还款金额";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Interest";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn13.HeaderText = "本次利息";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn14.HeaderText = "备注";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // InvoiceRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelRefundBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceRefund";
            this.Size = new System.Drawing.Size(1069, 486);
            this.panelRefundBatch.ResumeLayout(false);
            this.panelRefundBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.cmuInvoiceRefund.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalInterest;
        private DevComponents.DotNetBar.LabelX lblTotalInterest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReassginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRateType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectPaymentOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenaltyInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;

    }
}
