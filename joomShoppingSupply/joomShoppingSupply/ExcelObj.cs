using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joomShoppingSupply
{
    class ExcelObj
    {
        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook wb;
        Microsoft.Office.Interop.Excel.Worksheet ws;
        public ExcelObj()
        {
            
            excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Visible = false;
            //;
            wb = excel.Workbooks.Add(Type.Missing);
            ws = wb.Sheets.Add();

        }
        public Microsoft.Office.Interop.Excel.Worksheet getWorksheet()
        {
            return ws;
        }

        public void kill()
        {
            // Освобождаем ресурсы и запускаем сбор мусора
            ws = null;
            wb = null;
            excel = null;
            GC.Collect(); // Без этой строки в памяти остается висеть процесс после каждого отчета !!!!!
        }
        public void setVisible(bool v)
        {
            if (excel==null)return;
            excel.Visible=v;
        }

    }
}
