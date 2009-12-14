
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Reflection;
    using System.Collections.Generic;

    public partial class User
    {
        public void Copy(User old)
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                p.SetValue(this, p.GetValue(old, null), null);
            }
        }
    }

    public partial class Client
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

    public partial class Contract
    {
        public void Copy(Contract old)
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                p.SetValue(this, p.GetValue(old, null), null);
            }
        }
    }

    public partial class Factor
    {
        public void Copy(Factor old)
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                p.SetValue(this, p.GetValue(old, null), null);
            }
        }
    }
}