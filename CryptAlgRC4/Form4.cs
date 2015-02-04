using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KP_test_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        RC4 ob = new RC4();

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Введите текст для шифрования");
            else
            {
                byte[] bytekey = Encoding.Default.GetBytes(textBox2.Text);
                ob.text = Encoding.Default.GetBytes(textBox1.Text);
                ob.init(bytekey);
                textBox1.Text = Encoding.Default.GetString(ob.code());
                MessageBox.Show("Сообщение зашифровано(расшифровано)!");
            }
        }

        public void Form4_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Введите текст для шифрования");
            else
                ob.WriteByteArrayToFile3(Encoding.Default.GetBytes(textBox1.Text), ob.ReadFile2());          
        }
    }
}
