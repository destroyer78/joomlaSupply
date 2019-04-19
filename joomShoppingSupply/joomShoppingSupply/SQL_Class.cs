using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace joomShoppingSupply
{
    abstract class SQL_Class
    {
        protected MySqlDb SQL; // Класс соединения с БД. Требует заполненного класса connector
        protected string sql; // Строка для запроса
        //abstract public void getDataFromDB(); // Метод возвращает таблицу с данными
    }
    
}
