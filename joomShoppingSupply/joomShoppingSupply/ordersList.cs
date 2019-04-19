using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class ordersList:SQL_Class
    {
        DataTable dt;
        public ordersList(connector cn)
        {
            SQL = new MySqlDb(cn);
        }
        public result getOrdersList()
            // Получаем список заказов
        {
                // Выбираем заказы со статусами:
                // 2 - Подтвержден
                // 5 - Сборка
                // 6 - Собран
            sql = "SELECT `order_id` 'ID',`order_number` 'Номер заказа',`order_status`,st.`name_ru-RU` AS 'Статус' ,`order_date` 'От'  FROM `ishp_jshopping_orders`,`ishp_jshopping_order_status` st WHERE st.status_id = order_status AND `order_status`IN (2,5,6)";
            SQL.clearParam();
            dt = SQL.ExecuteReader(sql);
            return new result(0,"Список заказов обновлен");
        }
        public DataTable getDataTable() { return dt; }
    }
}
