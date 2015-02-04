using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO.MemoryMappedFiles;
using System.IO;
namespace KP_test_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int key = 0;
        RC4 ob = new RC4();
        private bool IsCyrillic(char c)
        {
            if (c >= '\u0400' && c <= '\u04FF')
                return true;
            else return false;
        }
        private bool IsLatin(char c)
        {
            if ((c >= 'a') && (c <= 'z') || (c >= 'A') && (c <= 'Z'))
                return true;
            else return false;
        }
        public bool Passwd(string pass)  // 
        {
            bool latinaValue = false, punctuation = false, cyrillicValue = false, space=false;

            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false))
            {
                latinaValue = true;
                return latinaValue;
            }

            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (IsLatin(pass[i]))
                        latinaValue = true;
                    if (IsCyrillic(pass[i]))
                        cyrillicValue = true;
                    if (char.IsPunctuation(pass[i]))
                        punctuation = true;
                }
                    return   latinaValue && cyrillicValue && punctuation;          
            }
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (IsLatin(pass[i]))
                        latinaValue = true;
                    if (IsCyrillic(pass[i]))
                        cyrillicValue = true;
                }
                    return  latinaValue &&  cyrillicValue;  
            }
            if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (IsLatin(pass[i]))
                        latinaValue = true;
                    if (char.IsPunctuation(pass[i]))
                        punctuation = true;
                }
                    return latinaValue &&  punctuation; 
            }
            if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (IsCyrillic(pass[i]))
                        cyrillicValue = true;
                    if (char.IsPunctuation(pass[i]))
                        punctuation = true;
                }
                    return cyrillicValue && punctuation;
            }
            if (checkBox1.Checked == true)
              {
                  for (int i = 0; i < pass.Length; i++)
                  {
                      if (IsLatin(pass[i]))
                          latinaValue = true;
                  }
                      return latinaValue;
              }
             if (checkBox2.Checked == true)
                {
                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (IsCyrillic(pass[i]))
                            cyrillicValue = true;
                    }
                        return cyrillicValue;
                 }
             if (checkBox3.Checked == true)
                {
                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (char.IsPunctuation(pass[i]))
                            punctuation = true;
                    }
                        return punctuation;
                }
             return false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "")
                MessageBox.Show("Введите парольную фразу и получите из неё ключ!");
            else
            {
                byte[] bytekey = Encoding.Default.GetBytes(textBox2.Text);
                ob.text = ob.ReadFile();
                if (ob.text == null)
                    return;
                ob.init(bytekey);
                MessageBox.Show("Укажите файл, куда будет получен результат Шифрования");
                ob.WriteByteArrayToFile1(ob.code(), ob.ReadFile2());
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Парольную фразу");
                textBox2.Enabled = false;
                textBox2.Text = "";
                button3.Enabled = false;
                return;
            }

            if (textBox1.Text.Length < Convert.ToInt32(domainUpDown1.Text))
            {
                MessageBox.Show("Слишком маленькая парольная фраза");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Enabled = false;
                button3.Enabled = false;
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Подтвердите парольную фразу");
                textBox2.Enabled = false;
                button3.Enabled = false;
                return;
            }

            if (textBox3.Text != textBox1.Text)
            {
                MessageBox.Show("Подтверждение парольной фразы неверно!");
                textBox3.Text = "";
                textBox2.Text = "";
                textBox2.Enabled = false;
                button3.Enabled = false;
                return;

            }

            if (!Passwd(textBox1.Text))
            {
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Enabled = false;
                button3.Enabled = false;
                MessageBox.Show("Некорректно введена парольная фраза! Попробуйте еще раз");
                return;
            }

       
            if (textBox3.Text == textBox1.Text && (textBox1.Text.Length >= Convert.ToInt32(domainUpDown1.Text)))
            {
                button3.Enabled = true;
                MD5 md5 = new MD5CryptoServiceProvider();
                Byte[] p = md5.ComputeHash(Encoding.Default.GetBytes(textBox1.Text));
                 string q="";
                for (int i = 0; i < 16; i++)                 
                      q += Convert.ToString(p[i], 16);
                textBox2.Text = q;
                textBox2.Enabled = true;
            }             
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void шифроватьРасшифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void алгоритмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    MessageBox.Show("Введите парольную фразу и получите из неё ключ!");
                else
                {
                    byte[] bytekey = Encoding.Default.GetBytes(textBox2.Text);
                    ob.text = ob.ReadFile();
                    ob.init(bytekey);
                    ob.WriteByteArrayToFile1(ob.code(), ob.ReadFile2());

                }
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            form4.textBox2.Text=this.textBox2.Text;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    MessageBox.Show("Введите парольную фразу и получите из неё ключ!");
                else
                {
                    byte[] bytekey = Encoding.Default.GetBytes(textBox2.Text);
                    ob.text = ob.ReadFile1();
                    if (ob.text == null)
                        return;
                    ob.init(bytekey);
                    MessageBox.Show("Укажите файл, куда будет получен результат Расшифрования");
                    ob.WriteByteArrayToFile2(ob.code(), ob.ReadFile2());
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
