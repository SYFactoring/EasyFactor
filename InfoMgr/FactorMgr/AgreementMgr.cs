using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.DB.dbml;
using System.Drawing;
using System.Linq;
using System;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class AgreementMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        public AgreementMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvAgreements.DataSource = _bs;
            dgvAgreements.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvAgreements);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAgreementsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgreements.CurrentCell == null)
            {
                return;
            }

            var agreement = (Agreement)_bs.List[dgvAgreements.CurrentCell.RowIndex];
            var detail = new FactorDetail(agreement,
                                          FactorDetail.OpAgreementType.DETAIL_AGREEMENT);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAgreementsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvAgreements.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvAgreements.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvAgreements.RowHeadersDefaultCellStyle.ForeColor,
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

            var context = new DBDataContext();

            IQueryable<Agreement> queryResult =
                context.Agreements.Where(
                    a =>
                    a.Factor.FactorCode.Contains(factorCode) &&
                    (a.Factor.CompanyNameCN.Contains(factorName) || a.Factor.CompanyNameEN.Contains(factorName)));
            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
