
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Linq;
    using System.Collections.Generic;

    public partial class Department
    {
        public override string ToString()
        {
            return this._DepartmentName;
        }
    }

    public partial class Client
    {
        public string CountryNameCN
        {
            get
            {
                if (_CountryCode != null && !_CountryCode.Trim().Equals(string.Empty))
                {
                    return Country.FindCountryByCode(_CountryCode).CountryNameCN;
                }
                return string.Empty;
            }
        }
    }
    public partial class Currency
    {
        private static Dictionary<string, Currency> _allCurrencies;

        public static Currency FindCurrencyByCode(string currencyCode)
        {
            if (_allCurrencies == null)
            {
                _allCurrencies = new Dictionary<string, Currency>();
                _allCurrencies = App.Current.DbContext.Currencies.ToDictionary(c => c._CurrencyCode);
            }
            return _allCurrencies[currencyCode];
        }

        public string CurrencyFormat
        {
            get
            {
                return _CurrencyCode + " " + _CurrencyName;
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

        private static Dictionary<string, Country> _allCountries;

        public static Country FindCountryByCode(string countryCode)
        {
            if (_allCountries == null)
            {
                _allCountries = new Dictionary<string, Country>();
                _allCountries = App.Current.DbContext.Countries.ToDictionary(c => c._CountryCode);
            }
            if (_allCountries != null && _allCountries.ContainsKey(countryCode))
            {
                return _allCountries[countryCode];
            }
            else
            {
                return new Country() { CountryCode = "", CountryNameCN = "", CountryNameEN = "" };
            }
        }
    }

    public partial class Factor
    {
        public string GroupNameEN
        {
            get
            {
                if (_GroupNo != null && !_GroupNo.Trim().Equals(string.Empty))
                {
                    return FactorGroup.GroupNameEN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string GroupNameCN
        {
            get
            {
                if (_GroupNo != null && !_GroupNo.Trim().Equals(string.Empty))
                {
                    return FactorGroup.GroupNameCN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
