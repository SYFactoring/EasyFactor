//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.Help.About;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr.UserMgr;
    using CMBC.EasyFactor.Report;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Main Window Form
    /// </summary>
    public partial class MainWindow : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the MainWindow class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
            this.CommandStatus = "欢迎使用中国民生银行保理运营系统";
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Sets command status
        /// </summary>
        public string CommandStatus
        {
            set
            {
                this.lblCommandStatus.Text = value;
            }
        }

        /// <summary>
        /// Sets user status
        /// </summary>
        public string UserStatus
        {
            set
            {
                this.lblCurrentUser.Text = value;
            }
        }

        #endregion Properties

        #region Methods (41)

        // Private Methods (41) 

        private void About(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARPaymentReport(object sender, EventArgs e)
        {
            ReportMgr assignMgr = new ReportMgr(ReportMgr.OpReportType.REPORT_AR);
            this.SetDetailPanel(assignMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeStyle(object sender, EventArgs e)
        {
            string style = cbStyleManager.Text;
            if ("Office2007Blue".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            }
            else if ("Office2007Silver".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            }
            else if ("Office2007Black".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            }
            else if ("Office2007VistaGlass".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            }
            else if ("Office2010Silver".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            }
            else if ("Windows7Blue".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ClearDetailPanel()
        {
            this.ribbonDetailPanel.Controls.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinanceReport(object sender, EventArgs e)
        {
            ReportMgr assignMgr = new ReportMgr(ReportMgr.OpReportType.REPORT_FINANCE);
            this.SetDetailPanel(assignMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE);
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssign(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCases(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CASES);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientCreditLine(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_CREDITLINE);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClients(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportContractAndCDA(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CONTRACT_CDA);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCreditCover(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CREDITCOVER);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDepartments(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_DEPARTMENTS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactorCreditLine(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS_CREDITLINE);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactors(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinance(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportInvoices(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN_FINANCE_PAYMENT);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportUsers(object sender, EventArgs e)
        {
            if (validateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_USERS);
                importForm.Show();
            }
        }

        /// <summary>
        /// Invoice Assign
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void InvoiceAssign(object sender, EventArgs e)
        {
            ARCaseBasic invoiceAssign = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceAssign);
            this.SetDetailPanel(invoiceAssign);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceBuyerPayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceBuyerPayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceFinance(object sender, EventArgs e)
        {
            ARCaseBasic invoiceFinance = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceFinance);
            this.SetDetailPanel(invoiceFinance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceGuaranteePayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceGuaranteePayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceIndirectPayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceIndirectPayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerPayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceSellerPayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage(object sender, EventArgs e)
        {
            this.ClearDetailPanel();
            ribbonDetailPanel.Controls.Add(logoLabel);
        }

        /// <summary>
        /// Client Management
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void MgrClients(object sender, EventArgs e)
        {
            ClientMgr clientMgrUI = new ClientMgr(true);
            this.SetDetailPanel(clientMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrDepartments(object sender, EventArgs e)
        {
            DepartmentMgr departmentMgrUI = new DepartmentMgr(true);
            this.SetDetailPanel(departmentMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrFactors(object sender, EventArgs e)
        {
            FactorMgr factorMgrUI = new FactorMgr(true);
            this.SetDetailPanel(factorMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrUsers(object sender, EventArgs e)
        {
            UserMgr userMgrUI = new UserMgr(true);
            this.SetDetailPanel(userMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCase(object sender, EventArgs e)
        {
            this.ClearDetailPanel();
            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            CDADetail cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClient(object sender, EventArgs e)
        {
            ClientDetail clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactor(object sender, EventArgs e)
        {
            FactorDetail factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr caseQuery = new CaseMgr.CaseMgr(true);
            this.SetDetailPanel(caseQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDA(object sender, EventArgs e)
        {
            CDAMgr CDAMgr = new CDAMgr(true);
            this.SetDetailPanel(CDAMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContract(object sender, EventArgs e)
        {
            ContractMgr contractMgr = new ContractMgr(true);
            this.SetDetailPanel(contractMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditCoverNegs(object sender, EventArgs e)
        {
            CreditCoverNegMgr creditCoverNegMgr = new CreditCoverNegMgr(true);
            this.SetDetailPanel(creditCoverNegMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoice(object sender, EventArgs e)
        {
            InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.INVOICE_QUERY);
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryOverDueDays(object sender, EventArgs e)
        {
            OverDueMgr invoiceMgr = new OverDueMgr();
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        private void SetDetailPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonDetailPanel.Controls.Add(uc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool validateRole()
        {
            if (App.Current.CurUser.Role == "管理员")
            {
                return true;
            }
            else
            {
                MessageBox.Show("只有管理员可以执行此操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        #endregion Methods
    }
}