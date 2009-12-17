﻿
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

        public static Department DefaultDepartment()
        {
            return new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" };
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

        public override string ToString()
        {
            if (_ClientNameCN != null)
            {
                return _ClientNameCN;
            }
            else
            {
                return _ClientNameEN_1;
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
                if ("AA".Equals(_CurrencyCode))
                {
                    return "All";
                }
                else
                {
                    return _CurrencyCode + " " + _CurrencyName;
                }
            }
        }

        public static Currency DefaultCurrency()
        {
            return new Currency() { CurrencyCode = "AA", CurrencyName = "All" };
        }
    }

    public partial class Country
    {

        public string CountryFormatEN
        {
            get
            {
                if ("AA".Equals(_CountryCode))
                {
                    return "All";
                }
                else
                {
                    return _CountryCode + " " + _CountryNameEN;
                }
            }
        }

        public string CountryFormatCN
        {
            get
            {
                if ("AA".Equals(_CountryCode))
                {
                    return "全部";
                }
                else
                {
                    return _CountryCode + " " + _CountryNameCN;
                }
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

        public static Country DefaultCountry()
        {
            return new Country() { CountryCode = "AA", CountryNameCN = "全部", CountryNameEN = "All" };
        }
    }

    public partial class Factor
    {
        public override string ToString()
        {
            if (_CompanyNameCN != null)
            {
                return _CompanyNameCN;
            }
            else
            {
                return _CompanyNameEN;
            }
        }

        public static readonly string CMBC_CODE = "CN01300";

        public static Factor FindFactorByCode(string code)
        {
            return App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == code);
        }

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
