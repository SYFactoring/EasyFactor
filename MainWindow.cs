//-----------------------------------------------------------------------
// <copyright file="MainWindowII.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.InvoiceMgr.InvoiceAssign;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.UserMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;

    /// <summary>
    /// Main Window Form
    /// </summary>
    public partial class MainWindow : DevComponents.DotNetBar.Office2007RibbonForm
    {

        /// <summary>
        /// Initializes a new instance of the MainWindowII class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.UserStatus = App.Current.CurUser.UserName + "\t " + App.Current.CurUser.Role;
            this.CommandStatus = "欢迎使用中国民生银行保理运行系统";
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
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        private void setDetailPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonDetailPanel.Controls.Add(uc);
        }

        /// <summary>
        /// Invoice Assign
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void InvoiceAssign(object sender, EventArgs e)
        {
            InvoiceAssignUI invoiceAssignUI = new InvoiceAssignUI();
            setDetailPanel(invoiceAssignUI);
        }

        /// <summary>
        /// Client Management
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void ClientMgr(object sender, EventArgs e)
        {
            ClientMgrUI clientMgrUI = new ClientMgrUI(true);
            setDetailPanel(clientMgrUI);
        }

        private void UserMgr(object sender, EventArgs e)
        {
            UserMgrUI userMgrUI = new UserMgrUI(true);
            setDetailPanel(userMgrUI);
        }

        private void FactorMgr(object sender, EventArgs e)
        {
            FactorMgrUI factorMgrUI = new FactorMgrUI(true);
            setDetailPanel(factorMgrUI);
        }
    }
}
