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
    public partial class sezarCozumleme : Form
    {
        string[] alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        public sezarCozumleme()
        {
            InitializeComponent();
        }

        private void sezarCozumleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;

            int harf = 0, sifre = 0;
            string sifreMetni = "";

            metin = metin.ToUpper();

            for (int i = 0; i < metin.Length; i++)
            {
                string guncelHarf = metin.Substring(i, 1);

                for (int j = 0; j < alfabe.Length; j++)
                {
                    if (guncelHarf == alfabe[j])
                    {
                        break;
                    }
                    harf++;

                }
                if (guncelHarf == " ")
                {
                    sifreMetni += " ";
                    harf = 0;
                }
                else
                {
                    sifre = (harf - 3 + 29) % 29;
                    harf = 0;
                    sifreMetni += alfabe[sifre];
                }
            }

            richTextBox2.Text = sifreMetni;
        }
    }
}
