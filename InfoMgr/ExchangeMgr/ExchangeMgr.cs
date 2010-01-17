using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.ExchangeMgr
{
    public partial class ExchangeMgr : UserControl
    {
        public ExchangeMgr()
        {
            InitializeComponent();
            this.dgvExchange.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvExchange);
            this.dgvExchange.DataSource = App.Current.DbContext.Exchanges;
        }
    }
}
