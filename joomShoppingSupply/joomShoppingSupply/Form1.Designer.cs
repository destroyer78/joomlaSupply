namespace joomShoppingSupply
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.supplies = new System.Windows.Forms.TabPage();
            this.gbSupplyElements = new System.Windows.Forms.GroupBox();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.gbElementSupply = new System.Windows.Forms.GroupBox();
            this.bClearElementField = new System.Windows.Forms.Button();
            this.bElementCancelSupply = new System.Windows.Forms.Button();
            this.bElementGetSupply = new System.Windows.Forms.Button();
            this.bElementAddElement = new System.Windows.Forms.Button();
            this.tbElementQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbElementName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbElementEAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSearchSupplier = new System.Windows.Forms.GroupBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.bClearSupplierFields = new System.Windows.Forms.Button();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCreateSupplier = new System.Windows.Forms.Button();
            this.bSupplierSearch = new System.Windows.Forms.Button();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOgrn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.TabPage();
            this.bCompliteOrder = new System.Windows.Forms.Button();
            this.bGetOrderList = new System.Windows.Forms.Button();
            this.bCreateCompileList = new System.Windows.Forms.Button();
            this.gbProdList = new System.Windows.Forms.GroupBox();
            this.dgvOrderProductListOrder = new System.Windows.Forms.DataGridView();
            this.gbOrderForComplete = new System.Windows.Forms.GroupBox();
            this.dgvOrderForCompile = new System.Windows.Forms.DataGridView();
            this.statistics = new System.Windows.Forms.TabPage();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btStatSalesClearForm = new System.Windows.Forms.Button();
            this.btStatSalesCreate = new System.Windows.Forms.Button();
            this.cbSalesExcel = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbStatSalesGoodsCountTo = new System.Windows.Forms.TextBox();
            this.tbStatSalesGoodsCountFrom = new System.Windows.Forms.TextBox();
            this.cbStatSalesWithGoodsCount = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbStatSalesBillTo = new System.Windows.Forms.TextBox();
            this.tbStatSalesBillFrom = new System.Windows.Forms.TextBox();
            this.cbStatSalesWithBill = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbStatSalesWithDate = new System.Windows.Forms.CheckBox();
            this.dtStatSalesDateTo = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtStatSalesDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbStatSalesEAN = new System.Windows.Forms.TextBox();
            this.gbStatSupply = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btStatSearchGoodInSupply = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbEAN_SearchGoodInSupply = new System.Windows.Forms.TextBox();
            this.btClearStatGbSupply = new System.Windows.Forms.Button();
            this.btSupplierFind = new System.Windows.Forms.Button();
            this.btStatSupplyCreate = new System.Windows.Forms.Button();
            this.tbStatSupplierName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSupplyWithDate = new System.Windows.Forms.CheckBox();
            this.dtStatSupplyTo = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtStatSupplyFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.tbStatINN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbStatOGRN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbStatGoods = new System.Windows.Forms.GroupBox();
            this.btStatClearGbSupply = new System.Windows.Forms.Button();
            this.cbStatGoodCategory = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbStatGoodName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btStatGoodsCreate = new System.Windows.Forms.Button();
            this.chStatGoodsToExcel = new System.Windows.Forms.CheckBox();
            this.gbGoodGbCondition = new System.Windows.Forms.GroupBox();
            this.chStatZeroQuantity = new System.Windows.Forms.CheckBox();
            this.tbStatLessQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStatMoreQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbStatPAN = new System.Windows.Forms.TextBox();
            this.tbStatEAN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainTab.SuspendLayout();
            this.supplies.SuspendLayout();
            this.gbSupplyElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            this.gbElementSupply.SuspendLayout();
            this.gbSearchSupplier.SuspendLayout();
            this.orders.SuspendLayout();
            this.gbProdList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductListOrder)).BeginInit();
            this.gbOrderForComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderForCompile)).BeginInit();
            this.statistics.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbStatSupply.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbStatGoods.SuspendLayout();
            this.gbGoodGbCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.supplies);
            this.mainTab.Controls.Add(this.orders);
            this.mainTab.Controls.Add(this.statistics);
            this.mainTab.Location = new System.Drawing.Point(12, 12);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(994, 571);
            this.mainTab.TabIndex = 0;
            // 
            // supplies
            // 
            this.supplies.Controls.Add(this.gbSupplyElements);
            this.supplies.Controls.Add(this.gbElementSupply);
            this.supplies.Controls.Add(this.gbSearchSupplier);
            this.supplies.Location = new System.Drawing.Point(4, 22);
            this.supplies.Name = "supplies";
            this.supplies.Padding = new System.Windows.Forms.Padding(3);
            this.supplies.Size = new System.Drawing.Size(986, 545);
            this.supplies.TabIndex = 0;
            this.supplies.Text = "Поставки";
            this.supplies.UseVisualStyleBackColor = true;
            // 
            // gbSupplyElements
            // 
            this.gbSupplyElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSupplyElements.Controls.Add(this.dgvSupply);
            this.gbSupplyElements.Enabled = false;
            this.gbSupplyElements.Location = new System.Drawing.Point(7, 138);
            this.gbSupplyElements.Name = "gbSupplyElements";
            this.gbSupplyElements.Size = new System.Drawing.Size(973, 326);
            this.gbSupplyElements.TabIndex = 2;
            this.gbSupplyElements.TabStop = false;
            this.gbSupplyElements.Text = "Состав поставки";
            // 
            // dgvSupply
            // 
            this.dgvSupply.AllowUserToAddRows = false;
            this.dgvSupply.AllowUserToResizeColumns = false;
            this.dgvSupply.AllowUserToResizeRows = false;
            this.dgvSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupply.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSupply.Location = new System.Drawing.Point(6, 19);
            this.dgvSupply.MultiSelect = false;
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.ReadOnly = true;
            this.dgvSupply.RowHeadersVisible = false;
            this.dgvSupply.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSupply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupply.Size = new System.Drawing.Size(960, 301);
            this.dgvSupply.TabIndex = 0;
            this.dgvSupply.TabStop = false;
            this.dgvSupply.Enter += new System.EventHandler(this.setEnterStyleDgv);
            this.dgvSupply.Leave += new System.EventHandler(this.setLeaveStyleDgv);
            // 
            // gbElementSupply
            // 
            this.gbElementSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbElementSupply.Controls.Add(this.bClearElementField);
            this.gbElementSupply.Controls.Add(this.bElementCancelSupply);
            this.gbElementSupply.Controls.Add(this.bElementGetSupply);
            this.gbElementSupply.Controls.Add(this.bElementAddElement);
            this.gbElementSupply.Controls.Add(this.tbElementQuantity);
            this.gbElementSupply.Controls.Add(this.label8);
            this.gbElementSupply.Controls.Add(this.tbElementName);
            this.gbElementSupply.Controls.Add(this.label7);
            this.gbElementSupply.Controls.Add(this.tbElementEAN);
            this.gbElementSupply.Controls.Add(this.label6);
            this.gbElementSupply.Enabled = false;
            this.gbElementSupply.Location = new System.Drawing.Point(7, 470);
            this.gbElementSupply.Name = "gbElementSupply";
            this.gbElementSupply.Size = new System.Drawing.Size(973, 66);
            this.gbElementSupply.TabIndex = 1;
            this.gbElementSupply.TabStop = false;
            this.gbElementSupply.Text = "Элемент поставки";
            // 
            // bClearElementField
            // 
            this.bClearElementField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearElementField.Location = new System.Drawing.Point(723, 19);
            this.bClearElementField.Name = "bClearElementField";
            this.bClearElementField.Size = new System.Drawing.Size(67, 35);
            this.bClearElementField.TabIndex = 14;
            this.bClearElementField.Text = "Очистить";
            this.bClearElementField.UseVisualStyleBackColor = true;
            this.bClearElementField.Click += new System.EventHandler(this.bClearElementField_Click);
            // 
            // bElementCancelSupply
            // 
            this.bElementCancelSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bElementCancelSupply.Location = new System.Drawing.Point(877, 19);
            this.bElementCancelSupply.Name = "bElementCancelSupply";
            this.bElementCancelSupply.Size = new System.Drawing.Size(89, 35);
            this.bElementCancelSupply.TabIndex = 13;
            this.bElementCancelSupply.TabStop = false;
            this.bElementCancelSupply.Text = "Отмена поставки";
            this.bElementCancelSupply.UseVisualStyleBackColor = true;
            this.bElementCancelSupply.Click += new System.EventHandler(this.bElementCancelSupply_Click);
            // 
            // bElementGetSupply
            // 
            this.bElementGetSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bElementGetSupply.Location = new System.Drawing.Point(796, 19);
            this.bElementGetSupply.Name = "bElementGetSupply";
            this.bElementGetSupply.Size = new System.Drawing.Size(75, 35);
            this.bElementGetSupply.TabIndex = 12;
            this.bElementGetSupply.TabStop = false;
            this.bElementGetSupply.Text = "Принять поставку";
            this.bElementGetSupply.UseVisualStyleBackColor = true;
            this.bElementGetSupply.Click += new System.EventHandler(this.bElementGetSupply_Click);
            // 
            // bElementAddElement
            // 
            this.bElementAddElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bElementAddElement.Location = new System.Drawing.Point(650, 19);
            this.bElementAddElement.Name = "bElementAddElement";
            this.bElementAddElement.Size = new System.Drawing.Size(67, 35);
            this.bElementAddElement.TabIndex = 3;
            this.bElementAddElement.Text = "Добавить";
            this.bElementAddElement.UseVisualStyleBackColor = true;
            this.bElementAddElement.Click += new System.EventHandler(this.bElementAddElement_Click);
            // 
            // tbElementQuantity
            // 
            this.tbElementQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementQuantity.Location = new System.Drawing.Point(569, 34);
            this.tbElementQuantity.MaxLength = 13;
            this.tbElementQuantity.Name = "tbElementQuantity";
            this.tbElementQuantity.Size = new System.Drawing.Size(75, 20);
            this.tbElementQuantity.TabIndex = 2;
            this.tbElementQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbElementQuantity_KeyDown);
            this.tbElementQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(569, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количество";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbElementName
            // 
            this.tbElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementName.Enabled = false;
            this.tbElementName.Location = new System.Drawing.Point(173, 34);
            this.tbElementName.MaxLength = 255;
            this.tbElementName.Name = "tbElementName";
            this.tbElementName.Size = new System.Drawing.Size(390, 20);
            this.tbElementName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(173, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Наименование";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbElementEAN
            // 
            this.tbElementEAN.Location = new System.Drawing.Point(6, 34);
            this.tbElementEAN.MaxLength = 13;
            this.tbElementEAN.Name = "tbElementEAN";
            this.tbElementEAN.Size = new System.Drawing.Size(161, 20);
            this.tbElementEAN.TabIndex = 1;
            this.tbElementEAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbElementEAN_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "EAN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchSupplier
            // 
            this.gbSearchSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchSupplier.Controls.Add(this.tbSupplierID);
            this.gbSearchSupplier.Controls.Add(this.bClearSupplierFields);
            this.gbSearchSupplier.Controls.Add(this.tbTel);
            this.gbSearchSupplier.Controls.Add(this.label5);
            this.gbSearchSupplier.Controls.Add(this.tbEmail);
            this.gbSearchSupplier.Controls.Add(this.label4);
            this.gbSearchSupplier.Controls.Add(this.tbSupplierName);
            this.gbSearchSupplier.Controls.Add(this.label3);
            this.gbSearchSupplier.Controls.Add(this.bCreateSupplier);
            this.gbSearchSupplier.Controls.Add(this.bSupplierSearch);
            this.gbSearchSupplier.Controls.Add(this.tbINN);
            this.gbSearchSupplier.Controls.Add(this.label2);
            this.gbSearchSupplier.Controls.Add(this.tbOgrn);
            this.gbSearchSupplier.Controls.Add(this.label1);
            this.gbSearchSupplier.Location = new System.Drawing.Point(7, 7);
            this.gbSearchSupplier.Name = "gbSearchSupplier";
            this.gbSearchSupplier.Size = new System.Drawing.Size(973, 124);
            this.gbSearchSupplier.TabIndex = 0;
            this.gbSearchSupplier.TabStop = false;
            this.gbSearchSupplier.Text = "Поставщик";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(410, 54);
            this.tbSupplierID.MaxLength = 13;
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(14, 20);
            this.tbSupplierID.TabIndex = 13;
            this.tbSupplierID.TabStop = false;
            this.tbSupplierID.Visible = false;
            // 
            // bClearSupplierFields
            // 
            this.bClearSupplierFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearSupplierFields.Location = new System.Drawing.Point(845, 84);
            this.bClearSupplierFields.Name = "bClearSupplierFields";
            this.bClearSupplierFields.Size = new System.Drawing.Size(122, 30);
            this.bClearSupplierFields.TabIndex = 12;
            this.bClearSupplierFields.TabStop = false;
            this.bClearSupplierFields.Text = "Очистить";
            this.bClearSupplierFields.UseVisualStyleBackColor = true;
            this.bClearSupplierFields.Click += new System.EventHandler(this.bClearSupplierFields_Click);
            // 
            // tbTel
            // 
            this.tbTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTel.Location = new System.Drawing.Point(603, 80);
            this.tbTel.MaxLength = 30;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(207, 20);
            this.tbTel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(603, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Телефон";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(349, 32);
            this.tbEmail.MaxLength = 70;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(461, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(349, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplierName.Location = new System.Drawing.Point(15, 80);
            this.tbSupplierName.MaxLength = 100;
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(582, 20);
            this.tbSupplierName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bCreateSupplier
            // 
            this.bCreateSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateSupplier.Location = new System.Drawing.Point(845, 48);
            this.bCreateSupplier.Name = "bCreateSupplier";
            this.bCreateSupplier.Size = new System.Drawing.Size(122, 30);
            this.bCreateSupplier.TabIndex = 5;
            this.bCreateSupplier.TabStop = false;
            this.bCreateSupplier.Text = "Создать";
            this.bCreateSupplier.UseVisualStyleBackColor = true;
            this.bCreateSupplier.Click += new System.EventHandler(this.bCreateSupplier_Click);
            // 
            // bSupplierSearch
            // 
            this.bSupplierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSupplierSearch.Location = new System.Drawing.Point(845, 11);
            this.bSupplierSearch.Name = "bSupplierSearch";
            this.bSupplierSearch.Size = new System.Drawing.Size(122, 31);
            this.bSupplierSearch.TabIndex = 6;
            this.bSupplierSearch.Text = "Поиск";
            this.bSupplierSearch.UseVisualStyleBackColor = true;
            this.bSupplierSearch.Click += new System.EventHandler(this.bSupplierSearch_Click);
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(182, 31);
            this.tbINN.MaxLength = 13;
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(161, 20);
            this.tbINN.TabIndex = 2;
            this.tbINN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.supplEnterPress);
            this.tbINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(182, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOgrn
            // 
            this.tbOgrn.Location = new System.Drawing.Point(15, 32);
            this.tbOgrn.MaxLength = 13;
            this.tbOgrn.Name = "tbOgrn";
            this.tbOgrn.Size = new System.Drawing.Size(161, 20);
            this.tbOgrn.TabIndex = 1;
            this.tbOgrn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.supplEnterPress);
            this.tbOgrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ОГРН";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orders
            // 
            this.orders.Controls.Add(this.bCompliteOrder);
            this.orders.Controls.Add(this.bGetOrderList);
            this.orders.Controls.Add(this.bCreateCompileList);
            this.orders.Controls.Add(this.gbProdList);
            this.orders.Controls.Add(this.gbOrderForComplete);
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(986, 545);
            this.orders.TabIndex = 1;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // bCompliteOrder
            // 
            this.bCompliteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCompliteOrder.Enabled = false;
            this.bCompliteOrder.Location = new System.Drawing.Point(787, 109);
            this.bCompliteOrder.Name = "bCompliteOrder";
            this.bCompliteOrder.Size = new System.Drawing.Size(188, 42);
            this.bCompliteOrder.TabIndex = 4;
            this.bCompliteOrder.TabStop = false;
            this.bCompliteOrder.Text = "Подтвердить сбор заказа";
            this.bCompliteOrder.UseVisualStyleBackColor = true;
            this.bCompliteOrder.Click += new System.EventHandler(this.bCompliteOrder_Click);
            // 
            // bGetOrderList
            // 
            this.bGetOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGetOrderList.Location = new System.Drawing.Point(787, 13);
            this.bGetOrderList.Name = "bGetOrderList";
            this.bGetOrderList.Size = new System.Drawing.Size(188, 42);
            this.bGetOrderList.TabIndex = 3;
            this.bGetOrderList.Text = "Обновить список заказов";
            this.bGetOrderList.UseVisualStyleBackColor = true;
            this.bGetOrderList.Click += new System.EventHandler(this.bGetOrderList_Click);
            // 
            // bCreateCompileList
            // 
            this.bCreateCompileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateCompileList.Enabled = false;
            this.bCreateCompileList.Location = new System.Drawing.Point(787, 61);
            this.bCreateCompileList.Name = "bCreateCompileList";
            this.bCreateCompileList.Size = new System.Drawing.Size(188, 42);
            this.bCreateCompileList.TabIndex = 2;
            this.bCreateCompileList.TabStop = false;
            this.bCreateCompileList.Text = "Сформировать сборочный лист";
            this.bCreateCompileList.UseVisualStyleBackColor = true;
            this.bCreateCompileList.Click += new System.EventHandler(this.bPrintOrder_Click);
            // 
            // gbProdList
            // 
            this.gbProdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProdList.Controls.Add(this.dgvOrderProductListOrder);
            this.gbProdList.Location = new System.Drawing.Point(4, 224);
            this.gbProdList.Name = "gbProdList";
            this.gbProdList.Size = new System.Drawing.Size(979, 312);
            this.gbProdList.TabIndex = 1;
            this.gbProdList.TabStop = false;
            this.gbProdList.Text = "Состав заказа";
            // 
            // dgvOrderProductListOrder
            // 
            this.dgvOrderProductListOrder.AllowUserToAddRows = false;
            this.dgvOrderProductListOrder.AllowUserToDeleteRows = false;
            this.dgvOrderProductListOrder.AllowUserToResizeColumns = false;
            this.dgvOrderProductListOrder.AllowUserToResizeRows = false;
            this.dgvOrderProductListOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderProductListOrder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrderProductListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductListOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderProductListOrder.Enabled = false;
            this.dgvOrderProductListOrder.Location = new System.Drawing.Point(7, 17);
            this.dgvOrderProductListOrder.MultiSelect = false;
            this.dgvOrderProductListOrder.Name = "dgvOrderProductListOrder";
            this.dgvOrderProductListOrder.ReadOnly = true;
            this.dgvOrderProductListOrder.RowHeadersVisible = false;
            this.dgvOrderProductListOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderProductListOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderProductListOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderProductListOrder.Size = new System.Drawing.Size(964, 289);
            this.dgvOrderProductListOrder.TabIndex = 2;
            this.dgvOrderProductListOrder.TabStop = false;
            this.dgvOrderProductListOrder.Enter += new System.EventHandler(this.setEnterStyleDgv);
            this.dgvOrderProductListOrder.Leave += new System.EventHandler(this.setLeaveStyleDgv);
            // 
            // gbOrderForComplete
            // 
            this.gbOrderForComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrderForComplete.Controls.Add(this.dgvOrderForCompile);
            this.gbOrderForComplete.Location = new System.Drawing.Point(4, 4);
            this.gbOrderForComplete.Name = "gbOrderForComplete";
            this.gbOrderForComplete.Size = new System.Drawing.Size(777, 213);
            this.gbOrderForComplete.TabIndex = 0;
            this.gbOrderForComplete.TabStop = false;
            this.gbOrderForComplete.Text = "Заказы для сборки";
            // 
            // dgvOrderForCompile
            // 
            this.dgvOrderForCompile.AllowUserToAddRows = false;
            this.dgvOrderForCompile.AllowUserToDeleteRows = false;
            this.dgvOrderForCompile.AllowUserToResizeColumns = false;
            this.dgvOrderForCompile.AllowUserToResizeRows = false;
            this.dgvOrderForCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderForCompile.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrderForCompile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderForCompile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderForCompile.Location = new System.Drawing.Point(9, 19);
            this.dgvOrderForCompile.MultiSelect = false;
            this.dgvOrderForCompile.Name = "dgvOrderForCompile";
            this.dgvOrderForCompile.ReadOnly = true;
            this.dgvOrderForCompile.RowHeadersVisible = false;
            this.dgvOrderForCompile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderForCompile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderForCompile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderForCompile.Size = new System.Drawing.Size(762, 188);
            this.dgvOrderForCompile.TabIndex = 1;
            this.dgvOrderForCompile.TabStop = false;
            this.dgvOrderForCompile.SelectionChanged += new System.EventHandler(this.dgvOrderForCompile_SelectionChanged);
            this.dgvOrderForCompile.DoubleClick += new System.EventHandler(this.dgvOrderForCompile_DoubleClick);
            this.dgvOrderForCompile.Enter += new System.EventHandler(this.setEnterStyleDgv);
            this.dgvOrderForCompile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOrderForCompile_KeyDown);
            this.dgvOrderForCompile.Leave += new System.EventHandler(this.setLeaveStyleDgv);
            // 
            // statistics
            // 
            this.statistics.Controls.Add(this.gbSales);
            this.statistics.Controls.Add(this.gbStatSupply);
            this.statistics.Controls.Add(this.gbStatGoods);
            this.statistics.Location = new System.Drawing.Point(4, 22);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(986, 545);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "Отчеты";
            this.statistics.UseVisualStyleBackColor = true;
            // 
            // gbSales
            // 
            this.gbSales.Controls.Add(this.btStatSalesClearForm);
            this.gbSales.Controls.Add(this.btStatSalesCreate);
            this.gbSales.Controls.Add(this.cbSalesExcel);
            this.gbSales.Controls.Add(this.groupBox4);
            this.gbSales.Controls.Add(this.label22);
            this.gbSales.Controls.Add(this.tbStatSalesEAN);
            this.gbSales.Location = new System.Drawing.Point(4, 346);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(979, 156);
            this.gbSales.TabIndex = 2;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Продажи";
            // 
            // btStatSalesClearForm
            // 
            this.btStatSalesClearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatSalesClearForm.Location = new System.Drawing.Point(772, 85);
            this.btStatSalesClearForm.Name = "btStatSalesClearForm";
            this.btStatSalesClearForm.Size = new System.Drawing.Size(201, 34);
            this.btStatSalesClearForm.TabIndex = 30;
            this.btStatSalesClearForm.Text = "Очистить форму";
            this.btStatSalesClearForm.UseVisualStyleBackColor = true;
            this.btStatSalesClearForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btStatSalesCreate
            // 
            this.btStatSalesCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatSalesCreate.Location = new System.Drawing.Point(772, 45);
            this.btStatSalesCreate.Name = "btStatSalesCreate";
            this.btStatSalesCreate.Size = new System.Drawing.Size(201, 34);
            this.btStatSalesCreate.TabIndex = 29;
            this.btStatSalesCreate.Text = "Сформировать отчет";
            this.btStatSalesCreate.UseVisualStyleBackColor = true;
            this.btStatSalesCreate.Click += new System.EventHandler(this.btStatSalesCreate_Click);
            // 
            // cbSalesExcel
            // 
            this.cbSalesExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSalesExcel.AutoSize = true;
            this.cbSalesExcel.Location = new System.Drawing.Point(795, 21);
            this.cbSalesExcel.Name = "cbSalesExcel";
            this.cbSalesExcel.Size = new System.Drawing.Size(148, 17);
            this.cbSalesExcel.TabIndex = 28;
            this.cbSalesExcel.Text = "Сформировать в EXCEL";
            this.cbSalesExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tbStatSalesGoodsCountTo);
            this.groupBox4.Controls.Add(this.tbStatSalesGoodsCountFrom);
            this.groupBox4.Controls.Add(this.cbStatSalesWithGoodsCount);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.tbStatSalesBillTo);
            this.groupBox4.Controls.Add(this.tbStatSalesBillFrom);
            this.groupBox4.Controls.Add(this.cbStatSalesWithBill);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.cbStatSalesWithDate);
            this.groupBox4.Controls.Add(this.dtStatSalesDateTo);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.dtStatSalesDateFrom);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(258, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 131);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Условие ";
            // 
            // tbStatSalesGoodsCountTo
            // 
            this.tbStatSalesGoodsCountTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSalesGoodsCountTo.Enabled = false;
            this.tbStatSalesGoodsCountTo.Location = new System.Drawing.Point(279, 74);
            this.tbStatSalesGoodsCountTo.MaxLength = 10;
            this.tbStatSalesGoodsCountTo.Name = "tbStatSalesGoodsCountTo";
            this.tbStatSalesGoodsCountTo.Size = new System.Drawing.Size(127, 20);
            this.tbStatSalesGoodsCountTo.TabIndex = 33;
            this.tbStatSalesGoodsCountTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // tbStatSalesGoodsCountFrom
            // 
            this.tbStatSalesGoodsCountFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSalesGoodsCountFrom.Enabled = false;
            this.tbStatSalesGoodsCountFrom.Location = new System.Drawing.Point(119, 74);
            this.tbStatSalesGoodsCountFrom.MaxLength = 10;
            this.tbStatSalesGoodsCountFrom.Name = "tbStatSalesGoodsCountFrom";
            this.tbStatSalesGoodsCountFrom.Size = new System.Drawing.Size(127, 20);
            this.tbStatSalesGoodsCountFrom.TabIndex = 32;
            this.tbStatSalesGoodsCountFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // cbStatSalesWithGoodsCount
            // 
            this.cbStatSalesWithGoodsCount.AutoSize = true;
            this.cbStatSalesWithGoodsCount.Location = new System.Drawing.Point(8, 76);
            this.cbStatSalesWithGoodsCount.Name = "cbStatSalesWithGoodsCount";
            this.cbStatSalesWithGoodsCount.Size = new System.Drawing.Size(70, 17);
            this.cbStatSalesWithGoodsCount.TabIndex = 31;
            this.cbStatSalesWithGoodsCount.Text = "Позиций";
            this.cbStatSalesWithGoodsCount.UseVisualStyleBackColor = true;
            this.cbStatSalesWithGoodsCount.CheckedChanged += new System.EventHandler(this.cbStatSalesWithCount_CheckedChanged);
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(247, 76);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 14);
            this.label27.TabIndex = 30;
            this.label27.Text = "ДО";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(87, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 14);
            this.label28.TabIndex = 29;
            this.label28.Text = "ОТ";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatSalesBillTo
            // 
            this.tbStatSalesBillTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSalesBillTo.Enabled = false;
            this.tbStatSalesBillTo.Location = new System.Drawing.Point(279, 48);
            this.tbStatSalesBillTo.MaxLength = 10;
            this.tbStatSalesBillTo.Name = "tbStatSalesBillTo";
            this.tbStatSalesBillTo.Size = new System.Drawing.Size(127, 20);
            this.tbStatSalesBillTo.TabIndex = 28;
            this.tbStatSalesBillTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // tbStatSalesBillFrom
            // 
            this.tbStatSalesBillFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSalesBillFrom.Enabled = false;
            this.tbStatSalesBillFrom.Location = new System.Drawing.Point(119, 48);
            this.tbStatSalesBillFrom.MaxLength = 10;
            this.tbStatSalesBillFrom.Name = "tbStatSalesBillFrom";
            this.tbStatSalesBillFrom.Size = new System.Drawing.Size(127, 20);
            this.tbStatSalesBillFrom.TabIndex = 27;
            this.tbStatSalesBillFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // cbStatSalesWithBill
            // 
            this.cbStatSalesWithBill.AutoSize = true;
            this.cbStatSalesWithBill.Location = new System.Drawing.Point(8, 50);
            this.cbStatSalesWithBill.Name = "cbStatSalesWithBill";
            this.cbStatSalesWithBill.Size = new System.Drawing.Size(46, 17);
            this.cbStatSalesWithBill.TabIndex = 17;
            this.cbStatSalesWithBill.Text = "Чек";
            this.cbStatSalesWithBill.UseVisualStyleBackColor = true;
            this.cbStatSalesWithBill.CheckedChanged += new System.EventHandler(this.cbStatSalesWithBill_CheckedChanged);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(247, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 14);
            this.label25.TabIndex = 16;
            this.label25.Text = "ДО";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(87, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 14);
            this.label26.TabIndex = 14;
            this.label26.Text = "ОТ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatSalesWithDate
            // 
            this.cbStatSalesWithDate.AutoSize = true;
            this.cbStatSalesWithDate.Location = new System.Drawing.Point(8, 24);
            this.cbStatSalesWithDate.Name = "cbStatSalesWithDate";
            this.cbStatSalesWithDate.Size = new System.Drawing.Size(72, 17);
            this.cbStatSalesWithDate.TabIndex = 13;
            this.cbStatSalesWithDate.Text = "В период";
            this.cbStatSalesWithDate.UseVisualStyleBackColor = true;
            this.cbStatSalesWithDate.CheckedChanged += new System.EventHandler(this.cbSalesWithDate_CheckedChanged);
            // 
            // dtStatSalesDateTo
            // 
            this.dtStatSalesDateTo.Enabled = false;
            this.dtStatSalesDateTo.Location = new System.Drawing.Point(279, 22);
            this.dtStatSalesDateTo.Name = "dtStatSalesDateTo";
            this.dtStatSalesDateTo.Size = new System.Drawing.Size(127, 20);
            this.dtStatSalesDateTo.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(247, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 14);
            this.label23.TabIndex = 11;
            this.label23.Text = "ДО";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStatSalesDateFrom
            // 
            this.dtStatSalesDateFrom.Enabled = false;
            this.dtStatSalesDateFrom.Location = new System.Drawing.Point(119, 22);
            this.dtStatSalesDateFrom.Name = "dtStatSalesDateFrom";
            this.dtStatSalesDateFrom.Size = new System.Drawing.Size(127, 20);
            this.dtStatSalesDateFrom.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(87, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 14);
            this.label24.TabIndex = 5;
            this.label24.Text = "ОТ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(16, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 14);
            this.label22.TabIndex = 25;
            this.label22.Text = "EAN ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatSalesEAN
            // 
            this.tbStatSalesEAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSalesEAN.Location = new System.Drawing.Point(67, 19);
            this.tbStatSalesEAN.MaxLength = 13;
            this.tbStatSalesEAN.Name = "tbStatSalesEAN";
            this.tbStatSalesEAN.Size = new System.Drawing.Size(185, 20);
            this.tbStatSalesEAN.TabIndex = 26;
            this.tbStatSalesEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // gbStatSupply
            // 
            this.gbStatSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatSupply.Controls.Add(this.groupBox2);
            this.gbStatSupply.Controls.Add(this.btClearStatGbSupply);
            this.gbStatSupply.Controls.Add(this.btSupplierFind);
            this.gbStatSupply.Controls.Add(this.btStatSupplyCreate);
            this.gbStatSupply.Controls.Add(this.tbStatSupplierName);
            this.gbStatSupply.Controls.Add(this.label17);
            this.gbStatSupply.Controls.Add(this.groupBox1);
            this.gbStatSupply.Controls.Add(this.tbStatINN);
            this.gbStatSupply.Controls.Add(this.label15);
            this.gbStatSupply.Controls.Add(this.tbStatOGRN);
            this.gbStatSupply.Controls.Add(this.label12);
            this.gbStatSupply.Location = new System.Drawing.Point(4, 168);
            this.gbStatSupply.Name = "gbStatSupply";
            this.gbStatSupply.Size = new System.Drawing.Size(979, 171);
            this.gbStatSupply.TabIndex = 1;
            this.gbStatSupply.TabStop = false;
            this.gbStatSupply.Text = "Поставки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btStatSearchGoodInSupply);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tbEAN_SearchGoodInSupply);
            this.groupBox2.Location = new System.Drawing.Point(9, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 55);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск товара в поставках";
            // 
            // btStatSearchGoodInSupply
            // 
            this.btStatSearchGoodInSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatSearchGoodInSupply.Location = new System.Drawing.Point(549, 20);
            this.btStatSearchGoodInSupply.Name = "btStatSearchGoodInSupply";
            this.btStatSearchGoodInSupply.Size = new System.Drawing.Size(156, 21);
            this.btStatSearchGoodInSupply.TabIndex = 25;
            this.btStatSearchGoodInSupply.Text = "Поиск товара в поставках";
            this.btStatSearchGoodInSupply.UseVisualStyleBackColor = true;
            this.btStatSearchGoodInSupply.Click += new System.EventHandler(this.btStatSearchGoodInSupply_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 23;
            this.label21.Text = "EAN ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEAN_SearchGoodInSupply
            // 
            this.tbEAN_SearchGoodInSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEAN_SearchGoodInSupply.Location = new System.Drawing.Point(93, 21);
            this.tbEAN_SearchGoodInSupply.Name = "tbEAN_SearchGoodInSupply";
            this.tbEAN_SearchGoodInSupply.Size = new System.Drawing.Size(450, 20);
            this.tbEAN_SearchGoodInSupply.TabIndex = 24;
            this.tbEAN_SearchGoodInSupply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // btClearStatGbSupply
            // 
            this.btClearStatGbSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearStatGbSupply.Location = new System.Drawing.Point(772, 59);
            this.btClearStatGbSupply.Name = "btClearStatGbSupply";
            this.btClearStatGbSupply.Size = new System.Drawing.Size(201, 39);
            this.btClearStatGbSupply.TabIndex = 22;
            this.btClearStatGbSupply.Text = "Очистить форму";
            this.btClearStatGbSupply.UseVisualStyleBackColor = true;
            this.btClearStatGbSupply.Click += new System.EventHandler(this.btClearStatGbSupply_Click);
            // 
            // btSupplierFind
            // 
            this.btSupplierFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSupplierFind.Location = new System.Drawing.Point(668, 77);
            this.btSupplierFind.Name = "btSupplierFind";
            this.btSupplierFind.Size = new System.Drawing.Size(98, 21);
            this.btSupplierFind.TabIndex = 15;
            this.btSupplierFind.Text = "Поиск";
            this.btSupplierFind.UseVisualStyleBackColor = true;
            this.btSupplierFind.Click += new System.EventHandler(this.btSupplierFind_Click);
            // 
            // btStatSupplyCreate
            // 
            this.btStatSupplyCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatSupplyCreate.Location = new System.Drawing.Point(772, 11);
            this.btStatSupplyCreate.Name = "btStatSupplyCreate";
            this.btStatSupplyCreate.Size = new System.Drawing.Size(201, 42);
            this.btStatSupplyCreate.TabIndex = 8;
            this.btStatSupplyCreate.Text = "Сформировать отчет";
            this.btStatSupplyCreate.UseVisualStyleBackColor = true;
            this.btStatSupplyCreate.Click += new System.EventHandler(this.btStatSupplyCreate_Click);
            // 
            // tbStatSupplierName
            // 
            this.tbStatSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatSupplierName.Location = new System.Drawing.Point(102, 78);
            this.tbStatSupplierName.Name = "tbStatSupplierName";
            this.tbStatSupplierName.Size = new System.Drawing.Size(560, 20);
            this.tbStatSupplierName.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(4, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 14);
            this.label17.TabIndex = 13;
            this.label17.Text = "Наименование";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbSupplyWithDate);
            this.groupBox1.Controls.Add(this.dtStatSupplyTo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtStatSupplyFrom);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(294, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие ";
            // 
            // cbSupplyWithDate
            // 
            this.cbSupplyWithDate.AutoSize = true;
            this.cbSupplyWithDate.Location = new System.Drawing.Point(8, 24);
            this.cbSupplyWithDate.Name = "cbSupplyWithDate";
            this.cbSupplyWithDate.Size = new System.Drawing.Size(72, 17);
            this.cbSupplyWithDate.TabIndex = 13;
            this.cbSupplyWithDate.Text = "В период";
            this.cbSupplyWithDate.UseVisualStyleBackColor = true;
            this.cbSupplyWithDate.CheckedChanged += new System.EventHandler(this.cbWithDate_CheckedChanged);
            // 
            // dtStatSupplyTo
            // 
            this.dtStatSupplyTo.Enabled = false;
            this.dtStatSupplyTo.Location = new System.Drawing.Point(279, 22);
            this.dtStatSupplyTo.Name = "dtStatSupplyTo";
            this.dtStatSupplyTo.Size = new System.Drawing.Size(127, 20);
            this.dtStatSupplyTo.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(247, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 14);
            this.label16.TabIndex = 11;
            this.label16.Text = "ДО";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStatSupplyFrom
            // 
            this.dtStatSupplyFrom.Enabled = false;
            this.dtStatSupplyFrom.Location = new System.Drawing.Point(119, 22);
            this.dtStatSupplyFrom.Name = "dtStatSupplyFrom";
            this.dtStatSupplyFrom.Size = new System.Drawing.Size(127, 20);
            this.dtStatSupplyFrom.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(87, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 14);
            this.label18.TabIndex = 5;
            this.label18.Text = "ОТ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatINN
            // 
            this.tbStatINN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatINN.Location = new System.Drawing.Point(67, 49);
            this.tbStatINN.Name = "tbStatINN";
            this.tbStatINN.Size = new System.Drawing.Size(220, 20);
            this.tbStatINN.TabIndex = 11;
            this.tbStatINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(5, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 14);
            this.label15.TabIndex = 10;
            this.label15.Text = "ИНН";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatOGRN
            // 
            this.tbStatOGRN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatOGRN.Location = new System.Drawing.Point(67, 19);
            this.tbStatOGRN.Name = "tbStatOGRN";
            this.tbStatOGRN.Size = new System.Drawing.Size(221, 20);
            this.tbStatOGRN.TabIndex = 9;
            this.tbStatOGRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "ОГРН";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStatGoods
            // 
            this.gbStatGoods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatGoods.Controls.Add(this.btStatClearGbSupply);
            this.gbStatGoods.Controls.Add(this.cbStatGoodCategory);
            this.gbStatGoods.Controls.Add(this.label20);
            this.gbStatGoods.Controls.Add(this.tbStatGoodName);
            this.gbStatGoods.Controls.Add(this.label19);
            this.gbStatGoods.Controls.Add(this.label10);
            this.gbStatGoods.Controls.Add(this.btStatGoodsCreate);
            this.gbStatGoods.Controls.Add(this.chStatGoodsToExcel);
            this.gbStatGoods.Controls.Add(this.gbGoodGbCondition);
            this.gbStatGoods.Controls.Add(this.tbStatPAN);
            this.gbStatGoods.Controls.Add(this.tbStatEAN);
            this.gbStatGoods.Controls.Add(this.label9);
            this.gbStatGoods.Location = new System.Drawing.Point(4, 4);
            this.gbStatGoods.Name = "gbStatGoods";
            this.gbStatGoods.Size = new System.Drawing.Size(979, 146);
            this.gbStatGoods.TabIndex = 0;
            this.gbStatGoods.TabStop = false;
            this.gbStatGoods.Text = "Товар";
            // 
            // btStatClearGbSupply
            // 
            this.btStatClearGbSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatClearGbSupply.Location = new System.Drawing.Point(772, 83);
            this.btStatClearGbSupply.Name = "btStatClearGbSupply";
            this.btStatClearGbSupply.Size = new System.Drawing.Size(201, 34);
            this.btStatClearGbSupply.TabIndex = 21;
            this.btStatClearGbSupply.Text = "Очистить форму";
            this.btStatClearGbSupply.UseVisualStyleBackColor = true;
            this.btStatClearGbSupply.Click += new System.EventHandler(this.btStatClearGoodGroupBox_Click);
            // 
            // cbStatGoodCategory
            // 
            this.cbStatGoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatGoodCategory.FormattingEnabled = true;
            this.cbStatGoodCategory.Location = new System.Drawing.Point(102, 87);
            this.cbStatGoodCategory.Name = "cbStatGoodCategory";
            this.cbStatGoodCategory.Size = new System.Drawing.Size(245, 21);
            this.cbStatGoodCategory.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 14);
            this.label20.TabIndex = 19;
            this.label20.Text = "Категория";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatGoodName
            // 
            this.tbStatGoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatGoodName.Location = new System.Drawing.Point(102, 118);
            this.tbStatGoodName.Name = "tbStatGoodName";
            this.tbStatGoodName.Size = new System.Drawing.Size(560, 20);
            this.tbStatGoodName.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(4, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 14);
            this.label19.TabIndex = 16;
            this.label19.Text = "Наименование";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 7;
            this.label10.Text = "PAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStatGoodsCreate
            // 
            this.btStatGoodsCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStatGoodsCreate.Location = new System.Drawing.Point(772, 43);
            this.btStatGoodsCreate.Name = "btStatGoodsCreate";
            this.btStatGoodsCreate.Size = new System.Drawing.Size(201, 34);
            this.btStatGoodsCreate.TabIndex = 6;
            this.btStatGoodsCreate.Text = "Сформировать отчет";
            this.btStatGoodsCreate.UseVisualStyleBackColor = true;
            this.btStatGoodsCreate.Click += new System.EventHandler(this.btStatGoodsCreate_Click);
            // 
            // chStatGoodsToExcel
            // 
            this.chStatGoodsToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chStatGoodsToExcel.AutoSize = true;
            this.chStatGoodsToExcel.Location = new System.Drawing.Point(795, 19);
            this.chStatGoodsToExcel.Name = "chStatGoodsToExcel";
            this.chStatGoodsToExcel.Size = new System.Drawing.Size(148, 17);
            this.chStatGoodsToExcel.TabIndex = 5;
            this.chStatGoodsToExcel.Text = "Сформировать в EXCEL";
            this.chStatGoodsToExcel.UseVisualStyleBackColor = true;
            // 
            // gbGoodGbCondition
            // 
            this.gbGoodGbCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGoodGbCondition.Controls.Add(this.chStatZeroQuantity);
            this.gbGoodGbCondition.Controls.Add(this.tbStatLessQuantity);
            this.gbGoodGbCondition.Controls.Add(this.label14);
            this.gbGoodGbCondition.Controls.Add(this.label13);
            this.gbGoodGbCondition.Controls.Add(this.tbStatMoreQuantity);
            this.gbGoodGbCondition.Controls.Add(this.label11);
            this.gbGoodGbCondition.Location = new System.Drawing.Point(293, 19);
            this.gbGoodGbCondition.Name = "gbGoodGbCondition";
            this.gbGoodGbCondition.Size = new System.Drawing.Size(473, 58);
            this.gbGoodGbCondition.TabIndex = 4;
            this.gbGoodGbCondition.TabStop = false;
            this.gbGoodGbCondition.Text = "Условие (Количество)";
            // 
            // chStatZeroQuantity
            // 
            this.chStatZeroQuantity.AutoSize = true;
            this.chStatZeroQuantity.Location = new System.Drawing.Point(326, 24);
            this.chStatZeroQuantity.Name = "chStatZeroQuantity";
            this.chStatZeroQuantity.Size = new System.Drawing.Size(69, 17);
            this.chStatZeroQuantity.TabIndex = 7;
            this.chStatZeroQuantity.Text = "Нулевое";
            this.chStatZeroQuantity.UseVisualStyleBackColor = true;
            // 
            // tbStatLessQuantity
            // 
            this.tbStatLessQuantity.Location = new System.Drawing.Point(239, 22);
            this.tbStatLessQuantity.Name = "tbStatLessQuantity";
            this.tbStatLessQuantity.Size = new System.Drawing.Size(66, 20);
            this.tbStatLessQuantity.TabIndex = 9;
            this.tbStatLessQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(184, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 14);
            this.label14.TabIndex = 8;
            this.label14.Text = "Меньше";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(133, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "И / ИЛИ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatMoreQuantity
            // 
            this.tbStatMoreQuantity.Location = new System.Drawing.Point(61, 22);
            this.tbStatMoreQuantity.Name = "tbStatMoreQuantity";
            this.tbStatMoreQuantity.Size = new System.Drawing.Size(66, 20);
            this.tbStatMoreQuantity.TabIndex = 6;
            this.tbStatMoreQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "Больше";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStatPAN
            // 
            this.tbStatPAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatPAN.Location = new System.Drawing.Point(67, 57);
            this.tbStatPAN.Name = "tbStatPAN";
            this.tbStatPAN.Size = new System.Drawing.Size(220, 20);
            this.tbStatPAN.TabIndex = 3;
            // 
            // tbStatEAN
            // 
            this.tbStatEAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatEAN.Location = new System.Drawing.Point(67, 19);
            this.tbStatEAN.Name = "tbStatEAN";
            this.tbStatEAN.Size = new System.Drawing.Size(221, 20);
            this.tbStatEAN.TabIndex = 1;
            this.tbStatEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_tBoxKeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "EAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 595);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Text = "e-shop СКЛАД";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTab.ResumeLayout(false);
            this.supplies.ResumeLayout(false);
            this.gbSupplyElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.gbElementSupply.ResumeLayout(false);
            this.gbElementSupply.PerformLayout();
            this.gbSearchSupplier.ResumeLayout(false);
            this.gbSearchSupplier.PerformLayout();
            this.orders.ResumeLayout(false);
            this.gbProdList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductListOrder)).EndInit();
            this.gbOrderForComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderForCompile)).EndInit();
            this.statistics.ResumeLayout(false);
            this.gbSales.ResumeLayout(false);
            this.gbSales.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbStatSupply.ResumeLayout(false);
            this.gbStatSupply.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStatGoods.ResumeLayout(false);
            this.gbStatGoods.PerformLayout();
            this.gbGoodGbCondition.ResumeLayout(false);
            this.gbGoodGbCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage supplies;
        private System.Windows.Forms.GroupBox gbSearchSupplier;
        private System.Windows.Forms.TextBox tbOgrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCreateSupplier;
        private System.Windows.Forms.Button bSupplierSearch;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bClearSupplierFields;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.TabPage statistics;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.GroupBox gbElementSupply;
        private System.Windows.Forms.GroupBox gbSupplyElements;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.TextBox tbElementQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbElementName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbElementEAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bElementGetSupply;
        private System.Windows.Forms.Button bElementAddElement;
        private System.Windows.Forms.Button bElementCancelSupply;
        private System.Windows.Forms.Button bClearElementField;
        private System.Windows.Forms.Button bCompliteOrder;
        private System.Windows.Forms.Button bGetOrderList;
        private System.Windows.Forms.Button bCreateCompileList;
        private System.Windows.Forms.GroupBox gbProdList;
        private System.Windows.Forms.DataGridView dgvOrderProductListOrder;
        private System.Windows.Forms.GroupBox gbOrderForComplete;
        private System.Windows.Forms.DataGridView dgvOrderForCompile;
        private System.Windows.Forms.GroupBox gbStatGoods;
        private System.Windows.Forms.Button btStatGoodsCreate;
        private System.Windows.Forms.CheckBox chStatGoodsToExcel;
        private System.Windows.Forms.GroupBox gbGoodGbCondition;
        private System.Windows.Forms.CheckBox chStatZeroQuantity;
        private System.Windows.Forms.TextBox tbStatLessQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStatMoreQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbStatPAN;
        private System.Windows.Forms.TextBox tbStatEAN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbStatSupply;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSupplierFind;
        private System.Windows.Forms.Button btStatSupplyCreate;
        private System.Windows.Forms.TextBox tbStatSupplierName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtStatSupplyTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtStatSupplyFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbStatINN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbStatOGRN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbStatGoodName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbStatGoodCategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btClearStatGbSupply;
        private System.Windows.Forms.Button btStatClearGbSupply;
        private System.Windows.Forms.CheckBox cbSupplyWithDate;
        private System.Windows.Forms.Button btStatSearchGoodInSupply;
        private System.Windows.Forms.TextBox tbEAN_SearchGoodInSupply;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.Button btStatSalesClearForm;
        private System.Windows.Forms.Button btStatSalesCreate;
        private System.Windows.Forms.CheckBox cbSalesExcel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbStatSalesGoodsCountTo;
        private System.Windows.Forms.TextBox tbStatSalesGoodsCountFrom;
        private System.Windows.Forms.CheckBox cbStatSalesWithGoodsCount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbStatSalesBillTo;
        private System.Windows.Forms.TextBox tbStatSalesBillFrom;
        private System.Windows.Forms.CheckBox cbStatSalesWithBill;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbStatSalesWithDate;
        private System.Windows.Forms.DateTimePicker dtStatSalesDateTo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtStatSalesDateFrom;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbStatSalesEAN;
    }
}

