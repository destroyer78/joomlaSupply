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
    public partial class getClickID : Form
    {
        DataTable dt;
        string[] hideColumn;
        string clickedID="";
        string IDColumnName;
        public getClickID(string n, DataTable _dt, string[] _hideColumn,string _IDColumnName)
            // Форма выведет список из источника dt. Ползователь может выбрать строку двойным кликом или клавишей ENTER
        // После выбора форма закроется, а значение строки для поля _IDColumnName будет запомнено и будет доступно через метод getID()
        {

            InitializeComponent();
            dt = _dt;   // Источник данных
            this.Text = n;  // Имя формы
            hideColumn = _hideColumn;   // Массив  с именами колонок, которые нужно скрыть
            IDColumnName = _IDColumnName;   // Имя колонки с идентификатором, который ,будет запомнен
        }

        private void SearchSupplier_Load(object sender, EventArgs e)
        {
            dgvStat.DataSource = dt;    // Источник данных
            hideDGVColumns(dgvStat, hideColumn);    // Скрываем колонки
            setLeaveStyleDgv(dgvStat, null); // Стиль "внефокуса" для таблицы
            dgvStat.Focus();
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

        private void setClickedID()
        // Запоминаем идентификатор для выбранной строки
        {
            clickedID=dgvStat.CurrentRow.Cells[IDColumnName].Value.ToString(); // Запоминаем идентификатор для выбранной строки
            this.Close();
        }

        private void dgvStat_DoubleClick(object sender, EventArgs e)
        {
            setClickedID();
        }

        private void dgvStat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setClickedID();
            }
        }

        public string getID()
        {
            return clickedID;
        }

        
        
    }
}
