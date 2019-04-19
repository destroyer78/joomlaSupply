namespace joomShoppingSupply
{
    partial class getClickID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStat
            // 
            this.dgvStat.AllowUserToAddRows = false;
            this.dgvStat.AllowUserToDeleteRows = false;
            this.dgvStat.AllowUserToResizeRows = false;
            this.dgvStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStat.Location = new System.Drawing.Point(12, 12);
            this.dgvStat.MultiSelect = false;
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.RowHeadersVisible = false;
            this.dgvStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStat.Size = new System.Drawing.Size(567, 294);
            this.dgvStat.TabIndex = 1;
            this.dgvStat.DoubleClick += new System.EventHandler(this.dgvStat_DoubleClick);
            this.dgvStat.Enter += new System.EventHandler(this.setEnterStyleDgv);
            this.dgvStat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStat_KeyDown);
            this.dgvStat.Leave += new System.EventHandler(this.setLeaveStyleDgv);
            // 
            // getClickID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 318);
            this.Controls.Add(this.dgvStat);
            this.Name = "getClickID";
            this.Text = "Поиск поставщика";
            this.Load += new System.EventHandler(this.SearchSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStat;
    }
}