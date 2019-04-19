using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace joomShoppingSupply
{
    class supply:SQL_Class
    {
        ulong id=0;
        string supplier="";

        public supply(connector cn)
        {
            SQL = new MySqlDb(cn);
        }
        public void setSupplier(string s){ supplier = s; }
        public ulong getId() { return id; }
        public string getSupplier() { return supplier; }
        public result createSupplyInDB()
            // Создаем поставку в БД
        {
            if (supplier=="") return new result(102,"Не задан поставщик");
            sql = "INSERT INTO supply (supplier) VALUES (@supl)" + Form1.GET_ID;
            SQL.clearParam();
            SQL.addParam("@supl", supplier);
            id = SQL.ExecuteScalar(sql);
            if (id == 0)
            {
                return new result(103, "Ошибка вставки данных в БД");
            }
            return new result(0, "Поставка создана");
        }

        public result addSupplyElementToDB(DataRow dr)
        {
            if (dr == null) return new result(200, "Отсутствуют данные для вставки");
            if (dr.Field<string>("id") == "") return new result(201, "Отсутствует ID товара");
            if (id == 0) return new result(202, "Отсутствует ID поставки");
            sql = "INSERT INTO supply_elements (supply, product, quantity) VALUES (@sup, @prod, @quant)"+Form1.GET_ID;
            SQL.clearParam();
            SQL.addParam("@sup", id.ToString());
            string prodID = dr.Field<string>("id");
            SQL.addParam("@prod", prodID);
            string quant=dr.Field<int>("Количество").ToString();
            SQL.addParam("@quant", quant);
            ulong rsId = SQL.ExecuteScalar(sql);
            if (rsId == 0) return new result(203, "Ошибка вставки данных");
            updateProductQuantity(prodID, quant);   // Обновляем кол-во товара
            return new result(); // Если все ок, то возвращаем 0 - ОК
        }

        private void updateProductQuantity(string prodId, string prodQuantity)
        {
            sql = "UPDATE ishp_jshopping_products SET `product_quantity`=`product_quantity`+@quan WHERE product_id=@pid";
            SQL.clearParam();
            SQL.addParam("@quan", prodQuantity);
            SQL.addParam("@pid", prodId);
            SQL.ExecuteNonQuery(sql);
            
        }
    }
}
