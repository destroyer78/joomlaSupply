using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;


namespace joomShoppingSupply
{

    class MySqlDb
    {
        DataBaseConnection DBconn;   // Инициализируем класс для работы с БД. 
        DbConnection DBcnn;
        bool error = false;
        
        private void createConnect(connector cn)
        {
            DBconn = new DataBaseConnection(Form1.DB_CON_NAME); // Создаем класс соединения поставщика соединения читаем с файла App.config 

            DBcnn = DBconn.GetDatabaseConnection(cn.UserData()); // Создаем подключение с паролем и логином юзера
        }
        public MySqlDb(connector cn)
        {
            createConnect(cn);
            param = new Dictionary<string, string>();
        }
        public result testConnection(connector cn)
        {
            // Проверяем соединение с БД. Если есть ошибка, то error ставим true и дальнейшая работа с БД не производиться
            string errorMessage = null;


            //int res = 0;
            try
            {
                DbCommand cmd = DBconn.getCommand();
                DBcnn.Open();
                cmd.Connection = DBcnn;
                cmd.CommandText = "SELECT 1";
                cmd.ExecuteNonQuery();
                DBcnn.Close();
                return new result(0, "Соединение установлено");
            }
            
            catch (Exception rr)
            {
                error = true;
                errorMessage = rr.Message;
            }
            return new result(500,errorMessage);

        }
        private Dictionary<string, string> param;   // Словарь для параметров в SQL запросах
        public void clearParam()
        {
            param.Clear();
        }
        private void _addParam(string key, string val)
        //Добавляем параметр в словарь
        {
            param.Add(key, val);
        }
        public void addParam(string key, string value)
        {
            // Публичный метод для добавления параметра string
            _addParam(key, value);
        }
        public void addParam(string key, long value)
        {
            // Публичный метод для добавления параметра string
            _addParam(key, value.ToString());
        }
        public void addParam(string key, int value)
        // Публичный метод для добавления параметра int
        {
            _addParam(key, value.ToString());
        }
        public dynamic ExecuteScalar(string sql)
        {
            return SQL_ExecuteScalar(sql);
        }
        public int ExecuteNonQuery(string sql)
        {
            return SQL_ExecuteNonQuery(sql);
        }

        public DataTable ExecuteReader(string sql)
        {
            return SQL_ExecuteReader(sql);
        }
        private dynamic SQL_ExecuteScalar(string sql)
        //private dynamic _SQL_ExecuteScalar(string sql, Dictionary<string, string> param)
        {
            if (DBcnn == null)
            {
                MessageBox.Show("MySqlDb SQL_ExecuteScalar\n DBconn is null");
            }
            dynamic res = null;
            try
            {
                DbCommand cmd = DBconn.getCommand();
                for (int i = 0; i < param.Count; i++)
                {
                    cmd.AddWithValue(param.ElementAt(i).Key, param.ElementAt(i).Value);
                }
                DBcnn.Open();
                cmd.Connection = DBcnn;
                cmd.CommandText = sql;
                res = cmd.ExecuteScalar();
                DBcnn.Close();
            }
            catch (Exception e)
            {
                DBcnn.Close();
                MessageBox.Show("MySqlDb SQL_ExecuteNonQuery\nERROR\n" + e.Message);
            }
            return res;

        }

        private int SQL_ExecuteNonQuery(string sql)
        //private int SQL_ExecuteNonQuery(string sql, Dictionary<string, string> param)
        {
            if (DBcnn == null)
            {
                MessageBox.Show("MySqlDb SQL_ExecuteNonQuery\n DBconn is null");
            }

            int res = 0;
            try
            {
                DbCommand cmd = DBconn.getCommand();
                for (int i = 0; i < param.Count; i++)
                {
                    cmd.AddWithValue(param.ElementAt(i).Key, param.ElementAt(i).Value);
                }
                DBcnn.Open();
                cmd.Connection = DBcnn;
                cmd.CommandText = sql;
                res = cmd.ExecuteNonQuery();
                DBcnn.Close();
            }
            catch (Exception e)
            {
                DBcnn.Close();
                MessageBox.Show("MySqlDb SQL_ExecuteNonQuery\nERROR\n" + e.Message);
                
            }
            return res;

        }

        private DataTable SQL_ExecuteReader(string sql)
        //private DataTable SQL_ExecuteReader(string sql, Dictionary<string, string> param)
        {
            if (DBcnn == null)
            {
                MessageBox.Show("MySqlDb SQL_ExecuteReader\n DBconn is null");
            }
            DataTable dt = null;
            try
            {
                DbCommand cmd = DBconn.getCommand();
                cmd.CommandText = sql;
                for (int i = 0; i < param.Count; i++)
                {
                    cmd.AddWithValue(param.ElementAt(i).Key, param.ElementAt(i).Value);
                }
                DBcnn.Open();
                cmd.Connection = DBcnn;
                dt = new DataTable();
                DbDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                DBcnn.Close();
            }
            catch (Exception e)
            {
                DBcnn.Close();
                MessageBox.Show("SQL_ExecuteReader\nERROR\n" + e.Message);

            }
            return dt;
        }
    }
}
