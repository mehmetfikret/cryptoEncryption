namespace kriptoOdevi
{
    partial class sifreCozumleme
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
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(265, 152);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(204, 286);
            richTextBox2.TabIndex = 17;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(29, 152);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(171, 286);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(447, 20);
            button1.Name = "button1";
            button1.Size = new Size(97, 90);
            button1.TabIndex = 13;
            button1.Text = "Çözümleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Location = new Point(234, 50);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 10;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 9;
            label1.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Menu;
            label4.Location = new Point(29, 129);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 18;
            label4.Text = "Çözümlecek Metin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Menu;
            label5.Location = new Point(265, 129);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 19;
            label5.Text = "Çözümlenmiş Hali";
            // 
            // sifreCozumleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sifreCozumleme";
            Text = "sifreCozumleme";
            Load += sifreCozumleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}