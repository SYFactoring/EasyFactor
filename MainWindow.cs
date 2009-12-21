//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr.UserMgr;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.Help.About;
    using CMBC.EasyFactor.ARMgr;

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
            this.CommandStatus = "欢迎使用中国民生银行保理运行系统";
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

        #region Methods (20)

        // Private Methods (20) 

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
        private void ChangeStyle(object sender, EventArgs e)
        {
            string style = cbStyleManager.SelectedItem.ToString();
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
        /// Invoice Assign
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void InvoiceAssign(object sender, EventArgs e)
        {
            ARCaseBasic invoiceAssign = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceAssign);
            this.SetDetailPanel(invoiceAssign);
        }

        private void InvoiceFinance(object sender, EventArgs e)
        {
            ARCaseBasic invoiceFinance = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceFinance);
            this.SetDetailPanel(invoiceFinance);
        }

        private void InvoicePayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoicePayment);
            this.SetDetailPanel(invoicePayment);
        }

        private void MainPage(object sender, EventArgs e)
        {
            this.ClearDetailPanel();
            ribbonDetailPanel.Controls.Add(logoLabel);
        }

        private void MgrCases(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr caseQuery = new CaseMgr.CaseMgr(true);
            this.SetDetailPanel(caseQuery);
        }

        private void MgrCDAs(object sender, EventArgs e)
        {
            CDAMgr CDAMgr = new CDAMgr(true);
            this.SetDetailPanel(CDAMgr);
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

        private void MgrContracts(object sender, EventArgs e)
        {
            ContractMgr contractMgr = new ContractMgr(true);
            this.SetDetailPanel(contractMgr);
        }

        private void MgrCreditCoverNegs(object sender, EventArgs e)
        {
            CreditCoverNegMgr creditCoverNegMgr = new CreditCoverNegMgr(true);
            this.SetDetailPanel(creditCoverNegMgr);
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

        private void NewCDA(object sender, EventArgs e)
        {
            CDADetail cdaDetail = new CDADetail(null, CDADetail.OpCDAType.NEW_CDA);
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
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        private void SetDetailPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonDetailPanel.Controls.Add(uc);
        }

        #endregion Methods
    }
}
