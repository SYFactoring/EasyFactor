//-----------------------------------------------------------------------
// <copyright file="ContractBasicInfo.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.ContractInfo
{
    /// <summary>
    /// Contract Basic Info Designer
    /// </summary>
    public partial class ContractBasicInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbSellerName;
        private System.Windows.Forms.Label lbSellerFactorNo;
        private System.Windows.Forms.Label lbSellerFactorName;
        private System.Windows.Forms.Label lbBuyerFactorName;
        private System.Windows.Forms.Label lbBuyerFactorNo;
        private System.Windows.Forms.Label lbBuyerName;
        private System.Windows.Forms.GroupBox gbSeller;
        private System.Windows.Forms.GroupBox gbBuyer;
        private System.Windows.Forms.TextBox tbSellerFactorName;
        private System.Windows.Forms.TextBox tbSellerFactorNo;
        private System.Windows.Forms.TextBox tbSellerName;
        private System.Windows.Forms.GroupBox gbBusiness;
        private System.Windows.Forms.Label lbBizType;
        private System.Windows.Forms.Label lbInvoiceCurrency;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.TextBox tbBuyerFactorName;
        private System.Windows.Forms.TextBox tbBuyerFactorNo;
        private System.Windows.Forms.TextBox tbBizType;
        private System.Windows.Forms.TextBox tbInvoiceCurrency;
        private System.Windows.Forms.Button btnSelectContract;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSellerName = new System.Windows.Forms.Label();
            this.lbSellerFactorNo = new System.Windows.Forms.Label();
            this.lbSellerFactorName = new System.Windows.Forms.Label();
            this.lbBuyerFactorName = new System.Windows.Forms.Label();
            this.lbBuyerFactorNo = new System.Windows.Forms.Label();
            this.lbBuyerName = new System.Windows.Forms.Label();
            this.gbSeller = new System.Windows.Forms.GroupBox();
            this.tbSellerFactorName = new System.Windows.Forms.TextBox();
            this.tbSellerFactorNo = new System.Windows.Forms.TextBox();
            this.tbSellerName = new System.Windows.Forms.TextBox();
            this.gbBuyer = new System.Windows.Forms.GroupBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.tbBuyerFactorName = new System.Windows.Forms.TextBox();
            this.tbBuyerFactorNo = new System.Windows.Forms.TextBox();
            this.gbBusiness = new System.Windows.Forms.GroupBox();
            this.tbBizType = new System.Windows.Forms.TextBox();
            this.tbInvoiceCurrency = new System.Windows.Forms.TextBox();
            this.lbBizType = new System.Windows.Forms.Label();
            this.lbInvoiceCurrency = new System.Windows.Forms.Label();
            this.btnSelectContract = new System.Windows.Forms.Button();
            this.gbSeller.SuspendLayout();
            this.gbBuyer.SuspendLayout();
            this.gbBusiness.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSellerName
            // 
            this.lbSellerName.AutoSize = true;
            this.lbSellerName.Location = new System.Drawing.Point(6, 19);
            this.lbSellerName.Name = "lbSellerName";
            this.lbSellerName.Size = new System.Drawing.Size(35, 12);
            this.lbSellerName.TabIndex = 0;
            this.lbSellerName.Text = "名称:";
            // 
            // lbSellerFactorNo
            // 
            this.lbSellerFactorNo.AutoSize = true;
            this.lbSellerFactorNo.Location = new System.Drawing.Point(6, 46);
            this.lbSellerFactorNo.Name = "lbSellerFactorNo";
            this.lbSellerFactorNo.Size = new System.Drawing.Size(71, 12);
            this.lbSellerFactorNo.TabIndex = 1;
            this.lbSellerFactorNo.Text = "保理商代码:";
            // 
            // lbSellerFactorName
            // 
            this.lbSellerFactorName.AutoSize = true;
            this.lbSellerFactorName.Location = new System.Drawing.Point(6, 73);
            this.lbSellerFactorName.Name = "lbSellerFactorName";
            this.lbSellerFactorName.Size = new System.Drawing.Size(71, 12);
            this.lbSellerFactorName.TabIndex = 2;
            this.lbSellerFactorName.Text = "保理商名称:";
            // 
            // lbBuyerFactorName
            // 
            this.lbBuyerFactorName.AutoSize = true;
            this.lbBuyerFactorName.Location = new System.Drawing.Point(6, 73);
            this.lbBuyerFactorName.Name = "lbBuyerFactorName";
            this.lbBuyerFactorName.Size = new System.Drawing.Size(71, 12);
            this.lbBuyerFactorName.TabIndex = 5;
            this.lbBuyerFactorName.Text = "保理商名称:";
            // 
            // lbBuyerFactorNo
            // 
            this.lbBuyerFactorNo.AutoSize = true;
            this.lbBuyerFactorNo.Location = new System.Drawing.Point(6, 46);
            this.lbBuyerFactorNo.Name = "lbBuyerFactorNo";
            this.lbBuyerFactorNo.Size = new System.Drawing.Size(71, 12);
            this.lbBuyerFactorNo.TabIndex = 4;
            this.lbBuyerFactorNo.Text = "保理商代码:";
            // 
            // lbBuyerName
            // 
            this.lbBuyerName.AutoSize = true;
            this.lbBuyerName.Location = new System.Drawing.Point(6, 19);
            this.lbBuyerName.Name = "lbBuyerName";
            this.lbBuyerName.Size = new System.Drawing.Size(35, 12);
            this.lbBuyerName.TabIndex = 3;
            this.lbBuyerName.Text = "名称:";
            // 
            // gbSeller
            // 
            this.gbSeller.Controls.Add(this.tbSellerFactorName);
            this.gbSeller.Controls.Add(this.tbSellerFactorNo);
            this.gbSeller.Controls.Add(this.tbSellerName);
            this.gbSeller.Controls.Add(this.lbSellerName);
            this.gbSeller.Controls.Add(this.lbSellerFactorNo);
            this.gbSeller.Controls.Add(this.lbSellerFactorName);
            this.gbSeller.Location = new System.Drawing.Point(3, 3);
            this.gbSeller.Name = "gbSeller";
            this.gbSeller.Size = new System.Drawing.Size(250, 100);
            this.gbSeller.TabIndex = 6;
            this.gbSeller.TabStop = false;
            this.gbSeller.Text = "卖方信息";
            // 
            // tbSellerFactorName
            // 
            this.tbSellerFactorName.Location = new System.Drawing.Point(77, 70);
            this.tbSellerFactorName.Name = "tbSellerFactorName";
            this.tbSellerFactorName.ReadOnly = true;
            this.tbSellerFactorName.Size = new System.Drawing.Size(167, 21);
            this.tbSellerFactorName.TabIndex = 9;
            // 
            // tbSellerFactorNo
            // 
            this.tbSellerFactorNo.Location = new System.Drawing.Point(77, 43);
            this.tbSellerFactorNo.Name = "tbSellerFactorNo";
            this.tbSellerFactorNo.ReadOnly = true;
            this.tbSellerFactorNo.Size = new System.Drawing.Size(167, 21);
            this.tbSellerFactorNo.TabIndex = 4;
            // 
            // tbSellerName
            // 
            this.tbSellerName.Location = new System.Drawing.Point(77, 16);
            this.tbSellerName.Name = "tbSellerName";
            this.tbSellerName.ReadOnly = true;
            this.tbSellerName.Size = new System.Drawing.Size(167, 21);
            this.tbSellerName.TabIndex = 3;
            // 
            // gbBuyer
            // 
            this.gbBuyer.Controls.Add(this.tbBuyerName);
            this.gbBuyer.Controls.Add(this.tbBuyerFactorName);
            this.gbBuyer.Controls.Add(this.tbBuyerFactorNo);
            this.gbBuyer.Controls.Add(this.lbBuyerName);
            this.gbBuyer.Controls.Add(this.lbBuyerFactorNo);
            this.gbBuyer.Controls.Add(this.lbBuyerFactorName);
            this.gbBuyer.Location = new System.Drawing.Point(259, 3);
            this.gbBuyer.Name = "gbBuyer";
            this.gbBuyer.Size = new System.Drawing.Size(250, 100);
            this.gbBuyer.TabIndex = 7;
            this.gbBuyer.TabStop = false;
            this.gbBuyer.Text = "买方信息";
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Location = new System.Drawing.Point(77, 16);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.ReadOnly = true;
            this.tbBuyerName.Size = new System.Drawing.Size(167, 21);
            this.tbBuyerName.TabIndex = 11;
            // 
            // tbBuyerFactorName
            // 
            this.tbBuyerFactorName.Location = new System.Drawing.Point(77, 70);
            this.tbBuyerFactorName.Name = "tbBuyerFactorName";
            this.tbBuyerFactorName.ReadOnly = true;
            this.tbBuyerFactorName.Size = new System.Drawing.Size(167, 21);
            this.tbBuyerFactorName.TabIndex = 10;
            // 
            // tbBuyerFactorNo
            // 
            this.tbBuyerFactorNo.Location = new System.Drawing.Point(77, 43);
            this.tbBuyerFactorNo.Name = "tbBuyerFactorNo";
            this.tbBuyerFactorNo.ReadOnly = true;
            this.tbBuyerFactorNo.Size = new System.Drawing.Size(167, 21);
            this.tbBuyerFactorNo.TabIndex = 9;
            // 
            // gbBusiness
            // 
            this.gbBusiness.Controls.Add(this.tbBizType);
            this.gbBusiness.Controls.Add(this.tbInvoiceCurrency);
            this.gbBusiness.Controls.Add(this.lbBizType);
            this.gbBusiness.Controls.Add(this.lbInvoiceCurrency);
            this.gbBusiness.Location = new System.Drawing.Point(515, 3);
            this.gbBusiness.Name = "gbBusiness";
            this.gbBusiness.Size = new System.Drawing.Size(177, 75);
            this.gbBusiness.TabIndex = 8;
            this.gbBusiness.TabStop = false;
            this.gbBusiness.Text = "业务信息";
            // 
            // tbBizType
            // 
            this.tbBizType.Location = new System.Drawing.Point(66, 43);
            this.tbBizType.Name = "tbBizType";
            this.tbBizType.ReadOnly = true;
            this.tbBizType.Size = new System.Drawing.Size(100, 21);
            this.tbBizType.TabIndex = 13;
            // 
            // tbInvoiceCurrency
            // 
            this.tbInvoiceCurrency.Location = new System.Drawing.Point(66, 16);
            this.tbInvoiceCurrency.Name = "tbInvoiceCurrency";
            this.tbInvoiceCurrency.ReadOnly = true;
            this.tbInvoiceCurrency.Size = new System.Drawing.Size(100, 21);
            this.tbInvoiceCurrency.TabIndex = 12;
            // 
            // lbBizType
            // 
            this.lbBizType.AutoSize = true;
            this.lbBizType.Location = new System.Drawing.Point(6, 46);
            this.lbBizType.Name = "lbBizType";
            this.lbBizType.Size = new System.Drawing.Size(59, 12);
            this.lbBizType.TabIndex = 1;
            this.lbBizType.Text = "业务类别:";
            // 
            // lbInvoiceCurrency
            // 
            this.lbInvoiceCurrency.AutoSize = true;
            this.lbInvoiceCurrency.Location = new System.Drawing.Point(6, 19);
            this.lbInvoiceCurrency.Name = "lbInvoiceCurrency";
            this.lbInvoiceCurrency.Size = new System.Drawing.Size(59, 12);
            this.lbInvoiceCurrency.TabIndex = 0;
            this.lbInvoiceCurrency.Text = "发票币别:";
            // 
            // btnSelectContract
            // 
            this.btnSelectContract.Location = new System.Drawing.Point(515, 80);
            this.btnSelectContract.Name = "btnSelectContract";
            this.btnSelectContract.Size = new System.Drawing.Size(100, 23);
            this.btnSelectContract.TabIndex = 9;
            this.btnSelectContract.Text = "选择案件";
            this.btnSelectContract.UseVisualStyleBackColor = true;
            this.btnSelectContract.Click += new System.EventHandler(this.SelectContract);
            // 
            // ContractBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSelectContract);
            this.Controls.Add(this.gbBusiness);
            this.Controls.Add(this.gbBuyer);
            this.Controls.Add(this.gbSeller);
            this.Name = "ContractBasicInfo";
            this.Size = new System.Drawing.Size(700, 110);
            this.gbSeller.ResumeLayout(false);
            this.gbSeller.PerformLayout();
            this.gbBuyer.ResumeLayout(false);
            this.gbBuyer.PerformLayout();
            this.gbBusiness.ResumeLayout(false);
            this.gbBusiness.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
