
namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Currency
    {
        public string CurrencyFormat
        {
            get
            {
                return _CurrencyCode + "    " + _CurrencyName;
            }
        }
    }

    public partial class Country
    {
        public string CountryFormatEN
        {
            get
            {
                return _CountryCode + " " + _CountryNameEN;
            }
        }

        public string CountryFormatCN
        {
            get
            {
                return _CountryCode + " " + _CountryNameCN;
            }
        }
    }
}
