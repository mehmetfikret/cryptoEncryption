namespace kriptoOdevi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreOlusturma CF = new sifreOlusturma();
            this.Hide();
            CF.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifreCozumleme DCF = new sifreCozumleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sezarSifreleme DCF = new sezarSifreleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sezarCozumleme DCF = new sezarCozumleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anahtarSifreleme DCF = new anahtarSifreleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            anahtarCozumleme DCF = new anahtarCozumleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            vigenere DCF = new vigenere();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            permutasyonSifreleme DCF = new permutasyonSifreleme();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zigZag DCF = new zigZag();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }
    }
}
