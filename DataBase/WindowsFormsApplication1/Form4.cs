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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(@"d:\eat1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Zakaz". При необходимости она может быть перемещена или удалена.
this.zakazTableAdapter.Fill(this.dataSet2.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Earnings". При необходимости она может быть перемещена или удалена.
            this.earningsTableAdapter.Fill(this.dataSet1.Earnings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.earningsTableAdapter.Update(this.dataSet1.Earnings);
        }
    }
}
