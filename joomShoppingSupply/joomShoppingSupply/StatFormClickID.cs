using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joomShoppingSupply
{
    public partial class StatFormClickID : Form
    {
        string sql;
        string paramName;
        string columnName;
        connector cn;
        string[] newFormHideColumns;
        string newFName;
        public StatFormClickID(connector _cn,string formName,DataTable source,string[] hideColumnsA,string _sql,string nameParam,string nameColumn,string[] hideColumnsNewForm,string newFormName)
            // Форма выводит данные из указанного источника. По клику на строке делается запрос для второй формы с указанным значением полем-параметром 
            
        {
            // Входящие данные:
            // __cn класс connector - имя и пароль для соединения с БД
            // formName - Имя основной формы (этой формы) в которой произойдет выбор строки
            // source - Источник данных для первой (этой) формы
            // hideColumnsA - Список столбцов для сокрытия в этой форме
            // _sql - Текст запроса с параметром для второй (открываемой по клику) формы. Может быть пустым,если форма конечная и не должна ничего окрывать
            // nameParam - Имя параметра в запросе _sql
            // nameColumn - Имя колонки со значением, которое пойдет в параметр
            // hideColumnsNewForm - Имя колонок, которые нужно скрыть во 2й (открываемой )форме
            // Имя новой формы
            InitializeComponent();
            this.Text = formName;  // Название формы
            sql=_sql;
            cn=_cn;
            paramName=nameParam;
            columnName = nameColumn;
            newFormHideColumns = hideColumnsNewForm;
            newFName = newFormName;
            dgvStat.DataSource=source;  // Источник первичных данных. Для первой формы
            setLeaveStyleDgv(dgvStat, null);
            hideDGVColumns(dgvStat, hideColumnsA);  // 
            dgvStat.Focus();
        }

        
        private void setLeaveStyleDgv(object sender, EventArgs e)
        // Задаем цвет в DGV при потере фокуса
        {
            ((DataGridView)sender).DefaultCellStyle.SelectionBackColor = Color.Gray;
            ((DataGridView)sender).DefaultCellStyle.SelectionForeColor = Color.White;
        }
        private void setEnterStyleDgv(object sender, EventArgs e)
        // Задаем цвета в DGV при фокусе
        {
            ((DataGridView)sender).DefaultCellStyle.SelectionBackColor = Form1.colorOnFocus;
            ((DataGridView)sender).DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void hideDGVColumns(DataGridView dgv, string[] columnsName)
        {
            // Прячем служебные колонки в DataGridView
            //return;
            for (int a = 0; a < columnsName.Count(); a++)
            {
                dgv.Columns[columnsName[a]].Visible = false;
            }
        }
        private void dgvStat_DoubleClick(object sender, EventArgs e)
        {
            viewSelected();
        }

        private void viewSelected()
        {
            if (sql == "") return; // Если запрос пустой, то это конечная форма
            SimpleSQLQuery SQ = new SimpleSQLQuery(cn);
            SQ.addP(paramName, dgvStat.CurrentRow.Cells[columnName].Value.ToString());
            SQ.runQuery(sql);
            StatForm st = new StatForm(newFName, SQ.getData(), newFormHideColumns);
            st.ShowDialog();
        }

        private void dgvStat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                viewSelected();
            }
        }

        

        

        
    }
}
