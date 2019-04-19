using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    

    class SupplyStat:SQL_Class
    {
        string id;
        string OGRN;
        string INN;
        string name;
        DateTime from;
        DateTime to;
        bool withDate;
        connector cn;

        string EAN;

        DataTable dtToTemplateSearch;
        DataTable dtSearchResult;


        public SupplyStat(connector cnn)
        {
            SQL = new MySqlDb(cnn);
            cn = cnn;
        }
        public void setOGRN(string v) { OGRN = v.Trim(); }
        public void setINN(string v) { INN = v.Trim(); }
        public void setName(string v) { name = v.Trim(); }
        public void setDateFrom(DateTime d){from=d;}
        public void setDateTo(DateTime d){ to=d;}
        public void setWithDate(bool b) { withDate = b; }
        public void setEAN(string e){ EAN=e; }
        /*
        public result searchByTemplate()
        {
            if (name == "") { dtToTemplateSearch = null; return new result(401, "Не задан шаблон имени для поиска"); }
            sql = "SELECT * FROM supplier WHERE name LIKE '" + name + "'";
            dtToTemplateSearch = SQL.ExecuteReader(sql);
            return new result(0, "Поиск выполнен");
        }
        public DataTable getDtForTemplateSearch() { return dtToTemplateSearch; }

        */

        public result searchByEAN()
        {
            string cond = "";
            sql = "SELECT sly.`id`,sly.`date` 'Дата поставки',sers.`name` 'Наименование поставщика' ,sers.`ogrn` 'ОГРН', sel.`quantity` 'Количество товара в поставке' FROM `supply_elements` sel,`supply` sly,`suppliers` sers,`ishp_jshopping_products` pr WHERE sers.`id` = sly.`supplier`  AND pr.`product_id` = sel.`product` AND sel.`supply`=sly.`id` AND pr.`product_ean` = @ean";
            SQL.clearParam();
            SQL.addParam("@ean", EAN);
            if (withDate)
            {
                cond += "AND sly.`date` between @from AND @to";
                SQL.addParam("@from", from.ToString("yyyy-MM-dd") + " 00:00:00");
                SQL.addParam("@to", to.ToString("yyyy-MM-dd") + " 23:59:59");
            }
            if (OGRN != "")
            {
                cond += " AND sers.`ogrn` = @ogrn";
                SQL.addParam("@ogrn", OGRN);
            }

            if (INN != "")
            {
                cond += " AND sers.`inn` = @inn";
                SQL.addParam("@inn", INN);
            }

            if (cond != "")
            {
                sql += cond;
            }

            dtSearchResult = SQL.ExecuteReader(sql);

            if (dtSearchResult.Rows.Count == 0)
            {
                return new result(402, "Поиск не дал результатов");
            }
            //StatForm sf = new StatForm("Поставки", dtSearchResult,new string[]{"id"});
            string nsql = "SELECT pr.`product_ean`'EAN',pr.`name_ru-RU`'Наименование',se.`quantity`'Количество' FROM `supply_elements` se,`ishp_jshopping_products` pr WHERE se.`product`=pr.`product_id` AND se.`supply`=@supl";
            StatFormClickID sf = new StatFormClickID(cn, "Результат поиска поставок", dtSearchResult, new string[] { "id" }, nsql, "@supl", "id", new string[] { }, "Состав поставки");
            sf.ShowDialog();


            return new result(0, "Поиск поставок выполнен");
            

        }
        public result searchSupply()
        {
            string condSupplier = ""; // Условие поиска поставщика
            string cond = "";
            sql = "SELECT sl.`id`,sp.`ogrn` 'ОГРН',sp.`name` 'Поставщик',sl.`date` 'Дата поставки' FROM supply sl, suppliers sp";
            bool and=false;
            string sAND = " AND ";

            SQL.clearParam();

            if (INN != "")
            {
                condSupplier = "sp.`inn`=@inn";
                SQL.addParam("@inn", INN);
                and = true;
            }

            if (OGRN != "")
            {
                if (and) { condSupplier += sAND; }
                condSupplier += "sp.`ogrn`=@ogrn";
                SQL.addParam("@ogrn", OGRN);
                and = true;
            }

            if (name != "")
            {
                if (and) { condSupplier += sAND; }
                condSupplier += "sp.`name` LIKE '"+name+"'";
                and = true;
            }
            if (withDate)
            {
                if (and) { cond += sAND; }
                cond += "sl.`date` between @from AND @to";
                SQL.addParam("@from", from.ToString("yyyy-MM-dd") + " 00:00:00");
                SQL.addParam("@to", to.ToString("yyyy-MM-dd") + " 23:59:59");
            }



            sql += " WHERE sl.`supplier`=sp.`id`";
            if (condSupplier!="")
            {
                sql += " AND ";
                sql += condSupplier;
            }

            if (cond != "")
            {
                sql += " AND ";
                sql += cond;
            }

            
            dtSearchResult = SQL.ExecuteReader(sql);

            if (dtSearchResult.Rows.Count == 0)
            {
                return new result(402, "Поиск не дал результатов");
            }
            //StatForm sf = new StatForm("Поставки", dtSearchResult,new string[]{"id"});
            string nsql="SELECT pr.`product_ean`'EAN',pr.`name_ru-RU`'Наименование',se.`quantity`'Количество' FROM `supply_elements` se,`ishp_jshopping_products` pr WHERE se.`product`=pr.`product_id` AND se.`supply`=@supl";
            StatFormClickID sf = new StatFormClickID(cn, "Результат поиска поставок", dtSearchResult, new string[] { "id" }, nsql, "@supl", "id", new string[] { },"Состав поставки");
            sf.ShowDialog();

            
            return new result(0,"Поиск поставок выполнен");
        }
        
    }
}
