using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;

namespace KP_test_
{
    public class RC4
    {
     //   public   int count = 0;
        public byte[] text; //текст для шифрования/расшифрования
        private byte[] S = new byte[256];
        private int i = 0;
        private int j = 0;
        //просто для удобства обмена
        private void swap(byte[] array, int ind1, int ind2)
        {
            byte temp = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = temp;
        }

        //инициализация, алгоритм ключевого расписания
        public void init(byte[] key)
        {
            for (i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
            }

            j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % key.Length]) % 256;
                swap(S, i, j);
            }
            i = j = 0;
        }
        //генератор псевдослучайной последовательности
        public byte kword()
        {
            i = (i + 1) % 256;
            j = (j + S[i]) % 256;
            swap(S, i, j);
            byte K = S[(S[i] + S[j]) % 256];
            return K;
        }

        //функция шифрования/расшифрования
        public byte[] code()
        {
            byte[] data = text.Take(text.Length).ToArray();
            byte[] res = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                res[i] = (byte)(data[i] ^ kword());
            }
            return res;
        }
        //бинарная запись в файл и проверка, расшифрован ли текст или нет,
        //в случае успеха удаляется сигнатура(строка "RC4")
        public void WriteByteArrayToFile2(Byte[] buffer, string fileName)
        {
            if (fileName == "")
                return;
            else
            {
                try
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter bw = new BinaryWriter(fs);

                    for (int i = 0; i < buffer.Length; i++)
                        bw.Write(buffer[i]);



                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
       
                    if (File.ReadAllText(fileName).Contains("RC4"))
                     {
                        Encoding enc = Encoding.GetEncoding(1251);
                        StreamReader rs = new StreamReader(fileName, enc);
                        string str1 = rs.ReadToEnd().TrimEnd('R','C','4');
                        rs.Close();
                       StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite));
                       sw.Write(str1);
                       sw.Close();                      
                         MessageBox.Show("файл расшифрован");
                     }
                     else
                         MessageBox.Show("Файл не удалось расшифровать(неправильно подобран ключ)");
   
            }
        }
        //бинарная зипись в файл
        public void WriteByteArrayToFile1(Byte[] buffer, string fileName)
        {
            if (fileName == "")
                return;
            else
            {
                try
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter bw = new BinaryWriter(fs);

                    for (int i = 0; i < buffer.Length; i++)
                        bw.Write(buffer[i]);
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                MessageBox.Show("Файл зашифрован");
            }
        }

        //бинарная запись в файл для текстового сообщения
        public void WriteByteArrayToFile3(Byte[] buffer, string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                for (int i = 0; i < buffer.Length; i++)
                    bw.Write(buffer[i]);
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Выбор файла из каталога, представление данных в виде массива байт 
        //и добавление к файлу шифрования сигнатуры(строка "RC4")
        public Byte[] ReadFile()
        {
            //Byte[] res = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\projects\\KP(test)\\bin\\Debug";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                {
                           //Добавление сигнатуры к шифруемому тексту
                            byte[] file_data = File.ReadAllBytes(openFileDialog1.SafeFileName);                     
                            byte[] base_byte = file_data.Concat( Encoding.Default.GetBytes("RC4")).ToArray();                    
                            return base_byte;
                        }
                    }
            else
                return null;
        
        }
        //Выбор файла из каталога и представление данных в виде массива байт
        public Byte[] ReadFile1()
        {
            Byte[] buffer = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\projects\\KP(test)\\bin\\Debug";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.SafeFileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    long numBytes = new FileInfo(openFileDialog1.SafeFileName).Length;
                    buffer = br.ReadBytes((int)numBytes);
                    br.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                return buffer;
            }
            else
                return buffer;
        }

        //выбор файла из каталога с возможностью создания собственного файла
        public string ReadFile2()
        {           
            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            openFileDialog1.InitialDirectory = "D:\\projects\\KP(test)\\bin\\Debug";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                return openFileDialog1.FileName;
            }
            else
                return "";
        }
    }
}