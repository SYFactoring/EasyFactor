//-----------------------------------------------------------------------
// <copyright file="ContractOtherInfo.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.ContractInfo
{
    /// <summary>
    /// Contract other info designer
    /// </summary>
    public partial class ContractOtherInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbBuyerCredit;
        private System.Windows.Forms.Label lbCreditCover;
        private System.Windows.Forms.TextBox tbCreditCover;
        private System.Windows.Forms.Label lbCoverDueday;
        private System.Windows.Forms.TextBox tbCreditDueday;
        private System.Windows.Forms.Label lbReceivableBalance;
        private System.Windows.Forms.TextBox tbCreditBalance;
        private System.Windows.Forms.Label lbCreditBalance;
        private System.Windows.Forms.TextBox tbReceivableBalance;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.TextBox tbHandFee;
        private System.Windows.Forms.Label lbHandFeeCur;
        private System.Windows.Forms.TextBox tbIFPrice;
        private System.Windows.Forms.Label lbIFPrice;
        private System.Windows.Forms.TextBox tbEFPrice;
        private System.Windows.Forms.Label lbEFPrice;
        private System.Windows.Forms.TextBox tbTotalFPrice;
        private System.Windows.Forms.Label lbTotalFPrice;
        private System.Windows.Forms.GroupBox gbFinance;
        private System.Windows.Forms.TextBox tbFinanceBalance;
        private System.Windows.Forms.Label lbFinanceBalance;
        private System.Windows.Forms.TextBox tbFinanceUnkown;
        private System.Windows.Forms.Label lbFinanceUnkown;
        private System.Windows.Forms.TextBox tbFinanceDueday;
        private System.Windows.Forms.Label lbFinanceDueday;
        private System.Windows.Forms.TextBox tbFinanceLine;
        private System.Windows.Forms.Label lbFinanceLine;

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
            this.gbBuyerCredit = new System.Windows.Forms.GroupBox();
            this.tbReceivableBalance = new System.Windows.Forms.TextBox();
            this.lbReceivableBalance = new System.Windows.Forms.Label();
            this.tbCreditBalance = new System.Windows.Forms.TextBox();
            this.lbCreditBalance = new System.Windows.Forms.Label();
            this.tbCreditDueday = new System.Windows.Forms.TextBox();
            this.lbCoverDueday = new System.Windows.Forms.Label();
            this.tbCreditCover = new System.Windows.Forms.TextBox();
            this.lbCreditCover = new System.Windows.Forms.Label();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.tbHandFee = new System.Windows.Forms.TextBox();
            this.lbHandFeeCur = new System.Windows.Forms.Label();
            this.tbIFPrice = new System.Windows.Forms.TextBox();
            this.lbIFPrice = new System.Windows.Forms.Label();
            this.tbEFPrice = new System.Windows.Forms.TextBox();
            this.lbEFPrice = new System.Windows.Forms.Label();
            this.tbTotalFPrice = new System.Windows.Forms.TextBox();
            this.lbTotalFPrice = new System.Windows.Forms.Label();
            this.gbFinance = new System.Windows.Forms.GroupBox();
            this.tbFinanceBalance = new System.Windows.Forms.TextBox();
            this.lbFinanceBalance = new System.Windows.Forms.Label();
            this.tbFinanceUnkown = new System.Windows.Forms.TextBox();
            this.lbFinanceUnkown = new System.Windows.Forms.Label();
            this.tbFinanceDueday = new System.Windows.Forms.TextBox();
            this.lbFinanceDueday = new System.Windows.Forms.Label();
            this.tbFinanceLine = new System.Windows.Forms.TextBox();
            this.lbFinanceLine = new System.Windows.Forms.Label();
            this.gbBuyerCredit.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.gbFinance.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuyerCredit
            // 
            this.gbBuyerCredit.Controls.Add(this.tbReceivableBalance);
            this.gbBuyerCredit.Controls.Add(this.lbReceivableBalance);
            this.gbBuyerCredit.Controls.Add(this.tbCreditBalance);
            this.gbBuyerCredit.Controls.Add(this.lbCreditBalance);
            this.gbBuyerCredit.Controls.Add(this.tbCreditDueday);
            this.gbBuyerCredit.Controls.Add(this.lbCoverDueday);
            this.gbBuyerCredit.Controls.Add(this.tbCreditCover);
            this.gbBuyerCredit.Controls.Add(this.lbCreditCover);
            this.gbBuyerCredit.Location = new System.Drawing.Point(217, 3);
            this.gbBuyerCredit.Name = "gbBuyerCredit";
            this.gbBuyerCredit.Size = new System.Drawing.Size(220, 130);
            this.gbBuyerCredit.TabIndex = 0;
            this.gbBuyerCredit.TabStop = false;
            this.gbBuyerCredit.Text = "买方信用风险担保额度信息";
            // 
            // tbReceivableBalance
            // 
            this.tbReceivableBalance.Location = new System.Drawing.Point(95, 97);
            this.tbReceivableBalance.Name = "tbReceivableBalance";
            this.tbReceivableBalance.ReadOnly = true;
            this.tbReceivableBalance.Size = new System.Drawing.Size(119, 21);
            this.tbReceivableBalance.TabIndex = 7;
            // 
            // lbReceivableBalance
            // 
            this.lbReceivableBalance.AutoSize = true;
            this.lbReceivableBalance.Location = new System.Drawing.Point(6, 100);
            this.lbReceivableBalance.Name = "lbReceivableBalance";
            this.lbReceivableBalance.Size = new System.Drawing.Size(83, 12);
            this.lbReceivableBalance.TabIndex = 6;
            this.lbReceivableBalance.Text = "应收账款余额:";
            // 
            // tbCreditBalance
            // 
            this.tbCreditBalance.Location = new System.Drawing.Point(95, 70);
            this.tbCreditBalance.Name = "tbCreditBalance";
            this.tbCreditBalance.ReadOnly = true;
            this.tbCreditBalance.Size = new System.Drawing.Size(119, 21);
            this.tbCreditBalance.TabIndex = 5;
            // 
            // lbCreditBalance
            // 
            this.lbCreditBalance.AutoSize = true;
            this.lbCreditBalance.Location = new System.Drawing.Point(6, 73);
            this.lbCreditBalance.Name = "lbCreditBalance";
            this.lbCreditBalance.Size = new System.Drawing.Size(59, 12);
            this.lbCreditBalance.TabIndex = 4;
            this.lbCreditBalance.Text = "授信余额:";
            // 
            // tbCreditDueday
            // 
            this.tbCreditDueday.Location = new System.Drawing.Point(95, 43);
            this.tbCreditDueday.Name = "tbCreditDueday";
            this.tbCreditDueday.ReadOnly = true;
            this.tbCreditDueday.Size = new System.Drawing.Size(119, 21);
            this.tbCreditDueday.TabIndex = 3;
            // 
            // lbCoverDueday
            // 
            this.lbCoverDueday.AutoSize = true;
            this.lbCoverDueday.Location = new System.Drawing.Point(6, 46);
            this.lbCoverDueday.Name = "lbCoverDueday";
            this.lbCoverDueday.Size = new System.Drawing.Size(47, 12);
            this.lbCoverDueday.TabIndex = 2;
            this.lbCoverDueday.Text = "到期日:";
            // 
            // tbCreditCover
            // 
            this.tbCreditCover.Location = new System.Drawing.Point(95, 16);
            this.tbCreditCover.Name = "tbCreditCover";
            this.tbCreditCover.ReadOnly = true;
            this.tbCreditCover.Size = new System.Drawing.Size(119, 21);
            this.tbCreditCover.TabIndex = 1;
            // 
            // lbCreditCover
            // 
            this.lbCreditCover.AutoSize = true;
            this.lbCreditCover.Location = new System.Drawing.Point(6, 19);
            this.lbCreditCover.Name = "lbCreditCover";
            this.lbCreditCover.Size = new System.Drawing.Size(83, 12);
            this.lbCreditCover.TabIndex = 0;
            this.lbCreditCover.Text = "信用风险额度:";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.tbHandFee);
            this.gbPrice.Controls.Add(this.lbHandFeeCur);
            this.gbPrice.Controls.Add(this.tbIFPrice);
            this.gbPrice.Controls.Add(this.lbIFPrice);
            this.gbPrice.Controls.Add(this.tbEFPrice);
            this.gbPrice.Controls.Add(this.lbEFPrice);
            this.gbPrice.Controls.Add(this.tbTotalFPrice);
            this.gbPrice.Controls.Add(this.lbTotalFPrice);
            this.gbPrice.Location = new System.Drawing.Point(3, 3);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(208, 130);
            this.gbPrice.TabIndex = 1;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "费率信息";
            // 
            // tbHandFee
            // 
            this.tbHandFee.Location = new System.Drawing.Point(83, 97);
            this.tbHandFee.Name = "tbHandFee";
            this.tbHandFee.ReadOnly = true;
            this.tbHandFee.Size = new System.Drawing.Size(119, 21);
            this.tbHandFee.TabIndex = 7;
            // 
            // lbHandFeeCur
            // 
            this.lbHandFeeCur.AutoSize = true;
            this.lbHandFeeCur.Location = new System.Drawing.Point(6, 100);
            this.lbHandFeeCur.Name = "lbHandFeeCur";
            this.lbHandFeeCur.Size = new System.Drawing.Size(71, 12);
            this.lbHandFeeCur.TabIndex = 6;
            this.lbHandFeeCur.Text = "单据处理费:";
            // 
            // tbIFPrice
            // 
            this.tbIFPrice.Location = new System.Drawing.Point(83, 70);
            this.tbIFPrice.Name = "tbIFPrice";
            this.tbIFPrice.ReadOnly = true;
            this.tbIFPrice.Size = new System.Drawing.Size(119, 21);
            this.tbIFPrice.TabIndex = 5;
            // 
            // lbIFPrice
            // 
            this.lbIFPrice.AutoSize = true;
            this.lbIFPrice.Location = new System.Drawing.Point(6, 73);
            this.lbIFPrice.Name = "lbIFPrice";
            this.lbIFPrice.Size = new System.Drawing.Size(71, 12);
            this.lbIFPrice.TabIndex = 4;
            this.lbIFPrice.Text = "IF手续费率:";
            // 
            // tbEFPrice
            // 
            this.tbEFPrice.Location = new System.Drawing.Point(83, 43);
            this.tbEFPrice.Name = "tbEFPrice";
            this.tbEFPrice.ReadOnly = true;
            this.tbEFPrice.Size = new System.Drawing.Size(119, 21);
            this.tbEFPrice.TabIndex = 3;
            // 
            // lbEFPrice
            // 
            this.lbEFPrice.AutoSize = true;
            this.lbEFPrice.Location = new System.Drawing.Point(6, 46);
            this.lbEFPrice.Name = "lbEFPrice";
            this.lbEFPrice.Size = new System.Drawing.Size(71, 12);
            this.lbEFPrice.TabIndex = 2;
            this.lbEFPrice.Text = "EF手续费率:";
            // 
            // tbTotalFPrice
            // 
            this.tbTotalFPrice.Location = new System.Drawing.Point(83, 16);
            this.tbTotalFPrice.Name = "tbTotalFPrice";
            this.tbTotalFPrice.ReadOnly = true;
            this.tbTotalFPrice.Size = new System.Drawing.Size(119, 21);
            this.tbTotalFPrice.TabIndex = 1;
            // 
            // lbTotalFPrice
            // 
            this.lbTotalFPrice.AutoSize = true;
            this.lbTotalFPrice.Location = new System.Drawing.Point(6, 19);
            this.lbTotalFPrice.Name = "lbTotalFPrice";
            this.lbTotalFPrice.Size = new System.Drawing.Size(71, 12);
            this.lbTotalFPrice.TabIndex = 0;
            this.lbTotalFPrice.Text = "总手续费率:";
            // 
            // gbFinance
            // 
            this.gbFinance.Controls.Add(this.tbFinanceBalance);
            this.gbFinance.Controls.Add(this.lbFinanceBalance);
            this.gbFinance.Controls.Add(this.tbFinanceUnkown);
            this.gbFinance.Controls.Add(this.lbFinanceUnkown);
            this.gbFinance.Controls.Add(this.tbFinanceDueday);
            this.gbFinance.Controls.Add(this.lbFinanceDueday);
            this.gbFinance.Controls.Add(this.tbFinanceLine);
            this.gbFinance.Controls.Add(this.lbFinanceLine);
            this.gbFinance.Location = new System.Drawing.Point(443, 3);
            this.gbFinance.Name = "gbFinance";
            this.gbFinance.Size = new System.Drawing.Size(191, 130);
            this.gbFinance.TabIndex = 2;
            this.gbFinance.TabStop = false;
            this.gbFinance.Text = "融资额度信息";
            // 
            // tbFinanceBalance
            // 
            this.tbFinanceBalance.Location = new System.Drawing.Point(66, 97);
            this.tbFinanceBalance.Name = "tbFinanceBalance";
            this.tbFinanceBalance.ReadOnly = true;
            this.tbFinanceBalance.Size = new System.Drawing.Size(119, 21);
            this.tbFinanceBalance.TabIndex = 7;
            // 
            // lbFinanceBalance
            // 
            this.lbFinanceBalance.AutoSize = true;
            this.lbFinanceBalance.Location = new System.Drawing.Point(6, 100);
            this.lbFinanceBalance.Name = "lbFinanceBalance";
            this.lbFinanceBalance.Size = new System.Drawing.Size(59, 12);
            this.lbFinanceBalance.TabIndex = 6;
            this.lbFinanceBalance.Text = "融资余额:";
            // 
            // tbFinanceUnkown
            // 
            this.tbFinanceUnkown.Location = new System.Drawing.Point(66, 70);
            this.tbFinanceUnkown.Name = "tbFinanceUnkown";
            this.tbFinanceUnkown.ReadOnly = true;
            this.tbFinanceUnkown.Size = new System.Drawing.Size(119, 21);
            this.tbFinanceUnkown.TabIndex = 5;
            // 
            // lbFinanceUnkown
            // 
            this.lbFinanceUnkown.AutoSize = true;
            this.lbFinanceUnkown.Location = new System.Drawing.Point(6, 73);
            this.lbFinanceUnkown.Name = "lbFinanceUnkown";
            this.lbFinanceUnkown.Size = new System.Drawing.Size(59, 12);
            this.lbFinanceUnkown.TabIndex = 4;
            this.lbFinanceUnkown.Text = "剩余额度:";
            // 
            // tbFinanceDueday
            // 
            this.tbFinanceDueday.Location = new System.Drawing.Point(66, 43);
            this.tbFinanceDueday.Name = "tbFinanceDueday";
            this.tbFinanceDueday.ReadOnly = true;
            this.tbFinanceDueday.Size = new System.Drawing.Size(119, 21);
            this.tbFinanceDueday.TabIndex = 3;
            // 
            // lbFinanceDueday
            // 
            this.lbFinanceDueday.AutoSize = true;
            this.lbFinanceDueday.Location = new System.Drawing.Point(6, 46);
            this.lbFinanceDueday.Name = "lbFinanceDueday";
            this.lbFinanceDueday.Size = new System.Drawing.Size(47, 12);
            this.lbFinanceDueday.TabIndex = 2;
            this.lbFinanceDueday.Text = "到期日:";
            // 
            // tbFinanceLine
            // 
            this.tbFinanceLine.Location = new System.Drawing.Point(66, 16);
            this.tbFinanceLine.Name = "tbFinanceLine";
            this.tbFinanceLine.ReadOnly = true;
            this.tbFinanceLine.Size = new System.Drawing.Size(119, 21);
            this.tbFinanceLine.TabIndex = 1;
            // 
            // lbFinanceLine
            // 
            this.lbFinanceLine.AutoSize = true;
            this.lbFinanceLine.Location = new System.Drawing.Point(6, 19);
            this.lbFinanceLine.Name = "lbFinanceLine";
            this.lbFinanceLine.Size = new System.Drawing.Size(59, 12);
            this.lbFinanceLine.TabIndex = 0;
            this.lbFinanceLine.Text = "融资额度:";
            // 
            // ContractOtherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFinance);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gbBuyerCredit);
            this.Name = "ContractOtherInfo";
            this.Size = new System.Drawing.Size(640, 140);
            this.gbBuyerCredit.ResumeLayout(false);
            this.gbBuyerCredit.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbFinance.ResumeLayout(false);
            this.gbFinance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
