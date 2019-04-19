using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class SaleStatistic:SQL_Class
    {
        string EAN;
        string billFrom;
        string billTo;
        string goodsCountFrom;
        string goodsCountTo;
        DateTime dateFrom;
        DateTime dateTo;

        bool withDate;
        bool withBill;
        bool withGoodsCount;
        connector cn;
        DataTable dtResult;

        public SaleStatistic(connector _cn)
        {
            cn = _cn;
            SQL = new MySqlDb(cn);
        }
        public void setEAN(string e) { EAN = e.Trim(); }
        public void setBillFrom(string s) { billFrom = s.Trim(); }
        public void setBillTo(string s) { billTo = s.Trim(); }
        public void setGoodsCountFrom(string s) { goodsCountFrom = s.Trim(); }
        public void setGoodsCountTo(string s) { goodsCountTo = s.Trim(); }
        public void setDateFrom(DateTime d) {
            // Дата до Х.Х.Х 00:00:00
            dateFrom = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
        }
        public void setDateTo(DateTime d) {
                // Дата до Х.Х.Х 23:59:59
            dateTo = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
        }

        public void setWithDate(bool b) { withDate = b; }
        public void setWithBill(bool b) { withBill = b; }
        public void setWithGoodsCount(bool b) { withGoodsCount = b; }

        public DataTable getData() { return dtResult; }

        public void getStatistic()
            // Метод выполняет запрос для сбора статистики
            // Результат помещается в dtResult
        {
            //sql = "SELECT pr.`product_ean`,ors.`order_total`,ors.`order_date`,itc.`cnt` FROM `ishp_jshopping_order_item` ori,`ishp_jshopping_products` pr,`ishp_jshopping_orders`ors,(SELECT `order_id`,count(*) 'cnt' FROM `ishp_jshopping_order_item` GROUP BY `order_id` ) AS itc WHERE ori.`order_id` = ors.`order_id` AND ori.`product_id` = pr.`product_id` AND itc.`order_id`=ors.`order_id`";
            sql = "SELECT ors.`order_id`,ors.`order_number` 'Номер заказа',ors.`order_total`'Чек',ors.`order_date` 'Дата заказа',itc.`cnt`'Позиций' FROM `ishp_jshopping_order_item` ori,`ishp_jshopping_products` pr,`ishp_jshopping_orders`ors,(SELECT `order_id`,count(*) 'cnt' FROM `ishp_jshopping_order_item` GROUP BY `order_id` ) AS itc WHERE ori.`order_id` = ors.`order_id` AND ori.`product_id` = pr.`product_id` AND itc.`order_id`=ors.`order_id`";

            string cond = "";
            if (EAN != "")
            {
                cond += " AND pr.`product_ean`=@ean";
                SQL.addParam("@ean", EAN);
            }
            if (withDate)
            {
                cond += " AND ors.`order_date` BETWEEN @from AND @to";
                SQL.addParam("@from", dateFrom.ToString("yyyy-MM-dd") + " 00:00:00");
                SQL.addParam("@to", dateTo.ToString("yyyy-MM-dd") + " 23:59:59");
            }

            if (withBill)
            {
                if (billTo != "" && billFrom != "")
                {
                    cond += "AND ors.`order_total` BETWEEN @bfrom AND @bto";
                    SQL.addParam("@bfrom", billFrom);
                    SQL.addParam("@bto", billTo);
                }
                else
                {
                    if (billTo == "" && billFrom!="")
                        {
                            cond += " AND ors.`order_total`>= @bfrom";
                            SQL.addParam("@bfrom", billFrom);
                        }
                    if (billFrom == "" && billTo!="")
                        {
                            cond += " AND ors.`order_total` <= @bto";
                            SQL.addParam("@bto", billTo);
                        }
                    
                }
                
                
                
            }
            if (withGoodsCount)
            {
                if (goodsCountFrom != "" && goodsCountTo != "")
                {
                    cond += " AND itc.`cnt` BETWEEN @gcfrom AND @gcto";
                    SQL.addParam("@gcfrom", goodsCountFrom);
                    SQL.addParam("@gcto", goodsCountTo);
                }
                else
                {
                    if (goodsCountTo=="" && goodsCountFrom!="") {
                        cond += " AND itc.`cnt`>= @gcfrom";
                        SQL.addParam("@gcfrom", goodsCountFrom);
                    }
                    if (goodsCountFrom == "" && goodsCountTo!="")
                    {
                        cond += " AND itc.`cnt`<=@gcto";
                        SQL.addParam("@gcto", goodsCountTo);
                    }
                }
            }
            if (cond != "")
            {
                sql += cond;
            }
            dtResult = SQL.ExecuteReader(sql);
            
        }
        public void showOnDisplay()
            // Выводим отчет на экран
        {
            string nsql = "SELECT  ori.`product_ean`'EAN',ori.`manufacturer_code`'PAN',pr.`name_ru-RU` 'Наименование',ori.`product_quantity` 'Количество' FROM `ishp_jshopping_order_item` ori,`ishp_jshopping_products` pr WHERE ori.`product_id`=pr.`product_id` AND ori.`order_id`=@orid";
            StatFormClickID sfc = new StatFormClickID(cn, "Результат поиска", dtResult, new string[] { "order_id" }, nsql, "@orid", "order_id", new string[] { }, "Состав заказа");
            sfc.ShowDialog();
        }

        private void setLine(ref Microsoft.Office.Interop.Excel.Worksheet ws, ref int x)
        // Линия на всю длину строки на листе
        {
            ws.Range["A" + x + ":I" + x].Merge();
            ws.Range["A" + x].Value = "'-----------------------------------------------------------------------------------------------------------";
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            x++;
            //x = lineX.ToString();
        }
        private void setProductHead(ref Microsoft.Office.Interop.Excel.Worksheet ws, ref int x)
        // ШАПКА для списка товаров
        {
            ws.Range["A" + x + ":B"+x].Merge();
            ws.Range["A" + x].Value = "Номер заказа";
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["A" + x].Font.Bold = true;


            ws.Range["C" + x + ":D" + x].Merge();
            ws.Range["C" + x].Value = "Чек";
            ws.Range["C" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["C" + x + ":D" + x].Font.Bold = true;

            ws.Range["E" + x + ":H" + x].Merge();
            ws.Range["E" + x].Value = "Дата заказа";
            ws.Range["E" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["E" + x + ":H" + x].Font.Bold = true;

            ws.Range["I" + x].Value = "Позиций";
            ws.Range["I" + x].Font.Bold = true;
            x++;
        }


        public Microsoft.Office.Interop.Excel.Worksheet getExcel (ref Microsoft.Office.Interop.Excel.Worksheet ws){
            ws.Name = "Товары от " + String.Format("{0:dd-MM-yyyy}", DateTime.Today);
            ws.Range["A1:I1"].Merge();
            ws.Range["A1"].Value = "Отчет по продажам от " + DateTime.Now;

            ws.Range["A2:I2"].Merge();
            ws.Range["A2"].Value = "УСЛОВИЯ ОТБОРА";
            ws.Range["A2"].Font.Bold = true;
            ws.Range["A2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int x = 3;    // Строка
            if (EAN != "")
            {
                ws.Range["A" + x + ":I" + x].Merge();
                ws.Range["A" + x].Value = "EAN = " + EAN;
                x++;
            }
            if (withBill)
            {
                ws.Range["A" + x].Merge();
                ws.Range["A" + x].Value = "ЧЕК ОТ:";
                ws.Range["A" + x].Font.Bold = true;

                ws.Range["B" + x].Value = billFrom;
                ws.Range["B" + x].Font.Italic = true;

                ws.Range["D" + x].Value = "ДО:";
                ws.Range["D" + x].Font.Bold = true;

                ws.Range["E" + x].Value = billTo;
                ws.Range["E" + x].Font.Italic = true;
                x++;
            }

            if (withDate)
            {
                ws.Range["A" + x+":B"+x].Merge();
                ws.Range["A" + x].Value = "ДАТА ОТ:";
                ws.Range["A" + x].Font.Bold = true;

                ws.Range["C" + x + ":D"+x].Merge();
                ws.Range["C" + x].Value = dateFrom.ToString("dd-MMM-yyyy HH:mm");
                ws.Range["C" + x].Font.Italic = true;

                ws.Range["E" + x].Value = "ДО:";
                ws.Range["E" + x].Font.Bold = true;

                ws.Range["F" + x + ":G"+x].Merge();
                ws.Range["F" + x].Value = dateTo.ToString("dd-MMM-yyyy HH:mm");
                ws.Range["F" + x].Font.Italic = true;
                x++;
            }
            if (withGoodsCount)
            {
                ws.Range["A" + x + ":B"+x].Merge();
                ws.Range["A" + x].Value = "ПОЗИЦИЙ В ЧЕКЕ ОТ:";
                ws.Range["A" + x].Font.Bold = true;

                ws.Range["C" + x].Value = goodsCountFrom;
                ws.Range["C" + x].Font.Italic = true;

                ws.Range["D" + x].Value = "ДО:";
                ws.Range["D" + x].Font.Bold = true;

                ws.Range["E" + x].Merge();
                ws.Range["E" + x].Value = goodsCountTo;
                ws.Range["E" + x].Font.Italic = true;
                x++;
            }

            if (x == 3) { x = 2; } // Если условий отбора нет, то замещаем запись УСЛОВИЯ ОТБОРА
            ws.Range["A" + x + ":I" + x].Merge();
            ws.Range["A" + x].Value = "РЕЗУЛЬТАТ ОТБОРА";
            ws.Range["A" + x].Font.Bold = true;
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            x++;

            setProductHead(ref ws, ref x);


            for (int a = 0; a < dtResult.Rows.Count; a++)
            {
                // Номер заказа
                ws.Range["A" + x + ":B" + x].Merge();
                ws.Range["A" + x].Value = "'" + dtResult.Rows[a].Field<string>("Номер заказа");
                ws.Range["A" + x].Font.Italic = true;

                // Чек
                ws.Range["C" + x + ":D" + x].Merge();
                ws.Range["C" + x].Value = "'" + dtResult.Rows[a].Field<decimal>("Чек");
                ws.Range["C" + x].Font.Italic = true;

                // Дата заказа
                ws.Range["E" + x + ":H" + x].Merge();
                ws.Range["E" + x].Value = dtResult.Rows[a].Field<DateTime>("Дата заказа");
                ws.Range["E" + x].Font.Italic = true;

                // Позиций
                ws.Range["I" + x].Value = String.Format("{0:0}", dtResult.Rows[a].Field<Int64>("Позиций"));
                ws.Range["I" + x].Font.Italic = true;

                x++;

                if (((x - 1) % 50) == 0)
                // На каждой ново странице печатаем шапку и линию
                {
                    setProductHead(ref ws, ref x);
                    setLine(ref ws, ref x);
                }

            }
            return ws;
        }
    }
}

