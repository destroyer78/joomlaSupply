using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class cat:SQL_CBOX
    {
        //DataTable dt;
        public cat(connector cn)
        {
            SQL = new MySqlDb(cn);
            sql = "SELECT `category_id` 'id',`name_ru-RU`'name' FROM `ishp_jshopping_categories`";
        }
        public override result getDataFromDB()
        {
            SQL.clearParam();
            dataFromDB = SQL.ExecuteReader(sql);
            if (dataFromDB.Rows.Count == 0) { return new result(5, "Запрос вернул 0 строк"); }
            return new result();
        }
        public override System.Data.DataTable getDataTable()
        {
            return dataFromDB;
        }
    }
}
