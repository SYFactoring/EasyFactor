//-----------------------------------------------------------------------
// <copyright file="ExchangeMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ExchangeMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ExchangeMgr : UserControl
    {
		#region?Constructors?(1)?

        /// <summary>
        /// Initializes a new instance of the ExchangeMgr class
        /// </summary>
        public ExchangeMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvExchange.AutoGenerateColumns = false;
            DBDataContext context = new DBDataContext();
            context.ObjectTrackingEnabled = false;
            this.dgvExchange.DataSource = context.Exchanges;
            ControlUtil.SetDoubleBuffered(this.dgvExchange);
        }

		#endregion?Constructors?
    }
}
