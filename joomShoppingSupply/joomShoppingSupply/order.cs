using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace joomShoppingSupply
{
    class order:SQL_Class
    {
        DataTable productList;
        string id="";
        string number;
        string fromDate;
            // Доп инфа
        string orderTotal, owner_name, email, street, zip, city, phone, country,country_code;

        public order(connector cn, string _id,string _number, string _fromDate)
        {
            SQL = new MySqlDb(cn);
            id = _id;
            number = _number;
            fromDate = _fromDate;
        }

        public result getOrderInfo()
            // Получаем дополнительную информацию по заказу
        {
            if (id == "") return new result(301, "ID заказа не установлен");

            sql = "SELECT ord.`order_total`,ord.`d_f_name`,ord.`d_m_name`,ord.`currency_code`,ord.`d_l_name`,ord.`d_email`,ord.`d_street`,ord.`d_zip`,ord.`d_city`,ord.`d_phone`,cnt.`country_code`,cnt.`country_code_2`,cnt.`name_ru-RU` 'country_name' FROM `ishp_jshopping_orders` AS ord,`ishp_jshopping_countries` AS cnt WHERE ord.`country`=cnt.`country_id` AND `order_id`=@id";
            SQL.clearParam();
            SQL.addParam("@id", id);
            DataTable dt = SQL.ExecuteReader(sql);
            if (dt.Rows.Count == 0) { return new result(310, "Невозможно получить дополнительную информацию по заказу"); }
            if (dt.Rows.Count >1) { return new result(311, "Невозможно однозначно получить информацию по заказу"); }
            
            orderTotal=String.Format("{0:0.00}",dt.Rows[0].Field<decimal>("order_total")) + " "+ dt.Rows[0].Field<string>("currency_code");
            owner_name = dt.Rows[0].Field<string>("d_f_name") + " " + dt.Rows[0].Field<string>("d_m_name") + " " + dt.Rows[0].Field<string>("d_l_name");
            email = dt.Rows[0].Field<string>("d_email");
            street = dt.Rows[0].Field<string>("d_street");
            zip = dt.Rows[0].Field<string>("d_zip");
            city = dt.Rows[0].Field<string>("d_city");
            phone = dt.Rows[0].Field<string>("d_phone");
            country_code = dt.Rows[0].Field<string>("country_code") + "(" + dt.Rows[0].Field<string>("country_code_2")+")";
            country = dt.Rows[0].Field<string>("country_name");
            return new result(0, "Дополнительная информация по заказу получена");
        }
        public string getOrderNumber() { return number; }
        public string getFromDate() { return fromDate; }
        public result getProductList()
            // Получаем состав зказа
        {
            sql = "SELECT `product_ean` 'EAN',`manufacturer_code` 'PAN',`product_name` 'Наименование',`product_quantity` 'Количество' FROM `ishp_jshopping_order_item` WHERE order_id = @oid";
            SQL.clearParam();
            SQL.addParam("@oid", id);
            productList = SQL.ExecuteReader(sql);
            return new result(0, "Список заказа обновлен");
        }

        public DataTable getDataTable(){ return productList;}

        

        
        public result setConfirmCompile()
            // Подтверждаем сборку заказа
        {
            return setStatus(6); // Статус СОБРАН
        }

        public result setStartCompile()
        // Подтверждаем начало сборки заказа
        {
            return setStatus(5); // Статус СБОРКА
        }
        private result setStatus(int status)
        {
            if (id == "") return new result(301, "ID заказа не установлен");
            sql = "UPDATE  `ishp_jshopping_orders` SET `order_status`=@stat WHERE `order_id`=@id";
            SQL.clearParam();
            SQL.addParam("@id", id);
            SQL.addParam("@stat", status);
            int a = SQL.ExecuteNonQuery(sql);
            string stStr = "";
            if (status == 5) stStr = "СБОРКА";
            if (status == 6) stStr = "СОБРАН";
                
            if (a != 1)
            {
                return new result(302, "Ошибка. Обновлено " + a + " заказов");
            }
            return new result(0, "Статус заказа №" + number + " обновлен на "+stStr );


        }

        private void setLine(ref Microsoft.Office.Interop.Excel.Worksheet ws, ref int lineX)
            // Линия на всю длину строки на листе
        {
            string x = lineX.ToString();
            ws.Range["A" + x + ":I" + x].Merge();
            ws.Range["A" + x].Value = "'-----------------------------------------------------------------------------------------------------------";
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            lineX++;
            //x = lineX.ToString();
        }
        private void setProductHead( ref Microsoft.Office.Interop.Excel.Worksheet ws, ref int lineX)
            // ШАПКА для списка товаров
        {
            string x = lineX.ToString();
            ws.Range["A" + x].Value = "EAN";
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["A" + x].Font.Bold = true;


            ws.Range["B" + x + ":D" + x].Merge();
            ws.Range["B" + x].Value = "PAN";
            ws.Range["B" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["B" + x + ":H" + x].Font.Bold = true;

            ws.Range["E" + x + ":H" + x].Merge();
            ws.Range["E" + x].Value = "НАИМЕНОВАНИЕ";
            ws.Range["E" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Range["E" + x + ":H" + x].Font.Bold = true;

            ws.Range["I" + x].Value = "КОЛ-ВО";
            ws.Range["I" + x].Font.Bold = true;
            lineX++;
        }
        public Microsoft.Office.Interop.Excel.Worksheet getCompileList(ref Microsoft.Office.Interop.Excel.Worksheet ws)
        {
            // Создаем имя листа

            string name = "Заказ №" + number;
            ws.Name = name;

            // Создаем шапку листа поставки

                    // Образец
            //ws.Range["A1"].Value = "Заказ №";
            //ws.Range["A1:B1"].Merge();
            //ws.Range["A1"].Font.Bold = true;
            //ws.Range["B1"].Font.Italic = true;

                    //  -------------- LINE 1 ------------------------
            ws.Range["A1"].Value = "ЗАКАЗ №";
            ws.Range["A1"].Font.Bold = true;

            ws.Range["B1"].Value = "'" + number;
            ws.Range["B1"].Font.Italic = true;
            
            ws.Range["C1"].Value = "ОТ:";
            ws.Range["C1"].Font.Bold = true;

            ws.Range["D1:E1"].Merge();
            ws.Range["D1"].Value = fromDate;
            ws.Range["D1:E1"].Font.Italic = true;

            ws.Range["F1:G1"].Merge();
            ws.Range["F1"].Value = "НА СУММУ:";
            ws.Range["F1:G1"].Font.Bold = true;

            ws.Range["H1:I1"].Merge();
            ws.Range["H1"].Value = orderTotal;
            ws.Range["H1:I1"].Font.Italic = true;

            int lineX = 2;
            string x=lineX.ToString();
            if (owner_name.Trim() != "") 
            { 
            //  -------------- LINE 2 ------------------------

                ws.Range["A"+x+":B"+x].Merge();
                ws.Range["A"+x].Value = "ЗАКАЗЧИК:";
                ws.Range["A"+x+":B"+x].Font.Bold = true;

                ws.Range["C" + x +":I" + x].Merge();
                ws.Range["C" +x].Value = owner_name;
                ws.Range["C"+x+":I"+x].Font.Italic = true;
                lineX++;
            }
            x=lineX.ToString();
                if (city.Trim() != "" && zip.Trim() != "" && street.Trim() != "")
                {
                    //  -------------- LINE 3 ------------------------

                    ws.Range["A" + x + ":B" + x].Merge();
                    ws.Range["A" + x].Value = "АДРЕС ДОСТАВКИ:";
                    ws.Range["A" + x + ":B" + x].Font.Bold = true;

                    ws.Range["C" + x + ":I" + x].Merge();
                    ws.Range["C"+x].Value = country_code + ",  " + country;
                    ws.Range["C" + x + ":I"+x].Font.Italic = true;
                    lineX++;
                    x = lineX.ToString();
                    //  -------------- LINE 4 ------------------------

                    ws.Range["A" + x + ":I"+x].Merge();
                    ws.Range["A"+x].Value = zip + ",  " + city + ",   " + street;
                    ws.Range["A" + x + ":I"+x].Font.Italic = true;
                    lineX++;
                    x = lineX.ToString();
                }
                //  -------------- LINE 5 ------------------------

            if (phone.Trim()!="" || email.Trim()!="")
            {
                ws.Range["A" + x + ":B"+x].Merge();
                ws.Range["A"+x].Value = "ТЕЛЕФОН:";
                ws.Range["A"+x].Font.Bold = true;

                ws.Range["C" + x + ":D"+x].Merge();
                ws.Range["C"+x].Value = "'" + phone;
                ws.Range["C"+x].Font.Italic = true;

                ws.Range["E"+x].Value = "E-MAIL:";
                ws.Range["E"+x].Font.Bold = true;

                ws.Range["F" + x + ":I"+x].Merge();
                ws.Range["F"+x].Value = email;
                ws.Range["F"+x].Font.Italic = true;
                lineX++;
                x = lineX.ToString();
            }
            
            
                // Шапка Перед списком товаров
            ws.Range["A"+x+":I"+x].Merge();
            ws.Range["A"+x].Value = "СОСТАВ ЗАКАЗА:";
            ws.Range["A"+x].Font.Bold = true;
            ws.Range["A" + x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            lineX++; 
            x=lineX.ToString();

            setProductHead(ref ws,ref lineX);
            //x = lineX.ToString();  // Между методами преобразование не нужно
            setLine(ref ws, ref lineX); // ЛИНИЯ
            x = lineX.ToString();

           
            

            for (int a = 0; a < productList.Rows.Count; a++)
            {
                    // EAN
                //ws.Range["A" + x + ":B" + x].Merge();
                ws.Range["A" + x].Value = productList.Rows[a].Field<string>("EAN");
                ws.Range["A" + x ].Font.Italic = true;

                    // PAN
                ws.Range["B" + x + ":D" + x].Merge();
                ws.Range["B" + x].Value = productList.Rows[a].Field<string>("PAN");
                ws.Range["B" + x].Font.Italic = true;

                    // НАИМЕНОВАНИЕ
                ws.Range["E" + x + ":H" + x].Merge();
                ws.Range["E" + x].Value = productList.Rows[a].Field<string>("Наименование");
                ws.Range["E" + x].Font.Italic = true;

                    // КОЛИЧЕСТВО
                ws.Range["I" + x].Value = String.Format("{0:0}",productList.Rows[a].Field<decimal>("Количество"));
                ws.Range["I" + x].Font.Italic = true;

                lineX++;
                x = lineX.ToString();

                if (((lineX-1) % 50) == 0) 
                    // На каждой ново странице печатаем шапку и линию
                {
                    setProductHead(ref ws,ref lineX);
                    setLine(ref ws, ref lineX);
                }

            }

                return ws;
        }
    }
}
