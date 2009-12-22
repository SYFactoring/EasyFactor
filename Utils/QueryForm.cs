
namespace CMBC.EasyFactor.Utils
{
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public partial class QueryForm : DevComponents.DotNetBar.Office2007Form
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userControl"></param>
        /// <param name="title"></param>
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
