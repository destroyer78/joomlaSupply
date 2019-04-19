using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace joomShoppingSupply
{
    class elementSupply:SQL_Class
    {
        string id="";
        string ean;
        string manufacturerCode = "";
        string name;
        int quantity=0;

        public elementSupply(connector cn)
        {
            SQL = new MySqlDb(cn);
        }
        public result searchByEan(string _ean)
        {
            sql = "SELECT `product_id`,`product_ean`,`manufacturer_code`,`name_ru-RU` FROM `ishp_jshopping_products` WHERE `product_ean`= @ean";
            SQL.clearParam();
            SQL.addParam("@ean", _ean);
            DataTable dt = SQL.ExecuteReader(sql);
            if (dt.Rows.Count == 0)
            {
                return new result(101, "Товар не найден");
            }
            if (dt.Rows.Count > 1)
            {
                return new result(102, "Найдено более одного продукта. Сообщите об этом администратору");
            }
            id = dt.Rows[0].Field<int>("product_id").ToString();
            ean = dt.Rows[0].Field<string>("product_ean"); ;
            manufacturerCode = dt.Rows[0].Field<string>("manufacturer_code");
            name = dt.Rows[0].Field<string>("name_ru-RU");
            return new result(); // Код 0 Сообщение "ОК"


        }
        public string getId() { return id; }
        public string getEan() { return ean; }
        public string getManfacturerCode() { return manufacturerCode; }
        public string getName() { return name; }
        public int getQuantity() { return quantity; }
        public void setQuantity(int _q)
        {
            if (_q < 0) { quantity = 0; } else { quantity = _q; }

        }
    }
}
