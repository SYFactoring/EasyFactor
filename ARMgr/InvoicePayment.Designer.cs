namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoicePayment
    {
        #region Fields (73)

        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource invoicePaymentBatchBindingSource;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private DevComponents.DotNetBar.Controls.CheckBoxX isCreateMsgCheckBox;
        private DevComponents.DotNetBar.LabelX lblPaymentAmount;
        private DevComponents.DotNetBar.PanelEx panelPaymentBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX paymentBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput paymentDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentAmount;

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
            DevComponents.DotNetBar.LabelX paymentBatchNoLabel;
            DevComponents.DotNetBar.LabelX paymentDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX lblPaymentType;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePayment));
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
            this.panelPaymentBatch = new DevComponents.DotNetBar.PanelEx();
            this.btnPaymentBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.tbPaymentType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoicePaymentBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPaymentBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.lblPaymentAmount = new DevComponents.DotNetBar.LabelX();
            this.tbPaymentAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isCreateMsgCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.paymentDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.paymentBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoicePayment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemPaymentBatchExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaymentBatchImport = new System.Windows.Forms.ToolStripMenuItem();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            paymentBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            paymentDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblPaymentType = new DevComponents.DotNetBar.LabelX();
            this.panelPaymentBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePaymentBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoicePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentBatchNoLabel
            // 
            paymentBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            paymentBatchNoLabel.BackgroundStyle.Class = "";
            paymentBatchNoLabel.Location = new System.Drawing.Point(25, 6);
            paymentBatchNoLabel.Name = "paymentBatchNoLabel";
            paymentBatchNoLabel.Size = new System.Drawing.Size(56, 16);
            paymentBatchNoLabel.TabIndex = 0;
            paymentBatchNoLabel.Text = "还款批号";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            // 
            // 
            // 
            paymentDateLabel.BackgroundStyle.Class = "";
            paymentDateLabel.Location = new System.Drawing.Point(206, 6);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(47, 16);
            paymentDateLabel.TabIndex = 2;
            paymentDateLabel.Text = "还款日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(345, 38);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 9;
            commentLabel.Text = "备注:";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            // 
            // 
            // 
            lblPaymentType.BackgroundStyle.Class = "";
            lblPaymentType.Location = new System.Drawing.Point(25, 31);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new System.Drawing.Size(56, 16);
            lblPaymentType.TabIndex = 4;
            lblPaymentType.Text = "还款类型";
            // 
            // panelPaymentBatch
            // 
            this.panelPaymentBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelPaymentBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelPaymentBatch.Controls.Add(this.btnPaymentBatchNew);
            this.panelPaymentBatch.Controls.Add(this.tbPaymentType);
            this.panelPaymentBatch.Controls.Add(lblPaymentType);
            this.panelPaymentBatch.Controls.Add(this.btnPaymentBatchSave);
            this.panelPaymentBatch.Controls.Add(this.lblPaymentAmount);
            this.panelPaymentBatch.Controls.Add(this.tbPaymentAmount);
            this.panelPaymentBatch.Controls.Add(commentLabel);
            this.panelPaymentBatch.Controls.Add(this.commentTextBox);
            this.panelPaymentBatch.Controls.Add(this.isCreateMsgCheckBox);
            this.panelPaymentBatch.Controls.Add(paymentDateLabel);
            this.panelPaymentBatch.Controls.Add(this.paymentDateDateTimePicker);
            this.panelPaymentBatch.Controls.Add(paymentBatchNoLabel);
            this.panelPaymentBatch.Controls.Add(this.paymentBatchNoTextBox);
            this.panelPaymentBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymentBatch.Location = new System.Drawing.Point(0, 0);
            this.panelPaymentBatch.Name = "panelPaymentBatch";
            this.panelPaymentBatch.Size = new System.Drawing.Size(680, 84);
            this.panelPaymentBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelPaymentBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelPaymentBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelPaymentBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelPaymentBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelPaymentBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelPaymentBatch.Style.GradientAngle = 90;
            this.panelPaymentBatch.TabIndex = 0;
            // 
            // btnPaymentBatchNew
            // 
            this.btnPaymentBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchNew.Location = new System.Drawing.Point(600, 9);
            this.btnPaymentBatchNew.Name = "btnPaymentBatchNew";
            this.btnPaymentBatchNew.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaymentBatchNew.TabIndex = 12;
            this.btnPaymentBatchNew.Text = "新建批次";
            this.btnPaymentBatchNew.Click += new System.EventHandler(this.NewPaymentBatch);
            // 
            // tbPaymentType
            // 
            // 
            // 
            // 
            this.tbPaymentType.Border.Class = "TextBoxBorder";
            this.tbPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicePaymentBatchBindingSource, "PaymentType", true));
            this.tbPaymentType.Location = new System.Drawing.Point(90, 29);
            this.tbPaymentType.Name = "tbPaymentType";
            this.tbPaymentType.Size = new System.Drawing.Size(100, 20);
            this.tbPaymentType.TabIndex = 5;
            // 
            // invoicePaymentBatchBindingSource
            // 
            this.invoicePaymentBatchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoicePaymentBatch);
            // 
            // btnPaymentBatchSave
            // 
            this.btnPaymentBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaymentBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaymentBatchSave.Location = new System.Drawing.Point(600, 38);
            this.btnPaymentBatchSave.Name = "btnPaymentBatchSave";
            this.btnPaymentBatchSave.Size = new System.Drawing.Size(61, 23);
            this.btnPaymentBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaymentBatchSave.TabIndex = 11;
            this.btnPaymentBatchSave.Text = "保存批次";
            this.btnPaymentBatchSave.Click += new System.EventHandler(this.SavePaymentBatch);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            // 
            // 
            // 
            this.lblPaymentAmount.BackgroundStyle.Class = "";
            this.lblPaymentAmount.Location = new System.Drawing.Point(3, 55);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(81, 16);
            this.lblPaymentAmount.TabIndex = 7;
            this.lblPaymentAmount.Text = "本次还款总额";
            // 
            // tbPaymentAmount
            // 
            // 
            // 
            // 
            this.tbPaymentAmount.Border.Class = "TextBoxBorder";
            this.tbPaymentAmount.Location = new System.Drawing.Point(90, 54);
            this.tbPaymentAmount.Name = "tbPaymentAmount";
            this.tbPaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.tbPaymentAmount.TabIndex = 8;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicePaymentBatchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(385, 5);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(209, 56);
            this.commentTextBox.TabIndex = 10;
            // 
            // isCreateMsgCheckBox
            // 
            // 
            // 
            // 
            this.isCreateMsgCheckBox.BackgroundStyle.Class = "";
            this.isCreateMsgCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoicePaymentBatchBindingSource, "IsCreateMsg", true));
            this.isCreateMsgCheckBox.Location = new System.Drawing.Point(206, 28);
            this.isCreateMsgCheckBox.Name = "isCreateMsgCheckBox";
            this.isCreateMsgCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isCreateMsgCheckBox.TabIndex = 6;
            this.isCreateMsgCheckBox.Text = "是否生成EDI报文";
            // 
            // paymentDateDateTimePicker
            // 
            // 
            // 
            // 
            this.paymentDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paymentDateDateTimePicker.ButtonDropDown.Visible = true;
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicePaymentBatchBindingSource, "PaymentDate", true));
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(259, 5);
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
            // paymentBatchNoTextBox
            // 
            // 
            // 
            // 
            this.paymentBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.paymentBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicePaymentBatchBindingSource, "PaymentBatchNo", true));
            this.paymentBatchNoTextBox.Location = new System.Drawing.Point(90, 3);
            this.paymentBatchNoTextBox.Name = "paymentBatchNoTextBox";
            this.paymentBatchNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentBatchNoTextBox.TabIndex = 1;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<CMBC.EasyFactor.DB.dbml.Invoice>);
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
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 84);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(680, 25);
            this.invoiceBindingNavigator.TabIndex = 1;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colInvoiceNo,
            this.colInvoiceCurrency,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colDueDate,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colFinanceDueDate,
            this.colPaymentAmount,
            this.colPaymentDate,
            this.colRefundAmount,
            this.colRefundDate,
            this.colCommission,
            this.colCommissionDate,
            this.colInterest,
            this.colInterestDate});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoicePayment;
            this.dgvInvoices.DataSource = this.invoiceBindingSource;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 109);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(680, 417);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellValueChanged);
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
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle17.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle17;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle18.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle18;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle19.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle19;
            this.colDueDate.HeaderText = "发票到期日";
            this.colDueDate.Name = "colDueDate";
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle20.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle20;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle21.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle21;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            // 
            // colFinanceDueDate
            // 
            this.colFinanceDueDate.DataPropertyName = "FinanceDueDate";
            dataGridViewCellStyle22.Format = "d";
            this.colFinanceDueDate.DefaultCellStyle = dataGridViewCellStyle22;
            this.colFinanceDueDate.HeaderText = "融资到期日";
            this.colFinanceDueDate.Name = "colFinanceDueDate";
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle23.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle23;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle24.Format = "d";
            this.colPaymentDate.DefaultCellStyle = dataGridViewCellStyle24;
            this.colPaymentDate.HeaderText = "付款日";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle25.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle25;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            dataGridViewCellStyle26.Format = "d";
            this.colRefundDate.DefaultCellStyle = dataGridViewCellStyle26;
            this.colRefundDate.HeaderText = "还款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle27.Format = "N2";
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle27;
            this.colCommission.HeaderText = "手续费";
            this.colCommission.Name = "colCommission";
            // 
            // colCommissionDate
            // 
            this.colCommissionDate.DataPropertyName = "CommissionDate";
            dataGridViewCellStyle28.Format = "d";
            this.colCommissionDate.DefaultCellStyle = dataGridViewCellStyle28;
            this.colCommissionDate.HeaderText = "手续费收取日";
            this.colCommissionDate.Name = "colCommissionDate";
            this.colCommissionDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle29.Format = "N2";
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle29;
            this.colInterest.HeaderText = "利息";
            this.colInterest.Name = "colInterest";
            // 
            // colInterestDate
            // 
            this.colInterestDate.DataPropertyName = "InterestDate";
            dataGridViewCellStyle30.Format = "d";
            this.colInterestDate.DefaultCellStyle = dataGridViewCellStyle30;
            this.colInterestDate.HeaderText = "利息收取日";
            this.colInterestDate.Name = "colInterestDate";
            this.colInterestDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmuInvoicePayment
            // 
            this.cmuInvoicePayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.toolStripSeparator1,
            this.menuItemPaymentBatchExport,
            this.menuItemPaymentBatchImport});
            this.cmuInvoicePayment.Name = "cmuInvoiceFinance";
            this.cmuInvoicePayment.Size = new System.Drawing.Size(123, 76);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(122, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemPaymentBatchExport
            // 
            this.menuItemPaymentBatchExport.Enabled = false;
            this.menuItemPaymentBatchExport.Name = "menuItemPaymentBatchExport";
            this.menuItemPaymentBatchExport.Size = new System.Drawing.Size(122, 22);
            this.menuItemPaymentBatchExport.Text = "导出批次";
            // 
            // menuItemPaymentBatchImport
            // 
            this.menuItemPaymentBatchImport.Enabled = false;
            this.menuItemPaymentBatchImport.Name = "menuItemPaymentBatchImport";
            this.menuItemPaymentBatchImport.Size = new System.Drawing.Size(122, 22);
            this.menuItemPaymentBatchImport.Text = "导入批次";
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
            // InvoicePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelPaymentBatch);
            this.Name = "InvoicePayment";
            this.Size = new System.Drawing.Size(680, 526);
            this.panelPaymentBatch.ResumeLayout(false);
            this.panelPaymentBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicePaymentBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoicePayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnPaymentBatchSave;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ContextMenuStrip cmuInvoicePayment;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaymentBatchExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaymentBatchImport;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestDate;
        private DevComponents.DotNetBar.ButtonX btnPaymentBatchNew;


    }
}
