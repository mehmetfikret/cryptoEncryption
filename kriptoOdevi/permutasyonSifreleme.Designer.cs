namespace kriptoOdevi
{
    partial class permutasyonSifreleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            acikMetinBox = new TextBox();
            sifreliMetinBox = new TextBox();
            desifrelenmisMetin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 110);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Şifrele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 225);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Şifreyi Çöz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PlainTextBox
            // 
            acikMetinBox.Location = new Point(187, 61);
            acikMetinBox.Multiline = true;
            acikMetinBox.Name = "PlainTextBox";
            acikMetinBox.Size = new Size(297, 27);
            acikMetinBox.TabIndex = 2;
            // 
            // EncryptedTextBox
            // 
            sifreliMetinBox.Location = new Point(187, 164);
            sifreliMetinBox.Multiline = true;
            sifreliMetinBox.Name = "EncryptedTextBox";
            sifreliMetinBox.Size = new Size(297, 27);
            sifreliMetinBox.TabIndex = 3;
            // 
            // DecryptedTextBox
            // 
            desifrelenmisMetin.Location = new Point(187, 282);
            desifrelenmisMetin.Multiline = true;
            desifrelenmisMetin.Name = "DecryptedTextBox";
            desifrelenmisMetin.Size = new Size(297, 27);
            desifrelenmisMetin.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 64);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 6;
            label1.Text = "Şifrelenecek Metin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 167);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Şifreli Hali";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 289);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 8;
            label3.Text = "Şifrenin Çözülmüş Hali";
            // 
            // permutasyonSifreleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(desifrelenmisMetin);
            Controls.Add(sifreliMetinBox);
            Controls.Add(acikMetinBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "permutasyonSifreleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "permutasyonSifreleme";
            Load += permutasyonSifreleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox acikMetinBox;
        private TextBox sifreliMetinBox;
        private TextBox desifrelenmisMetin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}