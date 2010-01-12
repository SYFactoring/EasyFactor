namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.tbFinanceOverDueDays = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFinanceOverDueDays = new DevComponents.DotNetBar.LabelX();
            this.tbAssignOverDueDays = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignOverDueDays = new DevComponents.DotNetBar.LabelX();
            this.cbIsDispute = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsFlaw = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoiceNo = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.btnBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactor = new DevComponents.DotNetBar.LabelX();
            this.tbBuyer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyer = new DevComponents.DotNetBar.LabelX();
            this.tbSeller = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSeller = new DevComponents.DotNetBar.LabelX();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFlaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDispute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOverDueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOverDueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemInvoiceFlaw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInvoiceDispute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInvoiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExportAllInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExportSelectedInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoiceMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.tbFinanceOverDueDays);
            this.panelQuery.Controls.Add(this.lblFinanceOverDueDays);
            this.panelQuery.Controls.Add(this.tbAssignOverDueDays);
            this.panelQuery.Controls.Add(this.lblAssignOverDueDays);
            this.panelQuery.Controls.Add(this.cbIsDispute);
            this.panelQuery.Controls.Add(this.cbIsFlaw);
            this.panelQuery.Controls.Add(this.tbInvoiceNo);
            this.panelQuery.Controls.Add(this.lblInvoiceNo);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQueryReset);
            this.panelQuery.Controls.Add(this.btnBatchQuery);
            this.panelQuery.Controls.Add(this.tbFactor);
            this.panelQuery.Controls.Add(this.lblFactor);
            this.panelQuery.Controls.Add(this.tbBuyer);
            this.panelQuery.Controls.Add(this.lblBuyer);
            this.panelQuery.Controls.Add(this.tbSeller);
            this.panelQuery.Controls.Add(this.lblSeller);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(805, 56);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 1;
            // 
            // tbFinanceOverDueDays
            // 
            // 
            // 
            // 
            this.tbFinanceOverDueDays.Border.Class = "TextBoxBorder";
            this.tbFinanceOverDueDays.Location = new System.Drawing.Point(412, 30);
            this.tbFinanceOverDueDays.Name = "tbFinanceOverDueDays";
            this.tbFinanceOverDueDays.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceOverDueDays.TabIndex = 16;
            // 
            // lblFinanceOverDueDays
            // 
            this.lblFinanceOverDueDays.AutoSize = true;
            // 
            // 
            // 
            this.lblFinanceOverDueDays.BackgroundStyle.Class = "";
            this.lblFinanceOverDueDays.Location = new System.Drawing.Point(325, 33);
            this.lblFinanceOverDueDays.Name = "lblFinanceOverDueDays";
            this.lblFinanceOverDueDays.Size = new System.Drawing.Size(81, 16);
            this.lblFinanceOverDueDays.TabIndex = 15;
            this.lblFinanceOverDueDays.Text = "融资逾期天数";
            // 
            // tbAssignOverDueDays
            // 
            // 
            // 
            // 
            this.tbAssignOverDueDays.Border.Class = "TextBoxBorder";
            this.tbAssignOverDueDays.Location = new System.Drawing.Point(412, 7);
            this.tbAssignOverDueDays.Name = "tbAssignOverDueDays";
            this.tbAssignOverDueDays.Size = new System.Drawing.Size(100, 20);
            this.tbAssignOverDueDays.TabIndex = 14;
            // 
            // lblAssignOverDueDays
            // 
            this.lblAssignOverDueDays.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignOverDueDays.BackgroundStyle.Class = "";
            this.lblAssignOverDueDays.Location = new System.Drawing.Point(305, 10);
            this.lblAssignOverDueDays.Name = "lblAssignOverDueDays";
            this.lblAssignOverDueDays.Size = new System.Drawing.Size(106, 16);
            this.lblAssignOverDueDays.TabIndex = 13;
            this.lblAssignOverDueDays.Text = "应收帐款逾期天数";
            // 
            // cbIsDispute
            // 
            this.cbIsDispute.AutoSize = true;
            // 
            // 
            // 
            this.cbIsDispute.BackgroundStyle.Class = "";
            this.cbIsDispute.Checked = true;
            this.cbIsDispute.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsDispute.CheckValue = "A";
            this.cbIsDispute.CheckValueIndeterminate = "A";
            this.cbIsDispute.Location = new System.Drawing.Point(518, 35);
            this.cbIsDispute.Name = "cbIsDispute";
            this.cbIsDispute.Size = new System.Drawing.Size(76, 16);
            this.cbIsDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsDispute.TabIndex = 9;
            this.cbIsDispute.Text = "是否商纠";
            this.cbIsDispute.ThreeState = true;
            // 
            // cbIsFlaw
            // 
            this.cbIsFlaw.AutoSize = true;
            // 
            // 
            // 
            this.cbIsFlaw.BackgroundStyle.Class = "";
            this.cbIsFlaw.Checked = true;
            this.cbIsFlaw.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsFlaw.CheckValue = "A";
            this.cbIsFlaw.CheckValueIndeterminate = "A";
            this.cbIsFlaw.Location = new System.Drawing.Point(518, 10);
            this.cbIsFlaw.Name = "cbIsFlaw";
            this.cbIsFlaw.Size = new System.Drawing.Size(76, 16);
            this.cbIsFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsFlaw.TabIndex = 8;
            this.cbIsFlaw.Text = "是否瑕疵";
            this.cbIsFlaw.ThreeState = true;
            // 
            // tbInvoiceNo
            // 
            // 
            // 
            // 
            this.tbInvoiceNo.Border.Class = "TextBoxBorder";
            this.tbInvoiceNo.Location = new System.Drawing.Point(199, 31);
            this.tbInvoiceNo.Name = "tbInvoiceNo";
            this.tbInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tbInvoiceNo.TabIndex = 7;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            // 
            // 
            // 
            this.lblInvoiceNo.BackgroundStyle.Class = "";
            this.lblInvoiceNo.Location = new System.Drawing.Point(158, 31);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(44, 16);
            this.lblInvoiceNo.TabIndex = 6;
            this.lblInvoiceNo.Text = "发票号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(671, 34);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 12;
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(600, 30);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(46, 22);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 11;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnBatchQuery
            // 
            this.btnBatchQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchQuery.Location = new System.Drawing.Point(600, 7);
            this.btnBatchQuery.Name = "btnBatchQuery";
            this.btnBatchQuery.Size = new System.Drawing.Size(46, 22);
            this.btnBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchQuery.TabIndex = 10;
            this.btnBatchQuery.Text = "查询";
            this.btnBatchQuery.Click += new System.EventHandler(this.QueryInvoices);
            // 
            // tbFactor
            // 
            // 
            // 
            // 
            this.tbFactor.Border.Class = "TextBoxBorder";
            this.tbFactor.Location = new System.Drawing.Point(52, 30);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(100, 20);
            this.tbFactor.TabIndex = 5;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            // 
            // 
            // 
            this.lblFactor.BackgroundStyle.Class = "";
            this.lblFactor.Location = new System.Drawing.Point(5, 31);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(44, 16);
            this.lblFactor.TabIndex = 4;
            this.lblFactor.Text = "保理商";
            // 
            // tbBuyer
            // 
            // 
            // 
            // 
            this.tbBuyer.Border.Class = "TextBoxBorder";
            this.tbBuyer.Location = new System.Drawing.Point(199, 8);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(100, 20);
            this.tbBuyer.TabIndex = 3;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            // 
            // 
            // 
            this.lblBuyer.BackgroundStyle.Class = "";
            this.lblBuyer.Location = new System.Drawing.Point(171, 8);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(31, 16);
            this.lblBuyer.TabIndex = 2;
            this.lblBuyer.Text = "买方";
            // 
            // tbSeller
            // 
            // 
            // 
            // 
            this.tbSeller.Border.Class = "TextBoxBorder";
            this.tbSeller.Location = new System.Drawing.Point(52, 7);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(100, 20);
            this.tbSeller.TabIndex = 1;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            // 
            // 
            // 
            this.lblSeller.BackgroundStyle.Class = "";
            this.lblSeller.Location = new System.Drawing.Point(17, 9);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(31, 16);
            this.lblSeller.TabIndex = 0;
            this.lblSeller.Text = "卖方";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colInvoiceNo,
            this.colInvoiceCurrency,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colInvoiceDate,
            this.colDueDate,
            this.colAssignDate,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colFinanceDate,
            this.colFinanceDueDate,
            this.colPaymentAmount,
            this.colPaymentDate,
            this.colRefundAmount,
            this.colRefundDate,
            this.colIsFlaw,
            this.colIsDispute,
            this.colAssignOverDueDays,
            this.colFinanceOverDueDays});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceMgr;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 56);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(805, 301);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvInvoices.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoices_RowPostPaint);
            this.dgvInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoices_DataBindingComplete);
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.HeaderText = "卖方名称";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            this.colSellerName.Width = 80;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方名称";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            this.colBuyerName.Width = 80;
            // 
            // colFactorName
            // 
            this.colFactorName.DataPropertyName = "FactorName";
            this.colFactorName.HeaderText = "保理商";
            this.colFactorName.Name = "colFactorName";
            this.colFactorName.ReadOnly = true;
            this.colFactorName.Width = 68;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            this.colInvoiceNo.Width = 68;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Width = 80;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle3.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle4.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            this.colInvoiceDate.Width = 68;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDueDate.HeaderText = "到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 68;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            dataGridViewCellStyle6.Format = "d";
            this.colAssignDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
            this.colAssignDate.Width = 68;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle7.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.Width = 80;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle8.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            this.colFinanceDate.Width = 68;
            // 
            // colFinanceDueDate
            // 
            this.colFinanceDueDate.DataPropertyName = "FinanceDueDate";
            this.colFinanceDueDate.HeaderText = "融资到期日";
            this.colFinanceDueDate.Name = "colFinanceDueDate";
            this.colFinanceDueDate.Width = 92;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle9.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.Width = 80;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "付款日";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Width = 68;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle10.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.Width = 80;
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            this.colRefundDate.HeaderText = "还款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.Width = 68;
            // 
            // colIsFlaw
            // 
            this.colIsFlaw.DataPropertyName = "IsFlaw";
            this.colIsFlaw.HeaderText = "是否瑕疵";
            this.colIsFlaw.Name = "colIsFlaw";
            this.colIsFlaw.ReadOnly = true;
            this.colIsFlaw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsFlaw.Width = 80;
            // 
            // colIsDispute
            // 
            this.colIsDispute.DataPropertyName = "IsDispute";
            this.colIsDispute.HeaderText = "是否商纠";
            this.colIsDispute.Name = "colIsDispute";
            this.colIsDispute.Width = 80;
            // 
            // colAssignOverDueDays
            // 
            this.colAssignOverDueDays.DataPropertyName = "AssignOverDueDays";
            this.colAssignOverDueDays.HeaderText = "应收账款逾期天数";
            this.colAssignOverDueDays.Name = "colAssignOverDueDays";
            this.colAssignOverDueDays.Width = 128;
            // 
            // colFinanceOverDueDays
            // 
            this.colFinanceOverDueDays.DataPropertyName = "FinanceOverDueDays";
            this.colFinanceOverDueDays.HeaderText = "融资逾期天数";
            this.colFinanceOverDueDays.Name = "colFinanceOverDueDays";
            this.colFinanceOverDueDays.Width = 104;
            // 
            // cmuInvoiceMgr
            // 
            this.cmuInvoiceMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemInvoiceFlaw,
            this.menuItemInvoiceDispute,
            this.menuItemInvoiceDelete,
            this.toolStripSeparator1,
            this.menuItemExportAllInvoices,
            this.menuItemExportSelectedInvoices});
            this.cmuInvoiceMgr.Name = "cmuContractMgr";
            this.cmuInvoiceMgr.Size = new System.Drawing.Size(183, 192);
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
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemInvoiceFlaw
            // 
            this.menuItemInvoiceFlaw.Name = "menuItemInvoiceFlaw";
            this.menuItemInvoiceFlaw.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceFlaw.Text = "瑕疵处理";
            this.menuItemInvoiceFlaw.Click += new System.EventHandler(this.InvoiceFlaw);
            // 
            // menuItemInvoiceDispute
            // 
            this.menuItemInvoiceDispute.Name = "menuItemInvoiceDispute";
            this.menuItemInvoiceDispute.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceDispute.Text = "商纠处理";
            this.menuItemInvoiceDispute.Click += new System.EventHandler(this.InvoiceDispute);
            // 
            // menuItemInvoiceDelete
            // 
            this.menuItemInvoiceDelete.Name = "menuItemInvoiceDelete";
            this.menuItemInvoiceDelete.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceDelete.Text = "删除发票";
            this.menuItemInvoiceDelete.Click += new System.EventHandler(this.DeleteInvoice);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemExportAllInvoices
            // 
            this.menuItemExportAllInvoices.Name = "menuItemExportAllInvoices";
            this.menuItemExportAllInvoices.Size = new System.Drawing.Size(182, 22);
            this.menuItemExportAllInvoices.Text = "导出全部发票";
            this.menuItemExportAllInvoices.Click += new System.EventHandler(this.ExportAllInvoices);
            // 
            // menuItemExportSelectedInvoices
            // 
            this.menuItemExportSelectedInvoices.Name = "menuItemExportSelectedInvoices";
            this.menuItemExportSelectedInvoices.Size = new System.Drawing.Size(182, 22);
            this.menuItemExportSelectedInvoices.Text = "导出所选发票";
            this.menuItemExportSelectedInvoices.Click += new System.EventHandler(this.ExportSelectedInvoices);
            // 
            // InvoiceMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceMgr";
            this.Size = new System.Drawing.Size(805, 357);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoiceMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.ButtonX btnBatchQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactor;
        private DevComponents.DotNetBar.LabelX lblFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyer;
        private DevComponents.DotNetBar.LabelX lblBuyer;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSeller;
        private DevComponents.DotNetBar.LabelX lblSeller;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private DevComponents.DotNetBar.Controls.TextBoxX tbInvoiceNo;
        private DevComponents.DotNetBar.LabelX lblInvoiceNo;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsFlaw;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceFlaw;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportAllInvoices;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsDispute;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOverDueDays;
        private DevComponents.DotNetBar.LabelX lblFinanceOverDueDays;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignOverDueDays;
        private DevComponents.DotNetBar.LabelX lblAssignOverDueDays;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportSelectedInvoices;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDispute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsFlaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDispute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOverDueDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOverDueDays;
    }
}
