using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace joomShoppingSupply
{
    class supplier: SQL_Class
    {
        private ulong id=0;
        private string name="";    // Max 100
        private string tel = "";     // Max 30
        private string email = "";   // Max 70
        private string ogrn = "";    // Max 13
        private string inn = "";     // Max 13
        connector cn;

        DataTable dtLikeSearch;

        //public override void getDataFromDB() { }
        public supplier(connector _cn,string _name, string _ogrn, string _inn, string _tel = "", string _email = "")
        {
            setName(_name);
            setOGRN(_ogrn);
            setINN(_inn);
            setTel(_tel);
            setEmail(_email);
            cn = _cn;
            SQL=new MySqlDb(cn);
        }
        public supplier(connector cn) 
        {
            SQL=new MySqlDb(cn);
        }
        
        public result create(){
            if (id != 0)
            {
                return new result(100, "Поставщик уже занесен");
            }
            sql = "INSERT INTO suppliers (id,name,ogrn,inn,tel,email) VALUES (null,@name, @ogrn, @inn, @tel ,@email)"+Form1.GET_ID;
            SQL = new MySqlDb(cn);
            SQL.clearParam();
            SQL.addParam("@name", name);
            SQL.addParam("@ogrn", ogrn);
            SQL.addParam("@inn", inn);
            SQL.addParam("@tel", tel);
            SQL.addParam("@email", email);
            result res = new result();
            id= (SQL.ExecuteScalar(sql));
            return new result();
        }
        public ulong getId()
        {
            return id;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }
        public string getEmail()
        {
            return email;
        }

        public void setTel(string _tel)
        {
            tel = _tel;
        }
        public string getTel()
        {
            return tel;
        }

        public void setINN(string _inn)
        {
            inn = _inn;
        }
        public string getINN()
        {
            return inn;
        }

        public void setOGRN(string _ogrn)
        {
            ogrn = _ogrn;
        }
        public string getOGRN()
        {
            return ogrn;
        }

        public result searchByOGRN(string _ogrn)
        {
            string query = "ogrn='" + _ogrn + "'";
            return search(query);
        }
        public result searchByINN(string _inn)
        {
            string query = "inn='" + _inn + "'";
            return search(query);
        }
        private result search(string q)
        {
            sql = "SELECT * FROM suppliers WHERE " + q;
            DataTable dt = SQL.ExecuteReader(sql);
            if (dt.Rows.Count != 1) return new result(100, "Поставщик не найден");
            
            id=(ulong)dt.Rows[0].Field<int>("id");
            name = dt.Rows[0].Field<string>("name");
            ogrn=dt.Rows[0].Field<string>("ogrn");
            inn=dt.Rows[0].Field<string>("inn");
            tel = dt.Rows[0].Field<string>("tel");
            email = dt.Rows[0].Field<string>("email");

            return new result(0,"Поставщик найден");
        }

        public void searchByLikeName(string likeName)
        {
            sql = "SELECT `id`,`name` 'Наименование поставщика',`ogrn` 'ОГРН',`inn` 'ИНН',`tel` 'Телефон',`email` 'e-mail' FROM `suppliers` WHERE `name` LIKE '" + likeName + "'";
            SQL.clearParam();
            dtLikeSearch = SQL.ExecuteReader(sql);
            getClickID gid = new getClickID("Поиск поставщика", dtLikeSearch,new string[] {}, "id");
            gid.ShowDialog();
            string a = gid.getID();
            if (a != "") { search("id='" + a+"'"); }
        }
    }
}
