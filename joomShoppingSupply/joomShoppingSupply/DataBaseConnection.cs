using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace joomShoppingSupply
{
    public class DataBaseConnection
    {
        ConnectionStringSettings settings;
        DbProviderFactory factory;
        public DataBaseConnection(string name)
        {
            // Чтение раздела именованной строки подключения
            settings = ConfigurationManager.ConnectionStrings[name];
            // Запрашиваем фабрику поставщика из базового класса
            factory = DbProviderFactories.GetFactory(settings.ProviderName);
        }
        public DbConnection GetDatabaseConnection(string LoginAndPassword)
        {
            // LoginAndPassword строка типа ;userid=adminka;password=adminka
            DbConnection conn = factory.CreateConnection();
            // Объекту соединения присваиваем свойства соединения
            conn.ConnectionString = settings.ConnectionString + LoginAndPassword;
            // Возвращаем объект conn
            return conn;
        }

        public DbCommand getCommand()
        {
            return factory.CreateCommand(); // Создаем команду поставщика соединения с БД
        }
    }
    public static class MyExt
    {
        public static void AddWithValue<T>(this IDbCommand command, string name, T value)
        {
            // Реализуем расширение для добавления параметров простой строкой Например  -  cmd.AddWithValue("@ean", tBoxGoodEAN.Text.Trim());
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }
    }

}
