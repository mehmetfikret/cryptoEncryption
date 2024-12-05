namespace kriptoOdevi
{
    partial class anahtarCozumleme
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(425, 76);
            button1.Name = "button1";
            button1.Size = new Size(226, 141);
            button1.TabIndex = 0;
            button1.Text = "Kaydırmalı Çözümleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(52, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 241);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(231, 77);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(125, 241);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // anahtarCozumleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "anahtarCozumleme";
            Text = "kaydirmaliCozumleme";
            Load += anahtarCozumleme_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}