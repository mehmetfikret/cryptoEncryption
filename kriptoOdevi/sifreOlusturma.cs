using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kriptoOdevi
{
    public partial class sifreOlusturma : Form
    {  
        public sifreOlusturma()
        {
            InitializeComponent();
        }
        string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        int a, b, mod, k;
        string metin, şifreliMetin;
        string z;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            mod = 29;

            if (a % mod != 0)
            {
                metin = richTextBox1.Text.ToUpper();
                şifreliMetin = "";


                for (int i = 0; i < metin.Length; i++)
                {
                    if (alfabe.IndexOf(metin[i]) == -1)
                    {
                        şifreliMetin += metin[i].ToString();
                    }

                    else
                    {

                        k = alfabe.IndexOf(metin[i]);
                        z = alfabe[((k * a + b) % mod)].ToString();

                        şifreliMetin += z;

                    }

                }

                richTextBox2.Text = şifreliMetin;
            }

            else
            {
                MessageBox.Show("a ve m Değerleri Birbirine Tam Bölünememelidir.");
            }

        }
    }
}
