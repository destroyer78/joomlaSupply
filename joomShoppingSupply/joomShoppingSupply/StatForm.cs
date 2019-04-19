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
    public partial class StatForm : Form
    {
        DataTable dt;
        string[] hideColumn;
        public StatForm(string n,DataTable _dt,string[] _hideColumn)
        {
            InitializeComponent();
            dt = _dt;
            this.Text = n;  // Имя формы
            hideColumn = _hideColumn;
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            dgvStat.DataSource = dt;
            hideDGVColumns(dgvStat, hideColumn);
            setLeaveStyleDgv(dgvStat, null);
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

        
    }
}
