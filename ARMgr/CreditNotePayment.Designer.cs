namespace CMBC.EasyFactor.ARMgr
{
    partial class CreditNotePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditNotePayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceDeductionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceDeductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceDeductionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvInvoiceDeduction = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCreditNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeductionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditNoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDeductionBindingNavigator)).BeginInit();
            this.invoiceDeductionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDeductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDeduction)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDeductionBindingNavigator
            // 
            this.invoiceDeductionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceDeductionBindingNavigator.BindingSource = this.invoiceDeductionBindingSource;
            this.invoiceDeductionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceDeductionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceDeductionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.invoiceDeductionBindingNavigatorSaveItem});
            this.invoiceDeductionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceDeductionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceDeductionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceDeductionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceDeductionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceDeductionBindingNavigator.Name = "invoiceDeductionBindingNavigator";
            this.invoiceDeductionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceDeductionBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.invoiceDeductionBindingNavigator.TabIndex = 0;
            this.invoiceDeductionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // invoiceDeductionBindingSource
            // 
            this.invoiceDeductionBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceDeduction);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // invoiceDeductionBindingNavigatorSaveItem
            // 
            this.invoiceDeductionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceDeductionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceDeductionBindingNavigatorSaveItem.Image")));
            this.invoiceDeductionBindingNavigatorSaveItem.Name = "invoiceDeductionBindingNavigatorSaveItem";
            this.invoiceDeductionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoiceDeductionBindingNavigatorSaveItem.Text = "Save Data";
            this.invoiceDeductionBindingNavigatorSaveItem.Click += new System.EventHandler(this.Save);
            // 
            // dgvInvoiceDeduction
            // 
            this.dgvInvoiceDeduction.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceDeduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDeduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreditNoteNo,
            this.colDeductionAmount,
            this.colCreditNoteDate,
            this.colDeductionDate,
            this.colInvoiceNo,
            this.colComment});
            this.dgvInvoiceDeduction.DataSource = this.invoiceDeductionBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceDeduction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceDeduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDeduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoiceDeduction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoiceDeduction.Location = new System.Drawing.Point(0, 25);
            this.dgvInvoiceDeduction.Name = "dgvInvoiceDeduction";
            this.dgvInvoiceDeduction.Size = new System.Drawing.Size(870, 458);
            this.dgvInvoiceDeduction.TabIndex = 1;
            this.dgvInvoiceDeduction.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgvCreditNote_CellParsing);
            this.dgvInvoiceDeduction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCreditNote_CellFormatting);
            this.dgvInvoiceDeduction.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCreditNote_CellValidating);
            this.dgvInvoiceDeduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditNote_CellClick);
            // 
            // colCreditNoteNo
            // 
            this.colCreditNoteNo.DataPropertyName = "CreditNoteNo";
            this.colCreditNoteNo.HeaderText = "贷项通知号";
            this.colCreditNoteNo.Name = "colCreditNoteNo";
            // 
            // colDeductionAmount
            // 
            this.colDeductionAmount.DataPropertyName = "DeductionAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colDeductionAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDeductionAmount.HeaderText = "贷项通知金额";
            this.colDeductionAmount.Name = "colDeductionAmount";
            // 
            // colCreditNoteDate
            // 
            this.colCreditNoteDate.DataPropertyName = "CreditNoteDate";
            this.colCreditNoteDate.HeaderText = "贷项通知日";
            this.colCreditNoteDate.Name = "colCreditNoteDate";
            // 
            // colDeductionDate
            // 
            this.colDeductionDate.DataPropertyName = "DeductionDate";
            this.colDeductionDate.HeaderText = "录入日期";
            this.colDeductionDate.Name = "colDeductionDate";
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "对应发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            // 
            // CreditNotePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoiceDeduction);
            this.Controls.Add(this.invoiceDeductionBindingNavigator);
            this.Name = "CreditNotePayment";
            this.Size = new System.Drawing.Size(870, 483);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDeductionBindingNavigator)).EndInit();
            this.invoiceDeductionBindingNavigator.ResumeLayout(false);
            this.invoiceDeductionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDeductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDeduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceDeductionBindingSource;
        private System.Windows.Forms.BindingNavigator invoiceDeductionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton invoiceDeductionBindingNavigatorSaveItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoiceDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}
