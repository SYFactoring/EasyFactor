using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class FactorCreditLineMgr : UserControl
    {
        #region Fields (1)

        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        public FactorCreditLineMgr()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvFactorCreditLines.DataSource = bs;
            this.dgvFactorCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvFactorCreditLines);
        }

        #endregion Constructors

        #region Methods (4)

        // Private Methods (4) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFactorCreditLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFactorCreditLines.CurrentCell == null)
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.bs.List[this.dgvFactorCreditLines.CurrentCell.RowIndex];
            FactorDetail detail = new FactorDetail(creditLine.Factor, FactorDetail.OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFactorCreditLines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.bs.List.Count; i++)
            {
                FactorCreditLine creditLine = (FactorCreditLine)this.bs.List[i];
                if (creditLine.PeriodEnd < DateTime.Now.Date)
                {
                    this.dgvFactorCreditLines["colPeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        private void dgvFactorCreditLines_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                 e.RowBounds.Location.Y,
                 this.dgvFactorCreditLines.RowHeadersWidth - 4,
                 e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.dgvFactorCreditLines.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.dgvFactorCreditLines.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string factorCode = tbFactorCode.Text;
            string factorName = tbFactorName.Text;

            var queryResult = App.Current.DbContext.FactorCreditLines.Where(f => f.Factor.FactorCode.Contains(factorCode) && (f.Factor.CompanyNameCN.Contains(factorName) || f.Factor.CompanyNameEN.Contains(factorName)));
            this.bs.DataSource = queryResult;

        }

        #endregion Methods
    }
}
