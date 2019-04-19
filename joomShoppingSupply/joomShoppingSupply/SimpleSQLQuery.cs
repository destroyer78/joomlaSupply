using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class SimpleSQLQuery:SQL_Class
    {
        DataTable dt;
        public SimpleSQLQuery(connector cn)
        {
            SQL = new MySqlDb(cn);
        }
        public void runQuery(string _sql)
        {
            sql = _sql;
            dt = SQL.ExecuteReader(sql);
        }
        public void addP(string name, string value)
        {
            SQL.addParam(name, value);
        }
        public void clearP() { SQL.clearParam(); }
        public DataTable getData() { return dt; }
    }
}
