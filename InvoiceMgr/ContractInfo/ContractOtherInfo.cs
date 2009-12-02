//-----------------------------------------------------------------------
// <copyright file="ContractOtherInfo.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.ContractInfo
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Contract other info
    /// </summary>
    public partial class ContractOtherInfo : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private ContractBasicInfo contractBasicInfo;

        /// <summary>
        /// 
        /// </summary>
        public ContractOtherInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contractBasicInfo"></param>
        public void SetContractBasicInfo(ContractBasicInfo contractBasicInfo)
        {
            this.contractBasicInfo = contractBasicInfo;
            this.contractBasicInfo.ContractChanged += new ContractChangedHandler(this.ContractChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ContractChanged()
        {
            Contract c = this.contractBasicInfo.Contract;
            if (c != null)
            {
                // set price information
                this.tbTotalFPrice.Text = c.Price.ToString();
                this.tbIFPrice.Text = c.IFPrice.ToString();
                this.tbEFPrice.Text = c.EFPrice.ToString();
                this.tbHandFee.Text = c.HandFee.ToString();

                // set credit information
                this.tbCreditCover.Text = c.CreditCover.ToString();
                this.tbCreditDueday.Text = "不明确";
                this.tbCreditBalance.Text = "由本次转让金额确定";
                this.tbReceivableBalance.Text = "没有给定计算方式";

                // set finance information
                this.tbFinanceLine.Text = c.FinanceLine.ToString();
                this.tbFinanceDueday.Text = "不明确";
                this.tbFinanceUnkown.Text = "不知道这个是什么意思";
                this.tbFinanceBalance.Text = "没有给定计算方式";
            }
            else
            {
                this.tbTotalFPrice.Text = this.tbIFPrice.Text = this.tbEFPrice.Text = this.tbHandFee.Text = string.Empty;
                this.tbCreditCover.Text = this.tbCreditDueday.Text = this.tbCreditBalance.Text = this.tbReceivableBalance.Text = string.Empty;
                this.tbFinanceLine.Text = this.tbFinanceDueday.Text = this.tbFinanceBalance.Text = this.tbFinanceUnkown.Text = string.Empty;
            }
        }
    }
}
