using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(@"d:\eat1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.dataSet1.Menu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Earnings". При необходимости она может быть перемещена или удалена.
            this.earningsTableAdapter.Fill(this.dataSet1.Earnings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.dataSet2.suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter1.Fill(this.dataSet2.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.dataSet1.Zakaz);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zakazTableAdapter.Update(dataSet1.Zakaz);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
