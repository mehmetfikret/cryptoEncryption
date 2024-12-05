namespace kriptoOdevi
{
    partial class yerDegistirme
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 61);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(323, 108);
            button1.Name = "button1";
            button1.Size = new Size(132, 55);
            button1.TabIndex = 1;
            button1.Text = "Şifrele >>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(486, 108);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 61);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(301, 230);
            button2.Name = "button2";
            button2.Size = new Size(154, 56);
            button2.TabIndex = 3;
            button2.Text = "Şifreyi Çöz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 345);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 62);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 79);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 5;
            label1.Text = "Şifrelenecek Metin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 79);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 5;
            label2.Text = "Şifrelenmiş Metin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 322);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 5;
            label3.Text = "Çözülmüş Metin";
            // 
            // yerDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "yerDegistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "yerDegistirme";
            Load += yerDegistirme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}