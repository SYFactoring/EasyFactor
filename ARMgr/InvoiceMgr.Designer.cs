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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
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
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFlaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemInvoiceFlaw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInvoiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExportAssignFinancePayment = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIsDispute = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoiceMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelQuery.Size = new System.Drawing.Size(513, 56);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 1;
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
            this.cbIsFlaw.Location = new System.Drawing.Point(314, 9);
            this.cbIsFlaw.Name = "cbIsFlaw";
            this.cbIsFlaw.Size = new System.Drawing.Size(76, 16);
            this.cbIsFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsFlaw.TabIndex = 21;
            this.cbIsFlaw.Text = "是否瑕疵";
            this.cbIsFlaw.ThreeState = true;
            // 
            // tbInvoiceNo
            // 
            // 
            // 
            // 
            this.tbInvoiceNo.Border.Class = "TextBoxBorder";
            this.tbInvoiceNo.Location = new System.Drawing.Point(208, 30);
            this.tbInvoiceNo.Name = "tbInvoiceNo";
            this.tbInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tbInvoiceNo.TabIndex = 20;
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
            this.lblInvoiceNo.TabIndex = 19;
            this.lblInvoiceNo.Text = "发票号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(460, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 18;
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(408, 31);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(46, 22);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 17;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnBatchQuery
            // 
            this.btnBatchQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchQuery.Location = new System.Drawing.Point(408, 5);
            this.btnBatchQuery.Name = "btnBatchQuery";
            this.btnBatchQuery.Size = new System.Drawing.Size(46, 22);
            this.btnBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchQuery.TabIndex = 16;
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
            this.tbFactor.TabIndex = 15;
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
            this.lblFactor.TabIndex = 14;
            this.lblFactor.Text = "保理商";
            // 
            // tbBuyer
            // 
            // 
            // 
            // 
            this.tbBuyer.Border.Class = "TextBoxBorder";
            this.tbBuyer.Location = new System.Drawing.Point(208, 7);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(100, 20);
            this.tbBuyer.TabIndex = 13;
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
            this.lblBuyer.TabIndex = 12;
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
            this.tbSeller.TabIndex = 11;
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
            this.lblSeller.TabIndex = 10;
            this.lblSeller.Text = "卖方";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colInvoiceNo,
            this.colInvoiceCurrency,
            this.colAssignAmount,
            this.colInvoiceDate,
            this.colAssignDate,
            this.colDueDate,
            this.colIsFlaw});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceMgr;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 56);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(513, 301);
            this.dgvInvoices.TabIndex = 3;
            this.dgvInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
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
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle3.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            dataGridViewCellStyle4.Format = "d";
            this.colAssignDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
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
            // 
            // colIsFlaw
            // 
            this.colIsFlaw.DataPropertyName = "IsFlaw";
            this.colIsFlaw.HeaderText = "是否瑕疵";
            this.colIsFlaw.Name = "colIsFlaw";
            this.colIsFlaw.ReadOnly = true;
            this.colIsFlaw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmuInvoiceMgr
            // 
            this.cmuInvoiceMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.toolStripSeparator,
            this.menuItemInvoiceFlaw,
            this.menuItemInvoiceDelete,
            this.toolStripSeparator1,
            this.menuItemExportAssignFinancePayment});
            this.cmuInvoiceMgr.Name = "cmuContractMgr";
            this.cmuInvoiceMgr.Size = new System.Drawing.Size(123, 104);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(122, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemInvoiceFlaw
            // 
            this.menuItemInvoiceFlaw.Name = "menuItemInvoiceFlaw";
            this.menuItemInvoiceFlaw.Size = new System.Drawing.Size(122, 22);
            this.menuItemInvoiceFlaw.Text = "瑕疵处理";
            this.menuItemInvoiceFlaw.Click += new System.EventHandler(this.InvoiceFlaw);
            // 
            // menuItemInvoiceDelete
            // 
            this.menuItemInvoiceDelete.Name = "menuItemInvoiceDelete";
            this.menuItemInvoiceDelete.Size = new System.Drawing.Size(122, 22);
            this.menuItemInvoiceDelete.Text = "删除发票";
            this.menuItemInvoiceDelete.Click += new System.EventHandler(this.DeleteInvoice);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemExportAssignFinancePayment
            // 
            this.menuItemExportAssignFinancePayment.Name = "menuItemExportAssignFinancePayment";
            this.menuItemExportAssignFinancePayment.Size = new System.Drawing.Size(122, 22);
            this.menuItemExportAssignFinancePayment.Text = "导出台帐";
            this.menuItemExportAssignFinancePayment.Click += new System.EventHandler(this.ExportAssignFinancePayment);
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
            this.cbIsDispute.Location = new System.Drawing.Point(314, 34);
            this.cbIsDispute.Name = "cbIsDispute";
            this.cbIsDispute.Size = new System.Drawing.Size(76, 16);
            this.cbIsDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsDispute.TabIndex = 22;
            this.cbIsDispute.Text = "是否商纠";
            this.cbIsDispute.ThreeState = true;
            // 
            // InvoiceMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.panelQuery);
            this.Name = "InvoiceMgr";
            this.Size = new System.Drawing.Size(513, 357);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsFlaw;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceFlaw;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportAssignFinancePayment;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsDispute;
    }
}
