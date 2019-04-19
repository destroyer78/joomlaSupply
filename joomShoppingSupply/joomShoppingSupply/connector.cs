using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace joomShoppingSupply
{
    public class connector
    {
        public string user;
        public string password;
        public string connectionString()
        {
            return String.Format("server={0};userid={1};password={2};database=ishop;SslMode=none", ConfigurationManager.AppSettings.Get("SERVER"), user, password);
        }
        public string UserData()
        {
            return "userid=" + user + ";password=" + password + ";";
        }

        public result testConnection()
        {
            MySqlDb mb = new MySqlDb(this);
            return mb.testConnection(this);
        }
    }
}
