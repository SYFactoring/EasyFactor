
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using System.Reflection;

    public class BaseObject
    {
        #region Fields (1)

        private List<object> _status;

        #endregion Fields

        #region Methods (2)

        // Public Methods (2) 

        public void Backup()
        {
            _status = new List<object>();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (p.CanWrite && p.PropertyType.IsPrimitive)
                {
                    var value = p.GetValue(this, null);
                    _status.Add(value);
                }
            }
        }

        public void Restore()
        {
            if (_status != null)
            {
                PropertyInfo[] props = this.GetType().GetProperties();
                int i = 0;
                foreach (PropertyInfo p in props)
                {
                    if (p.CanWrite && p.PropertyType.IsPrimitive)
                    {
                        var value = _status[i++];
                        p.SetValue(this, value, null);
                    }
                }
            }
        }

        #endregion Methods
    }

    public partial class Client : BaseObject
    {

    }

    public partial class ClientCreditLine : BaseObject
    {

    }

    public partial class Contract : BaseObject
    {

    }

    public partial class Factor : BaseObject
    {

    }

    public partial class FactorCreditLine : BaseObject
    {

    }

    public partial class User : BaseObject
    {

    }

    public partial class Case : BaseObject
    {

    }

    public partial class CreditCoverNegotiation : BaseObject
    {

    }

    public partial class CDA : BaseObject
    {

    }
}
