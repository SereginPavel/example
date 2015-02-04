namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication1.DataSet2();
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.zakazTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.ZakazTableAdapter();
            this.zakazTableAdapter1 = new WindowsFormsApplication1.DataSet2TableAdapters.ZakazTableAdapter();
            this.suppliersTableAdapter = new WindowsFormsApplication1.DataSet2TableAdapters.suppliersTableAdapter();
            this.earningsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.EarningsTableAdapter();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.MenuTableAdapter();
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idzakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numbertableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountofservingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.numbertableDataGridViewTextBoxColumn,
            this.amountofservingsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 166);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataMember = "Zakaz";
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter1
            // 
            this.zakazTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // earningsTableAdapter
            // 
            this.earningsTableAdapter.ClearBeforeFill = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dataSet1;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.dataSet2;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            this.menuBindingSource1.DataSource = this.dataSet1BindingSource1;
            // 
            // dataSet1BindingSource2
            // 
            this.dataSet1BindingSource2.DataSource = this.dataSet1;
            this.dataSet1BindingSource2.Position = 0;
            // 
            // zakazBindingSource1
            // 
            this.zakazBindingSource1.DataMember = "Zakaz";
            this.zakazBindingSource1.DataSource = this.dataSet1BindingSource2;
            // 
            // idzakazDataGridViewTextBoxColumn
            // 
            this.idzakazDataGridViewTextBoxColumn.DataPropertyName = "id_zakaz";
            this.idzakazDataGridViewTextBoxColumn.HeaderText = "id_zakaz";
            this.idzakazDataGridViewTextBoxColumn.Name = "idzakazDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name_dish";
            this.dataGridViewTextBoxColumn1.DataSource = this.menuBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "name_dish";
            this.dataGridViewTextBoxColumn1.HeaderText = "name_dish";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // numbertableDataGridViewTextBoxColumn
            // 
            this.numbertableDataGridViewTextBoxColumn.DataPropertyName = "number_table";
            this.numbertableDataGridViewTextBoxColumn.HeaderText = "number_table";
            this.numbertableDataGridViewTextBoxColumn.Name = "numbertableDataGridViewTextBoxColumn";
            // 
            // amountofservingsDataGridViewTextBoxColumn
            // 
            this.amountofservingsDataGridViewTextBoxColumn.DataPropertyName = "amount_of_servings";
            this.amountofservingsDataGridViewTextBoxColumn.HeaderText = "amount_of_servings";
            this.amountofservingsDataGridViewTextBoxColumn.Name = "amountofservingsDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 225);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Оформить заказ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn namedishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ZakazTableAdapter zakazTableAdapter;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.ZakazTableAdapter zakazTableAdapter1;
        private DataSet2TableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private DataSet1TableAdapters.EarningsTableAdapter earningsTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DataSet1TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private System.Windows.Forms.BindingSource zakazBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource2;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountofservingsDataGridViewTextBoxColumn;
    }
}