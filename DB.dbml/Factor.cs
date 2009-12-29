using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Factor : BaseObject
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        public static readonly string CMBC_CODE = "CN01300";

        #endregion Fields

        #region Properties (2)

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

        #region Methods (2)

        // Public Methods (2) 

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

        private Dictionary<string, string> _dict;

        public void BeginMonitor()
        {
            _dict = new Dictionary<string, string>();
            this.Backup();
            this.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Factor_PropertyChanged);
        }

        void Factor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _dict[e.PropertyName] = String.Format("{0} : {1}\n", e.PropertyName, this.GetType().GetProperty(e.PropertyName).GetValue(this, null));
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
        #endregion Methods
    }

}
