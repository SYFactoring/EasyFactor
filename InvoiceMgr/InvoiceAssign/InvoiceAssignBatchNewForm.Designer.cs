//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatchNewForm.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.InvoiceAssign
{
    public partial class InvoiceAssignBatchNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource assignBatchBindingSource;
        private System.Windows.Forms.TextBox tbAssignBatchNo;
        private System.Windows.Forms.TextBox tbContractNo;
        private System.Windows.Forms.ComboBox cbAssignBatchCurrency;
        private System.Windows.Forms.TextBox tbBatchDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbAssignBatchNo;
            System.Windows.Forms.Label lbBatchCurrency;
            System.Windows.Forms.Label lbBatchDate;
            System.Windows.Forms.Label lbContractNo;
            this.tbAssignBatchNo = new System.Windows.Forms.TextBox();
            this.assignBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContractNo = new System.Windows.Forms.TextBox();
            this.cbAssignBatchCurrency = new System.Windows.Forms.ComboBox();
            this.tbBatchDate = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            lbAssignBatchNo = new System.Windows.Forms.Label();
            lbBatchCurrency = new System.Windows.Forms.Label();
            lbBatchDate = new System.Windows.Forms.Label();
            lbContractNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignBatchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAssignBatchNo
            // 
            lbAssignBatchNo.AutoSize = true;
            lbAssignBatchNo.Location = new System.Drawing.Point(15, 36);
            lbAssignBatchNo.Name = "lbAssignBatchNo";
            lbAssignBatchNo.Size = new System.Drawing.Size(59, 12);
            lbAssignBatchNo.TabIndex = 99;
            lbAssignBatchNo.Text = "转让批号:";
            // 
            // lbBatchCurrency
            // 
            lbBatchCurrency.AutoSize = true;
            lbBatchCurrency.Location = new System.Drawing.Point(15, 63);
            lbBatchCurrency.Name = "lbBatchCurrency";
            lbBatchCurrency.Size = new System.Drawing.Size(35, 12);
            lbBatchCurrency.TabIndex = 99;
            lbBatchCurrency.Text = "币种:";
            // 
            // lbBatchDate
            // 
            lbBatchDate.AutoSize = true;
            lbBatchDate.Location = new System.Drawing.Point(15, 89);
            lbBatchDate.Name = "lbBatchDate";
            lbBatchDate.Size = new System.Drawing.Size(47, 12);
            lbBatchDate.TabIndex = 99;
            lbBatchDate.Text = "转让日:";
            // 
            // lbContractNo
            // 
            lbContractNo.AutoSize = true;
            lbContractNo.Location = new System.Drawing.Point(15, 9);
            lbContractNo.Name = "lbContractNo";
            lbContractNo.Size = new System.Drawing.Size(47, 12);
            lbContractNo.TabIndex = 99;
            lbContractNo.Text = "合同号:";
            // 
            // tbAssignBatchNo
            // 
            this.tbAssignBatchNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignBatchBindingSource, "AssignBatchNo", true));
            this.tbAssignBatchNo.Location = new System.Drawing.Point(80, 33);
            this.tbAssignBatchNo.Name = "tbAssignBatchNo";
            this.tbAssignBatchNo.ReadOnly = true;
            this.tbAssignBatchNo.Size = new System.Drawing.Size(150, 21);
            this.tbAssignBatchNo.TabIndex = 1;
            this.tbAssignBatchNo.TabStop = false;
            // 
            // assignBatchBindingSource
            // 
            this.assignBatchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceAssignBatch);
            // 
            // tbContractNo
            // 
            this.tbContractNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignBatchBindingSource, "ContractNo", true));
            this.tbContractNo.Location = new System.Drawing.Point(80, 6);
            this.tbContractNo.Name = "tbContractNo";
            this.tbContractNo.ReadOnly = true;
            this.tbContractNo.Size = new System.Drawing.Size(150, 21);
            this.tbContractNo.TabIndex = 0;
            this.tbContractNo.TabStop = false;
            // 
            // cbAssignBatchCurrency
            // 
            this.cbAssignBatchCurrency.FormattingEnabled = true;
            this.cbAssignBatchCurrency.Location = new System.Drawing.Point(80, 60);
            this.cbAssignBatchCurrency.Name = "cbAssignBatchCurrency";
            this.cbAssignBatchCurrency.Size = new System.Drawing.Size(150, 20);
            this.cbAssignBatchCurrency.TabIndex = 0;
            // 
            // tbBatchDate
            // 
            this.tbBatchDate.Location = new System.Drawing.Point(80, 86);
            this.tbBatchDate.Name = "tbBatchDate";
            this.tbBatchDate.ReadOnly = true;
            this.tbBatchDate.Size = new System.Drawing.Size(150, 21);
            this.tbBatchDate.TabIndex = 3;
            this.tbBatchDate.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(44, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OK);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // InvoiceAssignBatchNewForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(244, 154);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbBatchDate);
            this.Controls.Add(this.cbAssignBatchCurrency);
            this.Controls.Add(lbAssignBatchNo);
            this.Controls.Add(this.tbAssignBatchNo);
            this.Controls.Add(lbBatchCurrency);
            this.Controls.Add(lbBatchDate);
            this.Controls.Add(lbContractNo);
            this.Controls.Add(this.tbContractNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceAssignBatchNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建转让批次";
            ((System.ComponentModel.ISupportInitialize)(this.assignBatchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}