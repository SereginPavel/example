namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.earningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.earningsTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.EarningsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.zakazTableAdapter = new WindowsFormsApplication1.DataSet2TableAdapters.ZakazTableAdapter();
            this.dataSet2 = new WindowsFormsApplication1.DataSet2();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idzakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbertableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountofservingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.numbertableDataGridViewTextBoxColumn,
            this.amountofservingsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // earningsBindingSource
            // 
            this.earningsBindingSource.DataMember = "Earnings";
            this.earningsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // earningsTableAdapter
            // 
            this.earningsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.dataSet2;
            // 
            // idzakazDataGridViewTextBoxColumn
            // 
            this.idzakazDataGridViewTextBoxColumn.DataPropertyName = "id_zakaz";
            this.idzakazDataGridViewTextBoxColumn.HeaderText = "id_zakaz";
            this.idzakazDataGridViewTextBoxColumn.Name = "idzakazDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name_dish";
            this.dataGridViewTextBoxColumn1.HeaderText = "name_dish";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Просмотр заказов";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource earningsBindingSource;
        private DataSet1TableAdapters.EarningsTableAdapter earningsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedishDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private DataSet2TableAdapters.ZakazTableAdapter zakazTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountofservingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zakazBindingSource;
    }
}