using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class InvoiceFinance : UserControl
    {
        #region Constructors (1)

        public InvoiceFinance()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods (1)

        // Private Methods (1) 

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        #endregion Methods
    }
}
