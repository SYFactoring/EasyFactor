
using System.Windows.Forms;
namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class QueryForm : DevComponents.DotNetBar.Office2007Form
    {

        public QueryForm(UserControl userControl,string title)
        {
            InitializeComponent();
            this.Text = title;
            userControl.Dock = DockStyle.Fill;
            this.panelRoot.Controls.Clear();
            this.panelRoot.Controls.Add(userControl);
        }
    }
}
