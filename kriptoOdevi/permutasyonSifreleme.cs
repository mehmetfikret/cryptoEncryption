using System;
using System.Windows.Forms;

namespace kriptoOdevi
{
    public partial class permutasyonSifreleme : Form
    {
        string girilenMetin = "";
        string cozulmusMetin = "";
        string sifreliMetin = "";
        int[] anahtar = { 2, 4, 3, 5, 1 }; // Permütasyon anahtarı

        public permutasyonSifreleme()
        {
            InitializeComponent();
        }

        void EkHarfEkle()
        {
            int neKadarEksik = girilenMetin.Length % anahtar.Length;
            if (neKadarEksik != 0)
            {
                int fark = anahtar.Length - neKadarEksik;
                for (int i = 0; i < fark; i++)
                {
                    girilenMetin += 'M'; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Şifreleme
            girilenMetin = acikMetinBox.Text.ToUpper();
            sifreliMetin = "";
            EkHarfEkle();
            sifreliMetinBox.Text = "";

            for (int i = 0; i < girilenMetin.Length; i += anahtar.Length)
            {
                foreach (int index in anahtar)
                {
                    sifreliMetin += girilenMetin[i + index - 1];
                    // Permütasyon anahtarına göre metni yeniden düzenle
                }
            }
            sifreliMetinBox.Text = sifreliMetin.Replace(" ", ""); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Deşifreleme
            cozulmusMetin = "";
            for (int i = 0; i < sifreliMetin.Length; i += anahtar.Length)
            {
                for (int j = 0; j < anahtar.Length; j++)
                {
                    int index = Array.IndexOf(anahtar, j + 1);
                    // Anahtar değerlerinin indeksini bul

                    cozulmusMetin += sifreliMetin[i + index];
                }
            }
            desifrelenmisMetin.Text = cozulmusMetin.Replace(" ", ""); ;
        }

        private void permutasyonSifreleme_Load(object sender, EventArgs e)
        {

        }
    }
}