using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(@"d:\eat4.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connectn = new SqlConnection("Data Source=PAVEL\\SQLEXPRESS;Initial Catalog=restaurant;Integrated Security=True");
            connectn.Open();
            SqlCommand Com1 = new SqlCommand("select id_zakaz, summa_zakaz from Earnings where id_zakaz=@id_zakaz", connectn);
            SqlParameter myParam1 = new SqlParameter("@id_zakaz", SqlDbType.Int);
            myParam1.Value = textBox1.Text;
            Com1.Parameters.Add(myParam1);
            SqlDataReader dr = Com1.ExecuteReader();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 0;
            dataGridView1.Columns.Add("dish", "Номер заказа");
            dataGridView1.Columns.Add("cost", "Стоимость");
            int i = 0;
            while (dr.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1["dish", i].Value = dr["id_zakaz"].ToString();
                dataGridView1["cost", i].Value = dr["summa_zakaz"].ToString();
                i++;
            }
            dr.Close();   
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connectn = new SqlConnection("Data Source=PAVEL\\SQLEXPRESS;Initial Catalog=restaurant;Integrated Security=True");
            connectn.Open();
            SqlCommand Com1 = new SqlCommand("select id_zakaz,date_zakaz, summa_zakaz from Earnings where summa_zakaz>@money_zak", connectn);
            SqlParameter myParam1 = new SqlParameter("@money_zak", SqlDbType.Money);
            myParam1.Value = textBox2.Text;
            Com1.Parameters.Add(myParam1);
            SqlDataReader dr = Com1.ExecuteReader();
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 0;          
            dataGridView2.Columns.Add("dish", "Номер заказа");
            dataGridView2.Columns.Add("dat", "Дата");
            dataGridView2.Columns.Add("cost", "Стоимость");
            int i = 0;
            while (dr.Read())
            {
                dataGridView2.Rows.Add();
                dataGridView2["dish", i].Value = dr["id_zakaz"].ToString();
                dataGridView2["dat", i].Value = dr["date_zakaz"].ToString();
                dataGridView2["cost", i].Value = dr["summa_zakaz"].ToString();
                i++;
            }
            dr.Close();   
        }
    }
}
