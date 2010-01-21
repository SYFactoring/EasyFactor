namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceRefund
    {
        #region Fields (46)

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount2;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.DotNetBar.LabelX lblTotalPayment;
        private DevComponents.DotNetBar.LabelX lblTotalRefund;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelRefundBatch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput paymentDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX refundBatchNoTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalPayment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalRefund;

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
            DevComponents.DotNetBar.LabelX refundBatchNoLabel;
            DevComponents.DotNetBar.LabelX refundDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX lblRefundType;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRefund));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRefundBatch = new DevComponents.DotNetBar.PanelEx();
            this.btnPaymentBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnPaymentBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnPaymentBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.lblTotalRefund = new DevComponents.DotNetBar.LabelX();
            this.tbTotalRefund = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPaymentBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.cbRefundType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPaymentBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.lblTotalPayment = new DevComponents.DotNetBar.LabelX();
            this.tbTotalPayment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.refundBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceRefund = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            refundBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            refundDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblRefundType = new DevComponents.DotNetBar.LabelX();
            this.panelRefundBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            refundBatchNoLabel.BackgroundStyle.Class = "";
            refundBatchNoLabel.Location = new System.Drawing.Point(25, 6);
            refundBatchNoLabel.Name = "refundBatchNoLabel";
            refundBatchNoLabel.Size = new System.Drawing.Size(56, 16);
            refundBatchNoLabel.TabIndex = 0;
            refundBatchNoLabel.Text = "还款批号";
            // 
            // refundDateLabel
            // 
            refundDateLabel.AutoSize = true;
            // 
            // 
            // 
            refundDateLabel.BackgroundStyle.Class = "";
            refundDateLabel.Location = new System.Drawing.Point(206, 6);
            refundDateLabel.Name = "refundDateLabel";
            refundDateLabel.Size = new System.Drawing.Size(47, 16);
            refundDateLabel.TabIndex = 2;
            refundDateLabel.Text = "还款日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(169, 55);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(31, 16);
            commentLabel.TabIndex = 9;
            commentLabel.Text = "备注";
            // 
            // lblRefundType
            // 
            lblRefundType.AutoSize = true;
            // 
            // 
            // 
            lblRefundType.BackgroundStyle.Class = "";
            lblRefundType.Location = new System.Drawing.Point(25, 31);
            lblRefundType.Name = "lblRefundType";
            lblRefundType.Size = new System.Drawing.Size(56, 16);
            lblRefundType.TabIndex = 4;
            lblRefundType.Text = "还款类型";
            // 
            // panelRefundBatch
            // 
            this.panelRefundBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelRefundBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchImport);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchExport);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchSelect);
            this.panelRefundBatch.Controls.Add(this.lblTotalRefund);
            this.panelRefundBatch.Controls.Add(this.tbTotalRefund);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchNew);
            this.panelRefundBatch.Controls.Add(this.cbRefundType);
            this.panelRefundBatch.Controls.Add(lblRefundType);
            this.panelRefundBatch.Controls.Add(this.btnPaymentBatchSave);
            this.panelRefundBatch.Controls.Add(this.lblTotalPayment);
            this.panelRefundBatch.Controls.Add(this.tbTotalPayment);
            this.panelRefundBatch.Controls.Add(commentLabel);
            this.panelRefundBatch.Controls.Add(this.commentTextBox);
            this.panelRefundBatch.Controls.Add(refundDateLabel);
            this.panelRefundBatch.Controls.Add(this.paymentDateDateTimePicker);
            this.panelRefundBatch.Controls.Add(refundBatchNoLabel);
            this.panelRefundBatch.Controls.Add(this.refundBatchNoTextBox);
            this.panelRefundBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRefundBatch.Location = new System.Drawing.Point(0, 0);
            this.panelRefundBatch.Name = "panelRefundBatch";
            this.panelRefundBatch.Size = new System.Drawing.Size(1069, 81);
            this.panelRefundBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelRefundBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelRefundBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelRefundBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelRefundBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelRefundBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelRefundBatch.Style.GradientAngle = 90;
            this.panelRefundBatch.TabIndex = 0;
            // 
            // btnPaymentBatchImport
            // 
            this.btnPaymentBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchImport.Location = new System.Drawing.Point(586, 35);
            this.btnPaymentBatchImport.Name = "btnPaymentBatchImport";
            this.btnPaymentBatchImport.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaymentBatchImport.TabIndex = 17;
            this.btnPaymentBatchImport.Text = "导入批次";
            this.btnPaymentBatchImport.Click += new System.EventHandler(this.ImportBatch);
            // 
            // btnPaymentBatchExport
            // 
            this.btnPaymentBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchExport.Location = new System.Drawing.Point(519, 35);
            this.btnPaymentBatchExport.Name = "btnPaymentBatchExport";
            this.btnPaymentBatchExport.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaymentBatchExport.TabIndex = 16;
            this.btnPaymentBatchExport.Text = "导出批次";
            this.btnPaymentBatchExport.Click += new System.EventHandler(this.ExportBatch);
            // 
            // btnPaymentBatchSelect
            // 
            this.btnPaymentBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchSelect.Location = new System.Drawing.Point(653, 6);
            this.btnPaymentBatchSelect.Name = "btnPaymentBatchSelect";
            this.btnPaymentBatchSelect.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.lblTotalRefund.BackgroundStyle.Class = "";
            this.lblTotalRefund.Location = new System.Drawing.Point(755, 28);
            this.lblTotalRefund.Name = "lblTotalRefund";
            this.lblTotalRefund.Size = new System.Drawing.Size(118, 16);
            this.lblTotalRefund.TabIndex = 13;
            this.lblTotalRefund.Text = "本次冲销融资款总额";
            // 
            // tbTotalRefund
            // 
            // 
            // 
            // 
            this.tbTotalRefund.Border.Class = "TextBoxBorder";
            this.tbTotalRefund.Location = new System.Drawing.Point(879, 26);
            this.tbTotalRefund.Name = "tbTotalRefund";
            this.tbTotalRefund.Size = new System.Drawing.Size(100, 20);
            this.tbTotalRefund.TabIndex = 14;
            // 
            // btnPaymentBatchNew
            // 
            this.btnPaymentBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchNew.Location = new System.Drawing.Point(519, 6);
            this.btnPaymentBatchNew.Name = "btnPaymentBatchNew";
            this.btnPaymentBatchNew.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.cbRefundType.Items.AddRange(new object[] {
            "买方付款",
            "间接付款",
            "担保付款",
            "卖方还款"});
            this.cbRefundType.Location = new System.Drawing.Point(90, 29);
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
            this.btnPaymentBatchSave.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaymentBatchSave.TabIndex = 11;
            this.btnPaymentBatchSave.Text = "保存批次";
            this.btnPaymentBatchSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            // 
            // 
            // 
            this.lblTotalPayment.BackgroundStyle.Class = "";
            this.lblTotalPayment.Location = new System.Drawing.Point(742, 6);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(131, 16);
            this.lblTotalPayment.TabIndex = 7;
            this.lblTotalPayment.Text = "本次冲销应收账款总额";
            // 
            // tbTotalPayment
            // 
            // 
            // 
            // 
            this.tbTotalPayment.Border.Class = "TextBoxBorder";
            this.tbTotalPayment.Location = new System.Drawing.Point(879, 4);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.Size = new System.Drawing.Size(100, 20);
            this.tbTotalPayment.TabIndex = 8;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(206, 28);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(307, 43);
            this.commentTextBox.TabIndex = 10;
            // 
            // paymentDateDateTimePicker
            // 
            // 
            // 
            // 
            this.paymentDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paymentDateDateTimePicker.ButtonDropDown.Visible = true;
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "RefundDate", true));
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(259, 4);
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.paymentDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.paymentDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.paymentDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.paymentDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.paymentDateDateTimePicker.TabIndex = 3;
            // 
            // refundBatchNoTextBox
            // 
            // 
            // 
            // 
            this.refundBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.refundBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RefundBatchNo", true));
            this.refundBatchNoTextBox.Location = new System.Drawing.Point(90, 3);
            this.refundBatchNoTextBox.Name = "refundBatchNoTextBox";
            this.refundBatchNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.refundBatchNoTextBox.TabIndex = 1;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = null;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
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
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 81);
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<CMBC.EasyFactor.DB.dbml.Invoice>);
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
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colInvoiceNo,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colAssignDate,
            this.colDueDate,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colFinanceDate,
            this.colFinanceDueDate,
            this.colRefundAmount2});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceRefund;
            this.dgvInvoices.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 106);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1069, 420);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellValueChanged);
            this.dgvInvoices.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgvInvoices_CellParsing);
            this.dgvInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInvoices_CellFormatting);
            this.dgvInvoices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInvoices_CellValidating);
            this.dgvInvoices.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_RowHeaderMouseDoubleClick);
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Width = 5;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle10.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle11.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle11;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle12.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.colDueDate.HeaderText = "发票到期日";
            this.colDueDate.Name = "colDueDate";
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle13.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle13;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle14.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle14;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            // 
            // colFinanceDueDate
            // 
            this.colFinanceDueDate.DataPropertyName = "FinanceDueDate";
            dataGridViewCellStyle15.Format = "d";
            this.colFinanceDueDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.colFinanceDueDate.HeaderText = "融资到期日";
            this.colFinanceDueDate.Name = "colFinanceDueDate";
            // 
            // colRefundAmount2
            // 
            this.colRefundAmount2.DataPropertyName = "RefundAmount2";
            this.colRefundAmount2.HeaderText = "还款金额";
            this.colRefundAmount2.Name = "colRefundAmount2";
            // 
            // cmuInvoiceRefund
            // 
            this.cmuInvoiceRefund.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail});
            this.cmuInvoiceRefund.Name = "cmuInvoiceFinance";
            this.cmuInvoiceRefund.Size = new System.Drawing.Size(183, 70);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDADetail.Text = "额度通知书详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(182, 22);
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
            // InvoiceRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelRefundBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceRefund";
            this.Size = new System.Drawing.Size(1069, 526);
            this.panelRefundBatch.ResumeLayout(false);
            this.panelRefundBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoiceRefund.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
