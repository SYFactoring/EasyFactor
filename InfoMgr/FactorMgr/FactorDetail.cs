using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
        public FactorDetail()
        {
            InitializeComponent();
        }

        public FactorDetail(Factor factor, bool isEditable)
        {
            InitializeComponent();
        }

        private void FactorDetail_Load(object sender, System.EventArgs e)
        {
            this.countryNameComboBox.DataSource = App.Current.DbContext.Countries;
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
        }

    }
}
