using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace joomShoppingSupply
{
    public partial class Form1 : Form
    {
        public const string DB_CON_NAME = "shop"; // Имя параметра connectionString в файле App.config
        public const string GET_ID = ";SELECT LAST_INSERT_ID()"; // Последний IDшник для БД Mysql

            // Источники данных для DataGridView
        DataTable dtDgvElementSupply=null;   // DataTable для данных поставки для отображения в DGV состав поставки
        //DataTable dtOrderList = null;       // DataTable для данных списка заказов

        public static Color colorOnFocus = Color.FromArgb(187, 234, 202); // Фон активной строки в таблицах
        public static Color colorRedLine = Color.FromArgb(251, 193, 250); // Фон строки для выполненных заказов

        connector cn;   // Класс для получения данных пользователя для соединения с БД
        ToolStripLabel status; // Статус бар
        elementSupply currentElementSupply; // Текущий элемент поставки
        order currentOrder; // Текущий (отображаемый) заказ
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            cn = new connector();
            /*  //Показываем форму регистрации. Снять комментарий после отладки
            this.Hide();
            


                // Вызываем форму ввода регистрации пользователя
            Registration rg = new Registration();
            DialogResult dr=rg.ShowDialog();
            if (dr != DialogResult.Yes)
            {
                    //  Если форму закрывают не по кноке "РЕГИСТРАЦИЯ", то закрываем приложение
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
                return;
            }

            cn.user = rg.getLogin();
            cn.password = rg.getPassword();
            result r = cn.testConnection();
            if (r.getCode() != 0)
            {
                MesShow(r.getMessage());
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
                return;
            }
            */
                // ---------------------------------------
                // На время отладки. После отладки удалить. И удалить коммент на блоке выше.
            cn.user="admin";  
            cn.password="alexarin";
                // ---------------------------------------
            this.Show();
            status = new ToolStripLabel();
            statusStrip1.Items.Add(status);
            dgvSupply.DataSource = dtDgvElementSupply; // Источник данных для DGV
            //dgvOrderForCompile.DataSource = dtOrderList; // Источник данных для DGV

                // Получаем данные для чекбокса КАТЕГОРИИ подсистемы ОТЧЕТЫ
            cat ct= new cat(cn);
            ct.getDataFromDB();
            cbStatGoodCategory.DataSource = ct.getDataTable();
            cbStatGoodCategory.DisplayMember = "name";
            cbStatGoodCategory.ValueMember = "id";
            cbStatGoodCategory.SelectedValue = -1;
            tbOgrn.Focus();
             
        }
        private void setStatusText(string txt)
        {
            status.Text = txt;
        }
        private void setStatusText(result rs)
            // Вывод в статус бар содержимого класса result
        {
            status.Text = rs.getCode() + " : " + rs.getMessage();
        }
        
        private void OnlyDigits_tBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (((TextBox)sender).Text == "" && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            //if (((TextBox)sender).Text == "0" && e.KeyChar >= '1' && e.KeyChar <= '9')
            //{
            //  ((TextBox)sender).Text = "";
            //}
        }
        private void OnlyDigitsAndPoint_tBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, управляющих клавиш, точки. кол-во знаков после точки 2
            Char pnt = '.'; // Символ разделителя целой и дробной части
            if (e.KeyChar == ',') e.KeyChar = pnt;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != pnt)
            {
                e.Handled = true;
                return;
            }
            bool havePoint = false;
            string str = ((TextBox)sender).Text;
            int ind = str.IndexOf(pnt);
            if (ind != -1) havePoint = true;

            if (e.KeyChar == pnt && havePoint)
            {
                // Запрещяем ввод второй точки
                e.Handled = true;
                return;
            }
            if (str == "" && e.KeyChar == pnt)
            {
                ((TextBox)sender).Text = "0" + pnt;
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
                ((TextBox)sender).SelectionLength = 0;
                e.Handled = true;
                return;
            }
            // Колчисетсво знаков после точки
            if (havePoint && (str.Length > ind + 2) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }

        private void bClearSupplierFields_Click(object sender, EventArgs e)
        {
            clearSuppliersField();// Очищаем поля поиска поставщика

        }
        private void clearSuppliersField()
            // Очищаем поля поиска поставщика
        {
            tbEmail.Clear();
            tbTel.Clear();
            tbSupplierID.Clear(); // Скрытое поле
            tbINN.Clear();
            tbOgrn.Clear();
            tbSupplierName.Clear();
            tbSupplierID.Clear();
            dgvSupply.DataSource = null;
            gbSupplyElements.Enabled = false;
            gbElementSupply.Enabled = false;
            tbOgrn.Focus();
        }
        public void MesShow(string message)
            // Показывает окно с информацией
        {
            MessageBox.Show(message, "Внимание");
        }
        public DialogResult QuestionShow(string message)
            // Показывает окно с вопросом
        {
            return MessageBox.Show(message, "Подтвердите действие",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
        private void clearStatus()
        {
            status.Text = "";
        }
        private void setSuppliersField(supplier sp)
            // Заполняем поля поставщика после поиска
        {
            tbEmail.Text = sp.getEmail();
            tbINN.Text = sp.getINN();
            tbOgrn.Text = sp.getOGRN();
            tbSupplierName.Text = sp.getName();
            tbTel.Text = sp.getTel();
            tbSupplierID.Text = sp.getId().ToString();
        }
        private void bCreateSupplier_Click(object sender, EventArgs e)
        {
            clearStatus();
            if (tbOgrn.Text=="" || tbINN.Text=="" || tbEmail.Text=="" || tbSupplierName.Text=="" || tbTel.Text=="" ){
                MesShow("Заполните все поля");
                return;
            }
            string mes= "Наименование: "+tbSupplierName.Text+"\r\nОГРН: "+ tbOgrn.Text+ "\r\nИНН: " + tbINN.Text + "\r\nТелефон: "+tbTel.Text+ "\r\nE-mail: " + tbEmail.Text;
            QuestionShow(mes);
            supplier sp = new supplier(cn,tbSupplierName.Text, tbOgrn.Text, tbINN.Text, tbTel.Text, tbEmail.Text);
            result r=sp.create();
            setStatusText(r.getCode() +" - " + r.getMessage());
            if (sp.getId() != 0)
            {
                getSuppliElements(sp); // Переходим к вводу элементов поставки
            }
            else{
                MesShow("Поставщик не был создан");
                setStatusText("Поставщик не был создан");
            }
            
        }

        private void bSupplierSearch_Click(object sender, EventArgs e)
        {
            searchSpl(); // Поиск поставщика. Вызов из searchSpl
        }
        private void searchSpl()
        // Выполняем поиск поставщика по ИНН или ОГРН
        {
            
            if (tbINN.Text == "" && tbOgrn.Text == "")
            {
                MesShow("Для поиска необходимо заполнить ИНН или ОГРН");
                return;
            }
            supplier sp = new supplier(cn);
            if (tbOgrn.Text != "")
            {
                result r = sp.searchByOGRN(tbOgrn.Text);
                if (r.getCode() == 0) { tbSupplierID.Text = sp.getId().ToString(); }
                setStatusText(r); // Выводим результат поиска 
            } else
            if (tbINN.Text != "")
            {
                
                result r = sp.searchByINN(tbINN.Text);
                if (r.getCode() == 0) { tbSupplierID.Text = sp.getId().ToString(); }
                setStatusText(r); // Выводим результат поиска
            }
            if (sp.getId() != 0)
            {
                setSuppliersField(sp);  // Устанавливаем все поля из найденного
                getSuppliElements(sp); // Переходим к вводу элементов поставки
                
            }
            else
            {
                MesShow("Поставщик не найден");
                setStatusText("Поставщик не найден");
            }
        }
        private void supplEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSpl();
                //e.Handled = true;
                e.SuppressKeyPress = true; // Убираем звук после нажатия клавиши ENTER
            }
        }

        private void getSuppliElements(supplier sp)
            // Начинаем ввод элементов
        {
            gbElementSupply.Enabled = true;
            gbSearchSupplier.Enabled = false;
            tbElementEAN.Focus();
        }
        private void clearElementsField()
            // Очищаем поля элементов поставки
        {
            tbElementEAN.Clear();
            tbElementName.Clear();
            tbElementQuantity.Clear();
            tbElementQuantity.Enabled = false;
        }
        private void bElementCancelSupply_Click(object sender, EventArgs e)
            
        {
            if (QuestionShow("Отменить поставку???\r\nВсе данные будут стерты") != DialogResult.Yes) { return; }
            clearAllSupplyFields();
        }
        private void clearAllSupplyFields()
        // Отменяем введенные данные
        // Очищаем все поля
        // Ставим фокус на поле ОГРН
        {
            clearSuppliersField();
            dgvSupply.DataSource = null;
            clearElementsField();
            gbSearchSupplier.Enabled = true;
            setStatusText("");
            tbElementQuantity.Enabled = false;
            tbOgrn.Focus();
        }

        private void tbElementEAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                searchElementSuuplyByEAN(); // Запускаем поиск по EAN коду товара
                e.SuppressKeyPress = true;
            }
        }
        private void searchElementSuuplyByEAN()
            // поиск по EAN коду товара
        {
            currentElementSupply = new elementSupply(cn);
            result r = currentElementSupply.searchByEan(tbElementEAN.Text);
            setStatusText(r);
            if (currentElementSupply.getId() == "")
            {
                /*string ms = "Ошибка определения товара. ID=''";
                MesShow(ms);
                setStatusText(ms);*/
                return;
            }
            tbElementEAN.Enabled = false;
            tbElementName.Text = currentElementSupply.getName();
            tbElementQuantity.Enabled = true;
            tbElementQuantity.Focus();
        }

        private void bClearElementField_Click(object sender, EventArgs e)
        {
            clearElementsField();
            tbElementEAN.Focus();
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
            ((DataGridView)sender).DefaultCellStyle.SelectionBackColor = colorOnFocus;
            ((DataGridView)sender).DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void tbElementQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                // Пользователь ввел количество товара в поставке и нажал ENTER
                e.SuppressKeyPress = true;
                
                addElementToSupply();
            }
        }
        private void setColumnsWidthDGV()
            // Задаем ширину столбцов таблицы
        {
            int w = dgvSupply.Width;
            dgvSupply.Columns["id"].Width = 0;
            dgvSupply.Columns["EAN"].Width = (int)(w * 0.15);
            dgvSupply.Columns["PAN"].Width = (int)(w * 0.15);
            dgvSupply.Columns["Наименование"].Width = (int)(w * 0.6);
            dgvSupply.Columns["Количество"].Width = (int)(w * 0.1);
        }
        private void addElementToSupply()
        {
            int q = 0;
            try
            {
                q = int.Parse(tbElementQuantity.Text);
            }
            catch (Exception ee)
            {
                setStatusText(ee.Message);
                return;
            }
            currentElementSupply.setQuantity(q);
            if (dtDgvElementSupply == null)
            {
                dtDgvElementSupply = new DataTable();
                
                dtDgvElementSupply.Columns.Add("id", typeof(string));
                dtDgvElementSupply.Columns.Add("EAN", typeof(string));
                dtDgvElementSupply.Columns.Add("PAN", typeof(string));
                dtDgvElementSupply.Columns.Add("Наименование", typeof(string));
                dtDgvElementSupply.Columns.Add("Количество", typeof(int));
                
                dgvSupply.DataSource = dtDgvElementSupply;
                hideDGVColumns(dgvSupply, new string[] { "id" });
                setLeaveStyleDgv(dgvSupply, null);

                setColumnsWidthDGV(); // Устанавливаем ширину столбцов в таблице
                gbSupplyElements.Enabled = true;
            }

            for (int a = 0; a < dtDgvElementSupply.Rows.Count; a++)
            {
                // Если товар уже есть в таблице
                if (dtDgvElementSupply.Rows[a].Field<string>("EAN") == currentElementSupply.getEan())
                {
                    // Если товар с таким кодом EAN уже есть в таблице
                    dtDgvElementSupply.Rows[a].SetField<int>("Количество", dtDgvElementSupply.Rows[a].Field<int>("Количество") + currentElementSupply.getQuantity());
                    setStatusText("Количество обновлено");
                    currentElementSupply = null;
                    tbElementEAN.Enabled=true;
                    clearControls(gbElementSupply);
                    tbElementEAN.Focus();
                    return;
                }
            }

            // Если такого товара еще нет в таблице
            DataRow dr = dtDgvElementSupply.NewRow();
            dr.SetField<string>("id", currentElementSupply.getId());
            dr.SetField<string>("EAN", currentElementSupply.getEan());
            dr.SetField<string>("PAN", currentElementSupply.getManfacturerCode());
            dr.SetField<string>("Наименование", currentElementSupply.getName());
            dr.SetField<int>("Количество", currentElementSupply.getQuantity());
            dtDgvElementSupply.Rows.Add(dr);
            tbElementEAN.Enabled = true;
            clearControls(gbElementSupply);
            tbElementEAN.Focus();

        }

        private void bElementAddElement_Click(object sender, EventArgs e)
        {
            addElementToSupply();
        }

        private void bElementGetSupply_Click(object sender, EventArgs e)
            // Принимаем поставку
        {
            if (dtDgvElementSupply.Rows.Count == 0) return;
            supply supl = new supply(cn);
            supl.setSupplier(tbSupplierID.Text);
            result r = supl.createSupplyInDB();    // Создаем поставку в БД. После этого в id поставки получает значение id вставленной строки
            setStatusText(r);
            if (r.getCode() != 0) { MesShow(r.getMessage()); return; }
            string mes = "";
            result rs;
            // Поставка создана.ID поставки в поле supl.getId() Теперь нужно залить элементы поставки в БД
            int AddRowsCount = 0;
            for (int a = 0; a < dtDgvElementSupply.Rows.Count; a++)
            {
                rs = supl.addSupplyElementToDB(dtDgvElementSupply.Rows[a]); // Метод вернет результат (код + сообщение)
                if (rs.getCode() != 0)
                {
                    mes += dtDgvElementSupply.Rows[a].Field<string>("EAN")+"  --- "+dtDgvElementSupply.Rows[a].Field<int>("Количество").ToString()+"\r\n";
                }
                else { AddRowsCount++; }

            }

            if (mes != "")
            {
                MesShow("Данные об этих товарах не были обновлены в БД\r\n" + mes);
            }
            clearControls(gbElementSupply);
            clearControls(gbSupplyElements);
            clearControls(gbSearchSupplier);
            setStatusText("Поставка принята. Обновлено товаров " + AddRowsCount + " из " + dtDgvElementSupply.Rows.Count);
            tbOgrn.Focus();
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
        private void setWidthForOrderDGV()
        // Задаем ширину для столбцов таблицы ЗАКАЗЫ ДЛЯ СБОРКИ
        {
            int w = dgvOrderForCompile.Width; // Узнаем ширину таблицы
                // Задаем ширину в процентах от ширины. В сумме должно быть 100% (1)
            //dgvOrderForCompile.Columns["ID"].Width = (int)(w * 0.2);
            dgvOrderForCompile.Columns["Номер заказа"].Width = (int)(w * 0.3);
            dgvOrderForCompile.Columns["Статус"].Width = (int)(w * 0.3);
            dgvOrderForCompile.Columns["ОТ"].Width = (int)(w * 0.4);
        }

        private void setWidthForProductListDGV()
            // Задаем ширину для столбцов таблицы СОСТАВ ЗАКАЗА
        {
            int w = dgvOrderProductListOrder.Width; // Узнаем ширину таблицы
            // Задаем ширину в процентах от ширины. В сумме должно быть 100% (1)
            dgvOrderProductListOrder.Columns["EAN"].Width = (int)(w * 0.1);
            dgvOrderProductListOrder.Columns["PAN"].Width = (int)(w * 0.25);
            dgvOrderProductListOrder.Columns["Наименование"].Width = (int)(w * 0.55);
            dgvOrderProductListOrder.Columns["Количество"].Width = (int)(w * 0.1);
        }
        private void bGetOrderList_Click(object sender, EventArgs e)
            // Обновляем список заказов
        {
            getOrderList();
        }
        private void getOrderList()
            // Получаем список заказов
        {
            ordersList ol = new ordersList(cn);
            result r = ol.getOrdersList(); // Получаем результат выполнения обновления
            setStatusText(r);   // Выводим сообщение в статус бар
            dgvOrderForCompile.DataSource = ol.getDataTable(); // Получаем данные для таблицы и назначаем 

            setWidthForOrderDGV(); // Задаем ширину столбцов для таблицы ЗАКАЗЫ ДЛЯ СБОРКИ
            hideDGVColumns(dgvOrderForCompile, new string[] { "ID","order_status" }); // Скрываем служебный столбец
            if (dgvOrderForCompile.Rows.Count == 0) return;
            dgvOrderForCompile.Focus(); // Задаем фокус на таблицу ЗАКАЗЫ ДЛЯ СБОРКИ
            dgvOrderForCompile_SelectionChanged(dgvOrderForCompile, null);
        }

        private void getOrderProductList()
            // Получаем список товаров в заказе
        {
                // Получаем данные для заполнения объекта  ЗАКАЗ
            string id = dgvOrderForCompile.CurrentRow.Cells["ID"].Value.ToString();
            string number = dgvOrderForCompile.CurrentRow.Cells["Номер заказа"].Value.ToString();
            string from = dgvOrderForCompile.CurrentRow.Cells["ОТ"].Value.ToString();
                // Создаем новый объект ЗАКАЗ и заполняем его данными и списком товаров
            currentOrder = new order(cn, id, number, from);
            currentOrder.getProductList();
                // Назначаем источник данных для таблицы СОСТАВ ЗАКАЗА
            dgvOrderProductListOrder.Enabled = true; // Делаем таблицу активной
            dgvOrderProductListOrder.DataSource = currentOrder.getDataTable();
            setWidthForProductListDGV(); // Задаем ширину для столбцов таблицы СОСТАВ ЗАКАЗА
            setLeaveStyleDgv(dgvOrderProductListOrder, null); // Задаем стиль для таблицы
            setStatusText("0 : Состав заказа загружен");
        }

        private void dgvOrderForCompile_DoubleClick(object sender, EventArgs e)
            // Двойной клик на таблице
        {
            getOrderProductList(); // Получаем список заказа
        }

        private void dgvOrderForCompile_KeyDown(object sender, KeyEventArgs e)
            // Нажатие клавиш на таблице
        {
            if (e.KeyCode == Keys.Enter)
                //Если нажата клавиша ENTER 
            {
                getOrderProductList(); // Получаем список товаров
                //bPrintOrder.Enabled = true; // Кнопку РАСПЕЧАТАТЬ СБОРОЧНЫЙ ЛИСТ активируем
                e.Handled = true;   // Прерываем дальнейшую обработку 
                e.SuppressKeyPress = true;
            }
        }

        private void dgvOrderForCompile_SelectionChanged(object sender, EventArgs e)
        {
            dgvOrderProductListOrder.DataSource = null; // Удаляем источник данных для списка зтоваров в заказе
            currentOrder = null;        // Удаляем объект с текущим заказом. На другой заказ будет создан новый объект с информацией 
            dgvOrderProductListOrder.Enabled = false;   // Делаем таблицу не активной
            bCreateCompileList.Enabled = false;    // Кнопку РАСПЕЧАТАТЬ СБОРОЧНЫЙ ЛИСТ деактивируем

            if (dgvOrderForCompile.CurrentRow.Cells["order_status"].Value.ToString() == "2")
            // Если статус заказа ПОДТВЕРЖДЕН, то делаем неактивной кнопку ПОДТВЕРДИТ СБОР ЗАКАЗА и активной РАСПЕЧАТАТЬ СБОРОЧНЫЙ ЛИСТ
            {
                bCompliteOrder.Enabled = false; // деАктивируем кнопку 
                bCreateCompileList.Enabled = true;     // Активируем кнопку
            }
           
            
            if (dgvOrderForCompile.CurrentRow.Cells["order_status"].Value.ToString() == "5")
                // Если статус заказа СБОРКА, то делаем доступной кнопку ПОДТВЕРДИТ СБОР ЗАКАЗА
            {
                bCompliteOrder.Enabled = true; // Активируем кнопку 
                bCreateCompileList.Enabled = true;     // Активируем кнопку
            }
            

            if (dgvOrderForCompile.CurrentRow.Cells["order_status"].Value.ToString() == "6")
            {
                dgvOrderForCompile.DefaultCellStyle.SelectionBackColor = colorRedLine;
                bCompliteOrder.Enabled = false; // деАктивируем кнопку 
                bCreateCompileList.Enabled = false;     // Активируем кнопку
            }
            else
            {
                dgvOrderForCompile.DefaultCellStyle.SelectionBackColor = colorOnFocus;
            }
            setStatusText("");
        }
        public void setWaitCursor(string statusMessage = "Запрос выполняется...")
        {
            Cursor.Current = Cursors.WaitCursor;
            setStatusText(statusMessage);
        }
        public void setDefaultCursor(string statusMessage = "OK")
        {
            Cursor.Current = Cursors.Default;
            setStatusText(statusMessage);
        }
        private void bCompliteOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder == null) getOrderProductList();
            DialogResult dr = QuestionShow("Заказ №" + currentOrder.getOrderNumber() + " от " + currentOrder.getFromDate() + " собран?");
            if (dr != DialogResult.Yes) return;
            
            result r=currentOrder.setConfirmCompile(); // Подтверждаем выполнение заказа
            MesShow (r.getMessage()); // Выводим сообщение о смене статуса заказа
            getOrderList(); // Обновляем список заказов
        }

        private void bPrintOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder == null) getOrderProductList();
            setStatusText(currentOrder.getOrderInfo()); // Получаем допюинфу по заказу и выводим статус получения данных
            setWaitCursor("Формируем сборочный лист");
            ExcelObj excel = new ExcelObj();
            Microsoft.Office.Interop.Excel.Worksheet ws = excel.getWorksheet();

            currentOrder.getCompileList(ref ws);
            excel.setVisible(true);
            currentOrder.setStartCompile();     // Статус заказа СБОРКА
            setDefaultCursor("Сборочный лист сформирован. Статус заказа №"+currentOrder.getOrderNumber() + "- СБОРКА");

                // Освобождаем ресурсы и запускаем сбор мусора
            excel.kill();
            getOrderList();    
        }


        private void clearControls(Control c)
        {
            // Рекурсивно проходим по всем вложенным контролам указанного контрола
            // Очищаем контролы: Если групБокс, то чистим все текстБоксы, комбоБоксы ставим SelectedIndex =-1
            if (c is Label) return;
            if (c is DataGridView)
            {
                ((DataGridView)c).DataSource = null; // Отвязываем таблицу от источника данных
                ((DataGridView)c).Rows.Clear();
                ((DataGridView)c).Columns.Clear();
                return;
            }

            if (c is GroupBox)
            {   // Если контрол GroupBox, то проходим по всем вложенным контролам
                for (int a = 0; a < c.Controls.Count; a++)
                {
                    clearControls(c.Controls[a]);
                }
                return;
            }
            if (c is TabControl)
            {// Если контрол TabControl, то проходим по всем вложенным контролам
                for (int i = 0; i < ((TabControl)c).TabCount; i++)
                {

                    clearControls((TabPage)c.Controls[i]);
                }
                return;
            }
            if (c is TextBox)
            {
                ((TextBox)c).Text = ""; // Очищаем поле ввода
                return;
            }
            if (c is ComboBox)
            {
                ((ComboBox)c).SelectedIndex = -1; // Сбрасываем выделение комбобокса

                return;
            }
            
            if (c is CheckBox)
            {
                ((CheckBox)c).Checked = false;
            }

        }

        private void btStatClearGoodGroupBox_Click(object sender, EventArgs e)
        {
            clearControls(gbStatGoods); // Рекурсивно очищаем группу статистика товары
        }

        private void btClearStatGbSupply_Click(object sender, EventArgs e)
        {
            clearControls(gbStatSupply); // Рекурсивно очищаем группу статистика поставки
        }

        private void btStatGoodsCreate_Click(object sender, EventArgs e)
            // Формируем отчет по товарам
        {
            if (tbStatEAN.Text.Trim() == "" && tbStatPAN.Text.Trim() == "" && tbStatMoreQuantity.Text.Trim() == "" && tbStatGoodName.Text.Trim()=="" &&  tbStatLessQuantity.Text.Trim() == "" && !chStatZeroQuantity.Checked && cbStatGoodCategory.SelectedIndex==-1)
            {
                DialogResult dr = QuestionShow("Параметры не заданы и формирование займет много времени. Продолжаем???");
                if (dr != DialogResult.Yes) return;
            }

            // Формируем отчет
            GoodStatistic stat = new GoodStatistic(cn);
            stat.setEAN(tbStatEAN.Text);
            stat.setPAN(tbStatPAN.Text);
            stat.setLessQuantity(tbStatLessQuantity.Text);
            stat.setMoreQuantity(tbStatMoreQuantity.Text);
            stat.setZeroQuantity(chStatZeroQuantity.Checked);
            stat.setName(tbStatGoodName.Text);
            if ((int)cbStatGoodCategory.SelectedIndex != -1)
            {
                stat.setCategory((int)cbStatGoodCategory.SelectedValue);
                stat.setCatName(cbStatGoodCategory.GetItemText(cbStatGoodCategory.SelectedItem));
            }
            stat.getStatistic(); // Выполняем выборку данных
            if (!chStatGoodsToExcel.Checked)
            {
                // Отчет формируем в новую форму
                StatForm st = new StatForm("Отчет по товарам", stat.getData(),new string[]{});
                st.ShowDialog();
            }
            else
            {
                setWaitCursor("Отчет формируется");
                // Отчет формируем в Excel
                ExcelObj excel = new ExcelObj();
                Microsoft.Office.Interop.Excel.Worksheet ws = excel.getWorksheet();
                stat.getExcel(ref ws);
                excel.setVisible(true);
                excel.kill();    // Excel сам по себе
            }


        }

        private void btStatSupplyCreate_Click(object sender, EventArgs e)
        {
            if (tbStatOGRN.Text.Trim() == "" && tbStatINN.Text.Trim() == "" && tbStatSupplierName.Text.Trim() == "" && !cbSupplyWithDate.Checked)
            {
                DialogResult dr = QuestionShow("Параметры не заданы и формирование займет много времени. Продолжаем???");
                if (dr != DialogResult.Yes) return;
            }
            SupplyStat sp = new SupplyStat(cn);
            sp.setINN(tbStatINN.Text);
            sp.setOGRN(tbStatOGRN.Text);
            sp.setName(tbStatSupplierName.Text);
            sp.setDateFrom(dtStatSupplyFrom.Value);
            sp.setDateTo(dtStatSupplyTo.Value);
            sp.setWithDate(cbSupplyWithDate.Checked);

            result r=sp.searchSupply();
            setStatusText(r);
        }

        private void cbWithDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSupplyWithDate.Checked)
            {
                dtStatSupplyFrom.Enabled = true;
                dtStatSupplyTo.Enabled = true;
            }
            else
            {
                dtStatSupplyFrom.Enabled = false;
                dtStatSupplyTo.Enabled = false;
            }
        }

        private void btSupplierFind_Click(object sender, EventArgs e)
        {
            tbStatSupplierName.Text=tbStatSupplierName.Text.Trim();
            supplier sp = new supplier(cn);
            sp.searchByLikeName(tbStatSupplierName.Text);
            tbStatOGRN.Text = sp.getOGRN();
            tbStatINN.Text = sp.getINN();
            tbStatSupplierName.Text = sp.getName();

        }

        private void Clear_Status_OnFocus(object sender, EventArgs e)
        // Очищаем статус бар
        {
            clearStatus(); 
        }

        private void btStatSearchGoodInSupply_Click(object sender, EventArgs e)
            // Ищем заданный товар в поставке
        {
            string ean=tbEAN_SearchGoodInSupply.Text.Trim();
            if (ean == "")
            {
                setStatusText("Задайте условие (EAN)");
                return;
            }
            SupplyStat sp = new SupplyStat(cn);
            sp.setINN(tbStatINN.Text);
            sp.setOGRN(tbStatOGRN.Text);
            sp.setDateFrom(dtStatSupplyFrom.Value);
            sp.setDateTo(dtStatSupplyTo.Value);
            sp.setWithDate(cbSupplyWithDate.Checked);
            sp.setEAN(ean);
            sp.searchByEAN();
        }

        private void button1_Click(object sender, EventArgs e)
            // Очищаем форму отчетов "ПРОДАЖИ"
        {
            clearControls(gbSales);
        }

        private void cbSalesWithDate_CheckedChanged(object sender, EventArgs e)
            //  Доступность Условие ДАТА формы отчетов "ПРОДАЖИ"
        {
            if (cbStatSalesWithDate.Checked)
            {
                dtStatSalesDateFrom.Enabled = true;
                dtStatSalesDateTo.Enabled = true;
            }
            else
            {
                dtStatSalesDateFrom.Enabled = false;
                dtStatSalesDateTo.Enabled = false;
            }
        }

        private void cbStatSalesWithBill_CheckedChanged(object sender, EventArgs e)
        //  Доступность Условие ЧЕК формы отчетов "ПРОДАЖИ"
        {
            if (cbStatSalesWithBill.Checked)
            {
                tbStatSalesBillFrom.Enabled = true;
                tbStatSalesBillTo.Enabled = true;
            }
            else
            {
                tbStatSalesBillFrom.Enabled = false;
                tbStatSalesBillTo.Enabled = false;
            }
        }

        private void cbStatSalesWithCount_CheckedChanged(object sender, EventArgs e)
        //  Доступность Условие ПОЗИЦИЙ формы отчетов "ПРОДАЖИ"
        {
            if (cbStatSalesWithGoodsCount.Checked)
            {
                tbStatSalesGoodsCountFrom.Enabled = true;
                tbStatSalesGoodsCountTo.Enabled = true;
            }
            else
            {
                tbStatSalesGoodsCountFrom.Enabled = false;
                tbStatSalesGoodsCountTo.Enabled = false;
            }
        }

        private void btStatSalesCreate_Click(object sender, EventArgs e)
        {
            SaleStatistic slStat = new SaleStatistic(cn);
            slStat.setEAN(tbStatSalesEAN.Text.Trim());
            slStat.setBillFrom(tbStatSalesBillFrom.Text.Trim());
            slStat.setBillTo(tbStatSalesBillTo.Text.Trim());
            slStat.setGoodsCountFrom(tbStatSalesGoodsCountFrom.Text.Trim());
            slStat.setGoodsCountTo(tbStatSalesGoodsCountTo.Text.Trim());
            slStat.setDateFrom(dtStatSalesDateFrom.Value);
            slStat.setDateTo(dtStatSalesDateTo.Value);
            if (cbStatSalesWithDate.Checked) { slStat.setWithDate(true); }
            if (cbStatSalesWithBill.Checked) { slStat.setWithBill(true); }
            if (cbStatSalesWithGoodsCount.Checked) { slStat.setWithGoodsCount(true); }
            setStatusText("Отчет формируется");
            slStat.getStatistic(); // Выбираем данные из БД
            if (cbSalesExcel.Checked)
            {
                // Формируем EXCEL
                //setWaitCursor("Отчет формируется");
                // Отчет формируем в Excel
                ExcelObj excel = new ExcelObj();
                Microsoft.Office.Interop.Excel.Worksheet ws = excel.getWorksheet();
                slStat.getExcel(ref ws);
                excel.setVisible(true);
                excel.kill();    // Excel сам по себе
            }
            else
            {
                // Формируем на экран
                slStat.showOnDisplay();
            }
            setStatusText("Отчет сформирован");
            //slStat
            
        }

        

        

        

        

        
        
        
        
        

        
        



        
        
        
        

        
    }
}
