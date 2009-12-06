
using System.Windows.Forms;
namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class QueryUI : DevComponents.DotNetBar.Office2007Form
    {

        public QueryUI(UserControl uc,string title)
        {
            InitializeComponent();
            this.Text = title;
            uc.Dock = DockStyle.Fill;
            this.panelRoot.Controls.Clear();
            this.panelRoot.Controls.Add(uc);
        }
    }
}
