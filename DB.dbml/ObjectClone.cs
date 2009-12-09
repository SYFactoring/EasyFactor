
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Reflection;

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
        public void Copy(Client fromClient)
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                var oldValue = p.GetValue(fromClient, null);
                var newValue = p.GetValue(this, null);
                
                if ((oldValue != null && oldValue.Equals(newValue)) || oldValue == newValue)
                {
                    continue;
                }
                else if (oldValue.ToString().Contains("Entity"))
                {
                    continue;
                }
                else
                {
                    p.SetValue(this, p.GetValue(fromClient, null), null);
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