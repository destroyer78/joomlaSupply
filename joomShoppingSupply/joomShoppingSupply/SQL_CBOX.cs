using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace joomShoppingSupply
{
    abstract class SQL_CBOX:SQL_Class
    {
        protected DataTable dataFromDB;   // Для данных под comboBox 
        abstract public result getDataFromDB(); // Метод возвращает таблицу с данными
        abstract public DataTable getDataTable(); // Метод должен возвращать DataTable с данными для ComboBox`а
    }
}
