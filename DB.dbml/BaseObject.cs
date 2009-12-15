
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using System.Reflection;

    public class BaseObject
    {
        private List<object> _status;

        public void Backup()
        {
            _status = new List<object>();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (p.CanWrite)
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
                    if (p.CanWrite)
                    {
                        var value = _status[i++];
                        p.SetValue(this, value, null);
                    }
                }
            }
        }
    }

    public partial class Client : BaseObject
    {
    }

    public partial class ClientCreditLine : BaseObject
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
}
