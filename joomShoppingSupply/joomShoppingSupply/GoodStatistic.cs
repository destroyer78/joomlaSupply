using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class GoodStatistic:SQL_Class
    {
        DataTable dt;
        string EAN;
        string PAN;
        string moreQuantity;
        string lessQuantity;
        string name;
        bool zeroQuantity;
        int category=-1;
        string catName;

            // Класс для формирования отчетов
        public GoodStatistic(connector cn)
        {
            SQL = new MySqlDb(cn);
        }
        public void setEAN(string e) { EAN = e.Trim(); }
        public void setPAN(string p) { PAN = p.Trim(); }
        public void setMoreQuantity(string m) { moreQuantity = m.Trim(); }
        public void setLessQuantity(string l) { lessQuantity = l.Trim(); }

        public void setZeroQuantity(bool c) { zeroQuantity = c; }

        public void setName(string n) { name = n.Trim(); }
        public void setCategory(int c) { category = c; }
        public void setCatName(string c){catName=c;}
        public DataTable getData() { return dt; }
        public void getStatistic()
        {
            sql = "SELECT pt.`product_ean` 'EAN',pt.`manufacturer_code` 'PAN',pt.`name_ru-RU` 'Наименование',pt.`product_quantity` 'Количество' FROM `ishp_jshopping_products` AS pt";
            SQL.clearParam();
            string cond="";
            bool AND = false;
            string andStr =" AND ";
            if (EAN != "")
            {
                cond = "pt.product_ean=@ean ";
                SQL.addParam("@ean", EAN);
                AND = true;
            }
            if (PAN != "")
            {
                if (AND) { cond += andStr; }
                cond += "pt.manufacturer_code=@pan";
                SQL.addParam("@pan", PAN);
                AND = true;
            }
            if (moreQuantity != "")
            {
                if (AND) { cond += andStr; }

                cond += "pt.product_quantity > @more";
                SQL.addParam("@more", moreQuantity);
                AND = true;
            }

            if (lessQuantity != "")
            {
                if (AND) { cond += andStr; }

                cond += "pt.product_quantity < @less";
                SQL.addParam("@less", lessQuantity);
                AND = true;
            }

            if (name!= "")
            {
                if (AND) { cond += andStr; }

                cond += "pt.`name_ru-RU` LIKE '"+name+"'";
                //SQL.addParam("@more", moreQuantity);
                AND = true;
            }

            if (zeroQuantity)
            {
                if (AND) { cond += andStr; }

                cond += "pt.product_quantity=0";
                AND = true;
            }

            if (category != -1 )
            {
                if (AND) { cond += andStr; }
                sql += ", `ishp_jshopping_products_to_categories` AS ctt";
                cond += "pt.product_id=ctt.product_id AND ctt.category_id=@cat";
                SQL.addParam("@cat", category);
                AND = true;
            }

                // Проверяем условия, и если они не пусты, то добавляем их в условие запроса
            if (cond != "")
            {
                sql += " WHERE " + cond;
            }
            
            dt = SQL.ExecuteReader(sql);
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
        private void setProductHead( ref Microsoft.Office.Interop.Excel.Worksheet ws, ref int x)
            // ШАПКА для списка товаров
        {
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
            x++;
        }

        public Microsoft.Office.Interop.Excel.Worksheet getExcel (ref Microsoft.Office.Interop.Excel.Worksheet ws)
            // Формируем отчет в EXCEL
        {
                ws.Name = "Товары от " + String.Format("{0:dd-MM-yyyy}",DateTime.Today);
                ws.Range["A1:I1"].Merge();
                ws.Range["A1"].Value = "Отчет по товарам от "+DateTime.Now;

                ws.Range["A2:I2"].Merge();
                ws.Range["A2"].Value = "УСЛОВИЯ ОТБОРА";
                ws.Range["A2"].Font.Bold = true;
                ws.Range["A2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int x=3;    // Строка
            if (EAN!="")
            { 
                ws.Range["A"+x+":I"+x].Merge();
                ws.Range["A"+x].Value = "EAN = "+EAN;
                x++;
            }

            if (PAN!="")
            { 
                ws.Range["A"+x+":I"+x].Merge();
                ws.Range["A"+x].Value = "PAN = "+PAN;
                x++;
            }
            if (moreQuantity!="" || lessQuantity!="")
            { 
                string str = "";
                bool a=false;
                ws.Range["A"+x+":I"+x].Merge();
                if (moreQuantity!=""){
                    str= "КОЛИЧЕСТВО БОЛЕЕ  "+moreQuantity;
                    a=true;
                }
                if (lessQuantity!=""){
                    if (a) {
                        str+="  И  МЕНЕЕ  ";
                     } else {
                        str="КОЛИЧЕСТВО МЕНЕЕ  ";
                    }
                     str+= lessQuantity;
                }
                ws.Range["A" + x].Value = str;
                x++;
            }

            if (name !="")
            { 
                ws.Range["A"+x+":I"+x].Merge();
                ws.Range["A"+x].Value = "НАИМЕНОВАНИЕ: "+name;
                x++;
            }
            if (zeroQuantity==true)
            { 
                ws.Range["A"+x+":I"+x].Merge();
                ws.Range["A"+x].Value = "КОЛИЧЕСТВО РАВНО НУЛЮ";
                x++;
            }

            if (category!=-1)
            { 
                ws.Range["A"+x+":I"+x].Merge();
                ws.Range["A"+x].Value = "КАТЕГОРИЯ: "+catName;
                x++;
            }

            if (x == 3) { x = 2; } // Если условий отбора нет, то замещаем запись УСЛОВИЯ ОТБОРА
            ws.Range["A"+x+":I"+x].Merge();
            ws.Range["A"+x].Value = "РЕЗУЛЬТАТ ОТБОРА";
            ws.Range["A"+x].Font.Bold = true;
            ws.Range["A"+x].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            x++;

            setProductHead(ref ws, ref x);
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                // EAN
                //ws.Range["A" + x + ":B" + x].Merge();
                ws.Range["A" + x].Value = "'"+dt.Rows[a].Field<string>("EAN");
                ws.Range["A" + x].Font.Italic = true;

                // PAN
                ws.Range["B" + x + ":D" + x].Merge();
                ws.Range["B" + x].Value = "'" + dt.Rows[a].Field<string>("PAN");
                ws.Range["B" + x].Font.Italic = true;

                // НАИМЕНОВАНИЕ
                ws.Range["E" + x + ":H" + x].Merge();
                ws.Range["E" + x].Value = dt.Rows[a].Field<string>("Наименование");
                ws.Range["E" + x].Font.Italic = true;

                // КОЛИЧЕСТВО
                ws.Range["I" + x].Value = String.Format("{0:0}", dt.Rows[a].Field<decimal>("Количество"));
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
