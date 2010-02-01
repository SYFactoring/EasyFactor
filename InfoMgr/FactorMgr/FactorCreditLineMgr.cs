//-----------------------------------------------------------------------
// <copyright file="FactorCreditLineMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class FactorCreditLineMgr : UserControl
    {
        #region Fields (1)

        private BindingSource bs;

        private DBDataContext context;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the FactorCreditLineMgr class
        /// </summary>
        public FactorCreditLineMgr()
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvFactorCreditLines.DataSource = this.bs;
            this.dgvFactorCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvFactorCreditLines);

            this.context = new DBDataContext();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFactorCreditLines_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvFactorCreditLines.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvFactorCreditLines.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvFactorCreditLines.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string factorCode = this.tbFactorCode.Text;
            string factorName = this.tbFactorName.Text;

            var queryResult = context.FactorCreditLines.Where(f => f.Factor.FactorCode.Contains(factorCode) && (f.Factor.CompanyNameCN.Contains(factorName) || f.Factor.CompanyNameEN.Contains(factorName)));
            this.bs.DataSource = queryResult;
        }

        #endregion Methods
    }
}
