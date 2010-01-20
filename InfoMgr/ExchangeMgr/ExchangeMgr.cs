//-----------------------------------------------------------------------
// <copyright file="ExchangeMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ExchangeMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ExchangeMgr : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the ExchangeMgr class
        /// </summary>
        public ExchangeMgr()
        {
            this.InitializeComponent();
            this.dgvExchange.AutoGenerateColumns = false;
            this.dgvExchange.DataSource = App.Current.DbContext.Exchanges;
            ControlUtil.SetDoubleBuffered(this.dgvExchange);
        }
    }
}
