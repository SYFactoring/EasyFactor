using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.Utils.ConstStr;
namespace CMBC.EasyFactor.ARMgr
{
    partial class RefundBatchDetail
    {
		#region?Fields?(32)?

        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput checkDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx checkStatusComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX checkUserNameTextBox;
        private System.Windows.Forms.ContextMenuStrip cmuLogMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRefundLogs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diInputDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogDelete;
        private DevComponents.DotNetBar.TabControlPanel panelBatch;
        private DevComponents.DotNetBar.TabControlPanel panelInvoices;
        private DevComponents.DotNetBar.Controls.TextBoxX refundBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput refundDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx refundTypeComboBox;
        private DevComponents.DotNetBar.LabelX refundTypeLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX rejectReasonTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabItem tabItemBatch;
        private DevComponents.DotNetBar.TabItem tabItemInvoices;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;

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

            if (this.context != null)
            {
                this.context.Dispose();
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
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX checkUserNameLabel;
            DevComponents.DotNetBar.LabelX checkDateLabel;
            DevComponents.DotNetBar.LabelX rejectReasonLabel;
            DevComponents.DotNetBar.LabelX checkStatusLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX refundDateLabel;
            DevComponents.DotNetBar.LabelX refundBatchNoLabel;
            DevComponents.DotNetBar.LabelX CaseLabel;
            DevComponents.DotNetBar.LabelX lblInputDate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundBatchDetail));
            DevComponents.DotNetBar.LabelX lblClient;
            this.refundTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.cmuLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.panelInvoices = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvRefundLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItemInvoices = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelBatch = new DevComponents.DotNetBar.TabControlPanel();
            this.diInputDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refundTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rejectReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.refundDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.refundBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemBatch = new DevComponents.DotNetBar.TabItem(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            checkUserNameLabel = new DevComponents.DotNetBar.LabelX();
            checkDateLabel = new DevComponents.DotNetBar.LabelX();
            rejectReasonLabel = new DevComponents.DotNetBar.LabelX();
            checkStatusLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            refundDateLabel = new DevComponents.DotNetBar.LabelX();
            refundBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            CaseLabel = new DevComponents.DotNetBar.LabelX();
            lblInputDate = new DevComponents.DotNetBar.LabelX();
            lblClient = new DevComponents.DotNetBar.LabelX();
            this.cmuLogMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panelInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).BeginInit();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(55, 99);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 31;
            commentLabel.Text = "��ע:";
            // 
            // checkUserNameLabel
            // 
            checkUserNameLabel.AutoSize = true;
            checkUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkUserNameLabel.BackgroundStyle.Class = "";
            checkUserNameLabel.Location = new System.Drawing.Point(42, 292);
            checkUserNameLabel.Name = "checkUserNameLabel";
            checkUserNameLabel.Size = new System.Drawing.Size(47, 16);
            checkUserNameLabel.TabIndex = 42;
            checkUserNameLabel.Text = "������:";
            // 
            // checkDateLabel
            // 
            checkDateLabel.AutoSize = true;
            checkDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkDateLabel.BackgroundStyle.Class = "";
            checkDateLabel.Location = new System.Drawing.Point(42, 267);
            checkDateLabel.Name = "checkDateLabel";
            checkDateLabel.Size = new System.Drawing.Size(47, 16);
            checkDateLabel.TabIndex = 40;
            checkDateLabel.Text = "������:";
            // 
            // rejectReasonLabel
            // 
            rejectReasonLabel.AutoSize = true;
            rejectReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            rejectReasonLabel.BackgroundStyle.Class = "";
            rejectReasonLabel.Location = new System.Drawing.Point(30, 214);
            rejectReasonLabel.Name = "rejectReasonLabel";
            rejectReasonLabel.Size = new System.Drawing.Size(59, 16);
            rejectReasonLabel.TabIndex = 38;
            rejectReasonLabel.Text = "�˻�ԭ��:";
            // 
            // checkStatusLabel
            // 
            checkStatusLabel.AutoSize = true;
            checkStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkStatusLabel.BackgroundStyle.Class = "";
            checkStatusLabel.Location = new System.Drawing.Point(30, 188);
            checkStatusLabel.Name = "checkStatusLabel";
            checkStatusLabel.Size = new System.Drawing.Size(59, 16);
            checkStatusLabel.TabIndex = 36;
            checkStatusLabel.Text = "����״̬:";
            // 
            // createUserNameLabel
            // 
            createUserNameLabel.AutoSize = true;
            createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            createUserNameLabel.BackgroundStyle.Class = "";
            createUserNameLabel.Location = new System.Drawing.Point(42, 165);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 34;
            createUserNameLabel.Text = "������:";
            // 
            // refundDateLabel
            // 
            refundDateLabel.AutoSize = true;
            refundDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundDateLabel.BackgroundStyle.Class = "";
            refundDateLabel.Location = new System.Drawing.Point(42, 75);
            refundDateLabel.Name = "refundDateLabel";
            refundDateLabel.Size = new System.Drawing.Size(47, 16);
            refundDateLabel.TabIndex = 29;
            refundDateLabel.Text = "������:";
            // 
            // refundBatchNoLabel
            // 
            refundBatchNoLabel.AutoSize = true;
            refundBatchNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundBatchNoLabel.BackgroundStyle.Class = "";
            refundBatchNoLabel.Location = new System.Drawing.Point(30, 28);
            refundBatchNoLabel.Name = "refundBatchNoLabel";
            refundBatchNoLabel.Size = new System.Drawing.Size(59, 16);
            refundBatchNoLabel.TabIndex = 25;
            refundBatchNoLabel.Text = "��������:";
            // 
            // CaseLabel
            // 
            CaseLabel.AutoSize = true;
            CaseLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            CaseLabel.BackgroundStyle.Class = "";
            CaseLabel.Location = new System.Drawing.Point(30, 4);
            CaseLabel.Name = "CaseLabel";
            CaseLabel.Size = new System.Drawing.Size(59, 16);
            CaseLabel.TabIndex = 23;
            CaseLabel.Text = "�������:";
            // 
            // lblInputDate
            // 
            lblInputDate.AutoSize = true;
            lblInputDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblInputDate.BackgroundStyle.Class = "";
            lblInputDate.Location = new System.Drawing.Point(247, 75);
            lblInputDate.Name = "lblInputDate";
            lblInputDate.Size = new System.Drawing.Size(47, 16);
            lblInputDate.TabIndex = 46;
            lblInputDate.Text = "¼����:";
            // 
            // refundTypeLabel
            // 
            this.refundTypeLabel.AutoSize = true;
            this.refundTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.refundTypeLabel.BackgroundStyle.Class = "";
            this.refundTypeLabel.Location = new System.Drawing.Point(30, 51);
            this.refundTypeLabel.Name = "refundTypeLabel";
            this.refundTypeLabel.Size = new System.Drawing.Size(59, 16);
            this.refundTypeLabel.TabIndex = 27;
            this.refundTypeLabel.Text = "��������:";
            // 
            // cmuLogMgr
            // 
            this.cmuLogMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogDelete});
            this.cmuLogMgr.Name = "cmuContractMgr";
            this.cmuLogMgr.Size = new System.Drawing.Size(107, 26);
            // 
            // menuItemLogDelete
            // 
            this.menuItemLogDelete.Name = "menuItemLogDelete";
            this.menuItemLogDelete.Size = new System.Drawing.Size(106, 22);
            this.menuItemLogDelete.Text = "&Dɾ��";
            this.menuItemLogDelete.Click += new System.EventHandler(this.DeleteLog);
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.panelBatch);
            this.tabControl1.Controls.Add(this.panelInvoices);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 389);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItemBatch);
            this.tabControl1.Tabs.Add(this.tabItemInvoices);
            // 
            // panelInvoices
            // 
            this.panelInvoices.Controls.Add(this.dgvRefundLogs);
            this.panelInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoices.Location = new System.Drawing.Point(0, 26);
            this.panelInvoices.Name = "panelInvoices";
            this.panelInvoices.Padding = new System.Windows.Forms.Padding(1);
            this.panelInvoices.Size = new System.Drawing.Size(446, 363);
            this.panelInvoices.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelInvoices.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelInvoices.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelInvoices.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelInvoices.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelInvoices.Style.GradientAngle = 90;
            this.panelInvoices.TabIndex = 2;
            this.panelInvoices.TabItem = this.tabItemInvoices;
            // 
            // dgvRefundLogs
            // 
            this.dgvRefundLogs.AllowUserToAddRows = false;
            this.dgvRefundLogs.AllowUserToDeleteRows = false;
            this.dgvRefundLogs.AllowUserToOrderColumns = true;
            this.dgvRefundLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRefundLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colFinanceOutstanding,
            this.colRefundAmount,
            this.colComment});
            this.dgvRefundLogs.ContextMenuStrip = this.cmuLogMgr;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundLogs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRefundLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRefundLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRefundLogs.Location = new System.Drawing.Point(1, 1);
            this.dgvRefundLogs.Name = "dgvRefundLogs";
            this.dgvRefundLogs.ReadOnly = true;
            this.dgvRefundLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundLogs.Size = new System.Drawing.Size(444, 361);
            this.dgvRefundLogs.TabIndex = 1;
            this.dgvRefundLogs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailInvoice);
            this.dgvRefundLogs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRefundLogs_RowPostPaint);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "��Ʊ��";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle2.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFinanceOutstanding.HeaderText = "�������";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle3.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRefundAmount.HeaderText = "������";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "��ע";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // tabItemInvoices
            // 
            this.tabItemInvoices.AttachedControl = this.panelInvoices;
            this.tabItemInvoices.Name = "tabItemInvoices";
            this.tabItemInvoices.Text = "��Ʊ";
            // 
            // panelBatch
            // 
            this.panelBatch.Controls.Add(lblClient);
            this.panelBatch.Controls.Add(this.tbClientName);
            this.panelBatch.Controls.Add(lblInputDate);
            this.panelBatch.Controls.Add(this.diInputDate);
            this.panelBatch.Controls.Add(this.refundTypeLabel);
            this.panelBatch.Controls.Add(this.refundTypeComboBox);
            this.panelBatch.Controls.Add(this.checkStatusComboBox);
            this.panelBatch.Controls.Add(this.btnSave);
            this.panelBatch.Controls.Add(this.btnUpdate);
            this.panelBatch.Controls.Add(commentLabel);
            this.panelBatch.Controls.Add(this.commentTextBox);
            this.panelBatch.Controls.Add(checkUserNameLabel);
            this.panelBatch.Controls.Add(this.checkUserNameTextBox);
            this.panelBatch.Controls.Add(checkDateLabel);
            this.panelBatch.Controls.Add(this.checkDateDateTimePicker);
            this.panelBatch.Controls.Add(rejectReasonLabel);
            this.panelBatch.Controls.Add(this.rejectReasonTextBox);
            this.panelBatch.Controls.Add(checkStatusLabel);
            this.panelBatch.Controls.Add(createUserNameLabel);
            this.panelBatch.Controls.Add(this.createUserNameTextBox);
            this.panelBatch.Controls.Add(refundDateLabel);
            this.panelBatch.Controls.Add(this.refundDateDateTimePicker);
            this.panelBatch.Controls.Add(refundBatchNoLabel);
            this.panelBatch.Controls.Add(this.refundBatchNoTextBox);
            this.panelBatch.Controls.Add(CaseLabel);
            this.panelBatch.Controls.Add(this.caseCodeTextBox);
            this.panelBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBatch.Location = new System.Drawing.Point(0, 26);
            this.panelBatch.Name = "panelBatch";
            this.panelBatch.Padding = new System.Windows.Forms.Padding(1);
            this.panelBatch.Size = new System.Drawing.Size(446, 363);
            this.panelBatch.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelBatch.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBatch.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelBatch.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelBatch.Style.GradientAngle = 90;
            this.panelBatch.TabIndex = 1;
            this.panelBatch.TabItem = this.tabItemBatch;
            // 
            // diInputDate
            // 
            // 
            // 
            // 
            this.diInputDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diInputDate.ButtonDropDown.Visible = true;
            this.diInputDate.ButtonFreeText.Checked = true;
            this.diInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "InputDate", true));
            this.diInputDate.FreeTextEntryMode = true;
            this.diInputDate.Location = new System.Drawing.Point(300, 71);
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diInputDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diInputDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.diInputDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diInputDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diInputDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diInputDate.Name = "diInputDate";
            this.diInputDate.Size = new System.Drawing.Size(121, 20);
            this.diInputDate.TabIndex = 47;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceRefundBatch);
            // 
            // refundTypeComboBox
            // 
            this.refundTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RefundType", true));
            this.refundTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.refundTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refundTypeComboBox.FormattingEnabled = true;
            this.refundTypeComboBox.Items.AddRange(new object[] {
            "��ֱ�Ӹ���",
            "��������"});
            this.refundTypeComboBox.Location = new System.Drawing.Point(95, 49);
            this.refundTypeComboBox.Name = "refundTypeComboBox";
            this.refundTypeComboBox.Size = new System.Drawing.Size(134, 21);
            this.refundTypeComboBox.TabIndex = 28;
            // 
            // checkStatusComboBox
            // 
            this.checkStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckStatus", true));
            this.checkStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkStatusComboBox.FormattingEnabled = true;
            this.checkStatusComboBox.Items.AddRange(new object[] {
            "δ����",
            "�Ѹ���",
            "����δͨ��"});
            this.checkStatusComboBox.Location = new System.Drawing.Point(95, 186);
            this.checkStatusComboBox.Name = "checkStatusComboBox";
            this.checkStatusComboBox.Size = new System.Drawing.Size(134, 21);
            this.checkStatusComboBox.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(202, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "����";
            this.btnSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(115, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "�༭";
            this.btnUpdate.Click += new System.EventHandler(this.UpdateBatch);
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(95, 97);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(326, 66);
            this.commentTextBox.TabIndex = 32;
            // 
            // checkUserNameTextBox
            // 
            // 
            // 
            // 
            this.checkUserNameTextBox.Border.Class = "TextBoxBorder";
            this.checkUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckUserName", true));
            this.checkUserNameTextBox.Location = new System.Drawing.Point(95, 291);
            this.checkUserNameTextBox.Name = "checkUserNameTextBox";
            this.checkUserNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.checkUserNameTextBox.TabIndex = 43;
            // 
            // checkDateDateTimePicker
            // 
            // 
            // 
            // 
            this.checkDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.checkDateDateTimePicker.ButtonDropDown.Visible = true;
            this.checkDateDateTimePicker.ButtonFreeText.Checked = true;
            this.checkDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "CheckDate", true));
            this.checkDateDateTimePicker.FreeTextEntryMode = true;
            this.checkDateDateTimePicker.Location = new System.Drawing.Point(95, 266);
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.checkDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.checkDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.checkDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.checkDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.checkDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.checkDateDateTimePicker.Name = "checkDateDateTimePicker";
            this.checkDateDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.checkDateDateTimePicker.TabIndex = 41;
            // 
            // rejectReasonTextBox
            // 
            // 
            // 
            // 
            this.rejectReasonTextBox.Border.Class = "TextBoxBorder";
            this.rejectReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RejectReason", true));
            this.rejectReasonTextBox.Location = new System.Drawing.Point(95, 213);
            this.rejectReasonTextBox.Multiline = true;
            this.rejectReasonTextBox.Name = "rejectReasonTextBox";
            this.rejectReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rejectReasonTextBox.Size = new System.Drawing.Size(326, 51);
            this.rejectReasonTextBox.TabIndex = 39;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(95, 164);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.ReadOnly = true;
            this.createUserNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.createUserNameTextBox.TabIndex = 35;
            // 
            // refundDateDateTimePicker
            // 
            // 
            // 
            // 
            this.refundDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.refundDateDateTimePicker.ButtonDropDown.Visible = true;
            this.refundDateDateTimePicker.ButtonFreeText.Checked = true;
            this.refundDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "RefundDate", true));
            this.refundDateDateTimePicker.FreeTextEntryMode = true;
            this.refundDateDateTimePicker.Location = new System.Drawing.Point(95, 73);
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.refundDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.refundDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.refundDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.refundDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.refundDateDateTimePicker.Name = "refundDateDateTimePicker";
            this.refundDateDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.refundDateDateTimePicker.TabIndex = 30;
            // 
            // refundBatchNoTextBox
            // 
            // 
            // 
            // 
            this.refundBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.refundBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RefundBatchNo", true));
            this.refundBatchNoTextBox.Location = new System.Drawing.Point(95, 26);
            this.refundBatchNoTextBox.Name = "refundBatchNoTextBox";
            this.refundBatchNoTextBox.Size = new System.Drawing.Size(134, 20);
            this.refundBatchNoTextBox.TabIndex = 26;
            // 
            // caseCodeTextBox
            // 
            // 
            // 
            // 
            this.caseCodeTextBox.Border.Class = "TextBoxBorder";
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(95, 2);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(134, 20);
            this.caseCodeTextBox.TabIndex = 24;
            this.caseCodeTextBox.DoubleClick += new System.EventHandler(this.DetailCase);
            // 
            // tabItemBatch
            // 
            this.tabItemBatch.AttachedControl = this.panelBatch;
            this.tabItemBatch.Name = "tabItemBatch";
            this.tabItemBatch.Text = "����";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // superValidator
            // 
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblClient.BackgroundStyle.Class = "";
            lblClient.Location = new System.Drawing.Point(235, 4);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(59, 16);
            lblClient.TabIndex = 48;
            lblClient.Text = "��������:";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceBatchNo", true));
            this.tbClientName.Location = new System.Drawing.Point(300, 2);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(121, 20);
            this.tbClientName.TabIndex = 49;
            this.tbClientName.DoubleClick += new System.EventHandler(this.DetailFinanceBatch);
            // 
            // RefundBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 389);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "RefundBatchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "����������Ϣ";
            this.cmuLogMgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panelInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).EndInit();
            this.panelBatch.ResumeLayout(false);
            this.panelBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
