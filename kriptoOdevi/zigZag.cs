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
    public partial class zigZag : Form
    {
public zigZag()
        {
            InitializeComponent();
        }
        private void zigZag_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = textBox1.Text.ToUpper();
            int numRows = (int)numericUpDown1.Value;

            string encryptedText = ZigZagCipher.Encrypt(plainText, numRows);
            textBox2.Text = encryptedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string encryptedText = textBox2.Text.ToUpper();
            int numRows = (int)numericUpDown1.Value;

            string decryptedText = ZigZagCipher.Decrypt(encryptedText, numRows);
            textBox3.Text = decryptedText;
        }
    }

    public class ZigZagCipher
    {
        public static string Encrypt(string plainText, int numRows)
        {
            if (numRows <= 1)
                return plainText;

            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            int row = 0;
            bool down = true;

            foreach (char c in plainText)
            {
                rows[row].Append(c);

                if (row == 0)
                    down = true;
                else if (row == numRows - 1)
                    down = false;

                row += down ? 1 : -1;
            }

            StringBuilder encryptedText = new StringBuilder();
            foreach (var segment in rows)
            {
                encryptedText.Append(segment);
            }

            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, int numRows)
        {
            if (numRows <= 1)
                return encryptedText;

            int length = encryptedText.Length;
            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            int row = 0;
            bool down = true;

            // Önce şifrelenmiş metni zigzag desenine göre düzenleyelim
            foreach (char c in encryptedText)
            {
                rows[row].Append(c);

                if (row == 0)
                    down = true;
                else if (row == numRows - 1)
                    down = false;

                row += down ? 1 : -1;
            }

            // Ardından zigzag desenindeki sıraya göre harfleri çıkararak metni çözelim
            StringBuilder decryptedText = new StringBuilder();
            row = 0;
            down = true;
            int charIndex = 0;

            for (int i = 0; i < numRows; i++)
            {
                int segmentLength = rows[i].Length;

                for (int j = 0; j < segmentLength; j++)
                {
                    if (row == 0)
                        down = true;
                    else if (row == numRows - 1)
                        down = false;

                    if (rows[i][j] != '\0')
                    {
                        decryptedText.Append(rows[i][j]);
                        charIndex++;
                    }

                    row += down ? 1 : -1;

                    if (charIndex == length)
                        break;
                }
            }

            return decryptedText.ToString();
        }
    }
}

