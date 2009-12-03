//-----------------------------------------------------------------------
// <copyright file="ContractBasicInfo.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.ContractInfo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.CaseMgr.ContractMgr;

    /// <summary>
    /// 
    /// </summary>
    public delegate void ContractChangedHandler();

    /// <summary>
    /// Contract Basic Info
    /// </summary>
    public partial class ContractBasicInfo : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Contract contract = null;

        /// <summary>
        /// Initializes a new instance of the ContractBasicInfo class
        /// </summary>
        public ContractBasicInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public event ContractChangedHandler ContractChanged;

        /// <summary>
        /// Gets or sets contract
        /// </summary>
        public Contract Contract
        {
            get
            {
                return this.contract;
            }

            set
            {
                this.contract = value;
                if (this.contract != null)
                {
                    // set seller basic information
                    this.tbSellerName.Text = this.contract.SellerClient.ClientNameCN;
                    this.tbSellerFactorName.Text = this.tbSellerFactorNo.Text = string.Empty;
                    if (this.contract.SellerBranchID != null && this.contract.SellerBranchID != string.Empty)
                    {
                        this.tbSellerFactorName.Text = this.contract.SellerBranch.BranchName;
                    }
                    else if (this.contract.SellerFactorNo != null && this.contract.SellerFactorNo != string.Empty)
                    {
                        this.tbSellerFactorNo.Text = this.contract.SellerFactorNo;
                        this.tbSellerFactorName.Text = this.contract.SellerFactor.CompanyName;
                    }

                    // set buyer basic information
                    this.tbBuyerName.Text = this.contract.BuyerClient.ClientNameCN;
                    this.tbBuyerFactorName.Text = this.tbBuyerFactorNo.Text = string.Empty;
                    if (this.contract.BuyerBranchID != null && this.contract.BuyerBranchID != string.Empty)
                    {
                        this.tbBuyerFactorName.Text = this.contract.BuyerBranch.BranchName;
                    }
                    else if (this.contract.BuyerFactorNo != null && this.contract.BuyerFactorNo != string.Empty)
                    {
                        this.tbBuyerFactorNo.Text = this.contract.BuyerFactorNo;
                        this.tbBuyerFactorName.Text = this.contract.BuyerFactor.CompanyName;
                    }

                    // set business basic information
                    this.tbInvoiceCurrency.Text = this.contract.InvoiceCurrency;
                    this.tbBizType.Text = this.contract.BizType;
                }
                else
                {
                    this.tbSellerName.Text = this.tbSellerFactorNo.Text = this.tbSellerFactorName.Text = string.Empty;
                    this.tbBuyerName.Text = this.tbBuyerFactorNo.Text = this.tbBuyerFactorName.Text = string.Empty;
                    this.tbInvoiceCurrency.Text = this.tbBizType.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectContract(object sender, EventArgs e)
        {
            Form selectForm = new Form();
            ContractMgrUI contractPanel = new ContractMgrUI(false, selectForm);
            contractPanel.Dock = DockStyle.Fill;
            selectForm.Size = new Size(800, 600);
            selectForm.StartPosition = FormStartPosition.CenterParent;
            selectForm.Controls.Add(contractPanel);
            if (selectForm.ShowDialog(App.Current.MainWindow) == DialogResult.Yes)
            {
                if (contractPanel.Selected != this.Contract)
                {
                    this.Contract = contractPanel.Selected;
                    if (this.ContractChanged != null)
                    {
                        this.ContractChanged();
                    }
                }
            }
        }
    }
}
