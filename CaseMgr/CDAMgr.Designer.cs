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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactor = new DevComponents.DotNetBar.LabelX();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCDAQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.cmuCDAMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCDAQuery
            // 
            this.panelCDAQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCDAQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCDAQuery.Controls.Add(this.tbFactorName);
            this.panelCDAQuery.Controls.Add(this.lblFactor);
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
            this.tbBuyerName.Location = new System.Drawing.Point(237, 24);
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
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colTransactionType,
            this.colInvoiceCurrency,
            this.colCreditLineExpireDate,
            this.colFinanceLineExpiry,
            this.colLineOrder,
            this.colPrice,
            this.colFee,
            this.colStatus});
            this.dgvCDAs.ContextMenuStrip = this.cmuCDAMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(0, 54);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(643, 348);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
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
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Location = new System.Drawing.Point(238, 3);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(100, 20);
            this.tbFactorName.TabIndex = 9;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            // 
            // 
            // 
            this.lblFactor.BackgroundStyle.Class = "";
            this.lblFactor.Location = new System.Drawing.Point(192, 4);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(44, 16);
            this.lblFactor.TabIndex = 8;
            this.lblFactor.Text = "保理商";
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
            // colCreditLineExpireDate
            // 
            this.colCreditLineExpireDate.HeaderText = "Credit Line Expiry Date";
            this.colCreditLineExpireDate.Name = "colCreditLineExpireDate";
            this.colCreditLineExpireDate.ReadOnly = true;
            // 
            // colFinanceLineExpiry
            // 
            this.colFinanceLineExpiry.HeaderText = "Finance Line Expiry";
            this.colFinanceLineExpiry.Name = "colFinanceLineExpiry";
            this.colFinanceLineExpiry.ReadOnly = true;
            // 
            // colLineOrder
            // 
            this.colLineOrder.HeaderText = "Line Order";
            this.colLineOrder.Name = "colLineOrder";
            this.colLineOrder.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colFee
            // 
            this.colFee.HeaderText = "Fee";
            this.colFee.Name = "colFee";
            this.colFee.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // CDAMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCDAs);
            this.Controls.Add(this.panelCDAQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CDAMgr";
            this.Size = new System.Drawing.Size(643, 402);
            this.panelCDAQuery.ResumeLayout(false);
            this.panelCDAQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.cmuCDAMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private DevComponents.DotNetBar.LabelX lblFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;




    }
}
