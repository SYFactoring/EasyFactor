using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Factor : BaseObject
    {
        #region Fields (2)

        private Dictionary<string, string> _dict;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string CMBC_CODE = "CN01300";

        #endregion Fields

        #region Properties (4)

        //public string CreditLine
        //{
        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        var creditLines = this.FactorCreditLines.Where(creditline => creditline.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY);
        //        foreach (FactorCreditLine creditLine in creditLines)
        //        {
        //            sb.Append(creditLine.CreditLineCurrency).Append(" ").Append(creditLine.CreditLine).Append(Environment.NewLine);
        //        }
        //        return sb.ToString();
        //    }
        //}

        //public string DueDate
        //{
        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        var creditLines = this.FactorCreditLines.Where(creditline => creditline.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY);
        //        foreach (FactorCreditLine creditLine in creditLines)
        //        {
        //            sb.Append(creditLine.PeriodEnd).Append(Environment.NewLine);
        //        }
        //        return sb.ToString();
        //    }
        //}

        //public string CreditLineOutstanding
        //{
        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        var creditLines = this.FactorCreditLines.Where(creditline => creditline.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY);
        //        foreach (FactorCreditLine creditLine in creditLines)
        //        {
        //            sb.Append(creditLine.PeriodEnd).Append(Environment.NewLine);
        //        }
        //        return sb.ToString();
        //    }
        //}

        public FactorCreditLine CreditLine
        {
            get
            {
                return this.FactorCreditLines.SingleOrDefault(f => f.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double CreditLineOutstanding
        {
            get
            {
                FactorCreditLine creditLine = CreditLine;
                if (creditLine == null)
                {
                    return 0;
                }
                return creditLine.CreditLine - GetAssignOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double GetAssignOutstanding(string currency)
        {
            double result = 0;
            foreach (Case curCase in this.BuyerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
            {
                foreach (CDA cda in curCase.CDAs.Where(c => c.CDAStatus == ConstStr.CDA.SIGNED))
                {
                    double cdaAssignOutstanding = cda.GetAssignOutstanding(currency);
                    result += cdaAssignOutstanding;
                }
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        #endregion Properties

        #region Methods (5)

        // Public Methods (4) 

        public void BeginMonitor()
        {
            _dict = new Dictionary<string, string>();
            this.Backup();
            this.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Factor_PropertyChanged);
        }

        public string EndMonitor()
        {
            if (_dict != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string value in _dict.Values)
                {
                    sb.Append(value).Append(Environment.NewLine);
                }
                this.PropertyChanged -= new System.ComponentModel.PropertyChangedEventHandler(Factor_PropertyChanged);
                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Factor FindFactorByCode(string code)
        {
            return App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == code);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_CompanyNameCN != null && !_CompanyNameCN.Equals(string.Empty))
            {
                return _CompanyNameCN;
            }
            else
            {
                return _CompanyNameEN;
            }
        }
        // Private Methods (1) 

        void Factor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _dict[e.PropertyName] = String.Format("{0} : {1}\n", e.PropertyName, this.GetType().GetProperty(e.PropertyName).GetValue(this, null));
        }



        #endregion Methods
    }

}
