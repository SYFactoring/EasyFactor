//-----------------------------------------------------------------------
// <copyright file="ExchangeMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.ExchangeMgr
{
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
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvExchange.AutoGenerateColumns = false;
            var context = new DBDataContext {ObjectTrackingEnabled = false};
            dgvExchange.DataSource = context.Exchanges;
            ControlUtil.SetDoubleBuffered(dgvExchange);
        }
    }
}