using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.CaseMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr;
    using CMBC.EasyFactor.Utils;

    public partial class CDADetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpCDAType opCDAType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// Operation Type 
        /// </summary>
        public enum OpCDAType
        {
            /// <summary>
            /// New CDA
            /// </summary>
            NEW_CDA,

            /// <summary>
            /// Update CDA
            /// </summary>
            UPDATE_CDA,

            /// <summary>
            /// Detail CDA
            /// </summary>
            DETAIL_CDA
        }

        #endregion Enums

        #region Constructors (1)

        public CDADetail(CDA cda, OpCDAType opCDAType)
        {
            this.InitializeComponent();

            this.creditCoverCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.creditCoverCurrComboBox.DisplayMember = "CurrencyCode";
            this.creditCoverCurrComboBox.ValueMember = "CurrencyCode";
            this.creditCoverCurrComboBox.SelectedIndex = -1;

            this.financeLineCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.financeLineCurrComboBox.DisplayMember = "CurrencyCode";
            this.financeLineCurrComboBox.ValueMember = "CurrencyCode";
            this.financeLineCurrComboBox.SelectedIndex = -1;

            this.handFeeCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.handFeeCurrComboBox.DisplayMember = "CurrencyCode";
            this.handFeeCurrComboBox.ValueMember = "CurrencyCode";
            this.handFeeCurrComboBox.SelectedIndex = -1;

            this.assignTypeComboBox.DataSource = new string[] {"全部","部分" };
            this.commissionTypeComboBox.DataSource = new string[] {"01","02","其他"};
            this.cDAStatusComboBox.DataSource = new string[] { "未审核", "已审核未下发", "已下发未签回", "已签回","已生效","已过期" };

            this.opCDAType = opCDAType;
            if (opCDAType == OpCDAType.NEW_CDA)
            {
                cda = new CDA();
                cda.PUGProportion = 1;
                cda.PUGPeriod = 90;
                cda.ReassignGracePeriod = 60;
                cda.IsNotice = false;
                cda.IsRecoarse = false;
                cda.IsCreditCoverRevolving = false;
                this.CDABindingSource.DataSource = cda;
            }
            else
            {
                this.CDABindingSource.DataSource = cda;
                string[] methods = cda.NoticeMethod.Split(',');
                foreach(string method in methods)
                {
                    if ("Fax".Equals(method))
                    {
                        this.cbNoticeMethodFax.Checked = true;
                    }
                    else if ("Email".Equals(method))
                    {
                        this.cbNoticeMethodEmail.Checked = true;
                    }
                }
                cda.Backup();
            }

            this.UpdateCDAControlStatus();
        }

        #endregion Constructors

        #region Methods (7)

        // Private Methods (7) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CDADetail_Leave(object sender, EventArgs e)
        {
            this.CloseCDA(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (this.opCDAType == OpCDAType.UPDATE_CDA)
            {
                cda.Restore();
            }

            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (this.cbNoticeMethodEmail.Checked == true)
            {
                cda.NoticeMethod = "Email";
            }
            if (this.cbNoticeMethodFax.Checked == true)
            {
                if(cda.NoticeMethod==null)
                {
                    cda.NoticeMethod="Fax";
                }else
                {
                    cda.NoticeMethod="Email,Fax";
                }
            }

            if (cda.CDAID == 0)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.CDAs.InsertOnSubmit(cda);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                    this.opCDAType = OpCDAType.UPDATE_CDA;
                }
            }
            else
            {
                bool isUpdateOK = true;
                if (cda.CDAID == 0)
                {
                    return;
                }

                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCase(object sender, EventArgs e)
        {
            CaseMgr caseMgr = new CaseMgr(false);
            QueryForm queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                CDA cda = (CDA)this.CDABindingSource.DataSource;
                cda.Case = curCase;
                this.contractCodeTextBox.Text = curCase.SellerClient.Contracts.SingleOrDefault(c => c.ContractStatus == "已生效").ContractCode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.CDAID == 0)
            {
                MessageBox.Show("请首先选择一个额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.opCDAType = OpCDAType.UPDATE_CDA;
            this.UpdateCDAControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateCDAControlStatus()
        {
            if (this.opCDAType == OpCDAType.DETAIL_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opCDAType == OpCDAType.NEW_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.cbIsNotice.Enabled = true;
                this.cbIsRecoarse.Enabled = true;
                this.assignTypeComboBox.Enabled = true;
            }
            else if (this.opCDAType == OpCDAType.UPDATE_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.cbIsNotice.Enabled = true;
                this.cbIsRecoarse.Enabled = true;
                this.assignTypeComboBox.Enabled = true;
            }
        }

        #endregion Methods
    }
}
