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
    public partial class yerDegistirme : Form
    {

        string metin = "";
        string desifreliMetin = "";
        string sifreliMetin = "";
        string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        string anahtar = "VYZEFMNOÖABCÇDPGĞHIRSŞTUÜİJKL";
        public yerDegistirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //şifreleme
            metin = textBox1.Text.ToUpper();
            sifreliMetin = "";

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == ' ')
                {
                    continue;
                }

                bool harfVarMi = false;
                for (int j = 0; j < 29; j++)
                {
                    if (metin[i] == alfabe[j])//indisleri karşılaştır
                    {
                        harfVarMi = true;
                        sifreliMetin += anahtar[j];
                    }
                }
                if (!harfVarMi)
                {
                    sifreliMetin += metin[i];
                }
            }
            textBox2.Text = sifreliMetin;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deşifreleme
            sifreliMetin = textBox2.Text.ToUpper();
            desifreliMetin = "";

            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                bool harfVarMi = false;
                for (int j = 0; j < 29; j++)
                {
                    if (sifreliMetin[i] == anahtar[j])
                    {
                        harfVarMi = true;
                        desifreliMetin += alfabe[j];
                    }
                }
                if (!harfVarMi)
                {
                    desifreliMetin += sifreliMetin[i];
                }
            }
            textBox3.Text = desifreliMetin;
        }

        private void yerDegistirme_Load(object sender, EventArgs e)
        {

        }
    }
}
