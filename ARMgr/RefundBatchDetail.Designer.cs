namespace CMBC.EasyFactor.ARMgr
{
    partial class RefundBatchDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRefundLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).BeginInit();
            this.cmuLogMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRefundLogs
            // 
            this.dgvRefundLogs.AllowUserToAddRows = false;
            this.dgvRefundLogs.AllowUserToDeleteRows = false;
            this.dgvRefundLogs.AllowUserToOrderColumns = true;
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
            this.colRefundAmount,
            this.colComment});
            this.dgvRefundLogs.ContextMenuStrip = this.cmuLogMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRefundLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRefundLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRefundLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvRefundLogs.Name = "dgvRefundLogs";
            this.dgvRefundLogs.ReadOnly = true;
            this.dgvRefundLogs.Size = new System.Drawing.Size(620, 376);
            this.dgvRefundLogs.TabIndex = 0;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
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
            this.menuItemLogDelete.Text = "&D删除";
            this.menuItemLogDelete.Click += new System.EventHandler(this.DeleteLog);
            // 
            // RefundBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRefundLogs);
            this.Name = "RefundBatchDetail";
            this.Size = new System.Drawing.Size(620, 376);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).EndInit();
            this.cmuLogMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRefundLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.ContextMenuStrip cmuLogMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogDelete;
    }
}
