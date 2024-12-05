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
    public partial class vigenere : Form
    {
        string metin = "";
        string sifreliMetin = "";
        string desifreliMetin = "";
        string anahtarKelime = "";
        int n; //anahtar kelime uzunluğu
        int[] anahtarRakamlari;
        string ekKarakter = "M";
        string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

        public vigenere()
        {
            InitializeComponent();
        }

        void AnahtarOlustur()
        {
            anahtarKelime = textBox4.Text.ToUpper();
            n = anahtarKelime.Length;
            anahtarRakamlari = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    if (anahtarKelime[i] == alfabe[j])
                    {
                        anahtarRakamlari[i] = j;// Harfin indeksini saklar
                    }
                }
            }
        }

        void EkKarakterEkle()
        {
            int neKadarEksik = metin.Length % n;
            if (neKadarEksik != 0)
            {
                int fark2 = n - neKadarEksik;
                for (int i = 0; i < fark2; i++)
                {
                    metin += ekKarakter;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Şifrele
            metin = textBox1.Text.ToUpper().Replace(" ", "");
            sifreliMetin = "";
            AnahtarOlustur();
            EkKarakterEkle();
            int i = 0;
            while (i < metin.Length)
            {
                for (int j = 0; j < n; j++)
                {
                   
                    bool sonuc = false;
                    for (int k = 0; k < 29; k++)
                    {             
                        if (metin[i + j] == alfabe[k])
                        {
                            
                            sonuc = true;
                            int sayi = k + anahtarRakamlari[j];
                            // Harfin indeksine anahtar kelimenin indeksi eklenir

                            sayi = sayi % 29;          
                            
                            sifreliMetin += alfabe[sayi]; // Şifrelenmiş metine harf eklenir
                            
                        }
                        
                    }
                    if (!sonuc)
                    {
                       
                        sifreliMetin += metin[i + j]; // Metinden harf alınır
                    }

                }
                i += n;
            }
            
            textBox2.Text = sifreliMetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ŞİFRE ÇÖZ
            sifreliMetin = textBox2.Text.ToUpper();
            desifreliMetin = "";

            int i = 0;
            while (i < metin.Length)
            {
                for (int j = 0; j < n; j++)
                {
                   

                    bool sonuc = false;
                    for (int k = 0; k < 29; k++)
                    {

                        if (sifreliMetin[i + j] == alfabe[k])
                        {
                            sonuc = true;
                            int sayi = k - anahtarRakamlari[j];

                            if (sayi < 0)
                                sayi += 29;

                            sayi = sayi % 29;
                            desifreliMetin += alfabe[sayi];
                        }
                    }
                    if (!sonuc)
                        desifreliMetin += alfabe[i + j];
                }
                i += n;
            }
            textBox3.Text = desifreliMetin;
        }
    }
}
