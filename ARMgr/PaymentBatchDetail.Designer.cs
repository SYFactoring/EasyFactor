﻿namespace CMBC.EasyFactor.ARMgr
{
    partial class PaymentBatchDetail
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
            this.dgvPaymentLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditNoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentLogs)).BeginInit();
            this.cmuLogMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPaymentLogs
            // 
            this.dgvPaymentLogs.AllowUserToAddRows = false;
            this.dgvPaymentLogs.AllowUserToDeleteRows = false;
            this.dgvPaymentLogs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colPaymentAmount,
            this.colCreditNoteNo,
            this.colCreditNoteDate,
            this.colComment});
            this.dgvPaymentLogs.ContextMenuStrip = this.cmuLogMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPaymentLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvPaymentLogs.Name = "dgvPaymentLogs";
            this.dgvPaymentLogs.ReadOnly = true;
            this.dgvPaymentLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentLogs.Size = new System.Drawing.Size(620, 376);
            this.dgvPaymentLogs.TabIndex = 0;
            this.dgvPaymentLogs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPaymentLogs_RowPostPaint);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colCreditNoteNo
            // 
            this.colCreditNoteNo.DataPropertyName = "CreditNoteNo";
            this.colCreditNoteNo.HeaderText = "贷项通知编号";
            this.colCreditNoteNo.Name = "colCreditNoteNo";
            this.colCreditNoteNo.ReadOnly = true;
            // 
            // colCreditNoteDate
            // 
            this.colCreditNoteDate.DataPropertyName = "CreditNoteDate";
            this.colCreditNoteDate.HeaderText = "贷项通知日";
            this.colCreditNoteDate.Name = "colCreditNoteDate";
            this.colCreditNoteDate.ReadOnly = true;
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
            // PaymentBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPaymentLogs);
            this.Name = "PaymentBatchDetail";
            this.Size = new System.Drawing.Size(620, 376);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentLogs)).EndInit();
            this.cmuLogMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPaymentLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.ContextMenuStrip cmuLogMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogDelete;
    }
}
