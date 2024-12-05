namespace kriptoOdevi
{
    partial class anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(101, 24);
            button1.Name = "button1";
            button1.Size = new Size(250, 67);
            button1.TabIndex = 0;
            button1.Text = "Affine Şifreleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(101, 127);
            button2.Name = "button2";
            button2.Size = new Size(250, 71);
            button2.TabIndex = 1;
            button2.Text = "Affine Çözümleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(411, 24);
            button3.Name = "button3";
            button3.Size = new Size(205, 67);
            button3.TabIndex = 2;
            button3.Text = "Sezar Şifreleme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(411, 127);
            button4.Name = "button4";
            button4.Size = new Size(205, 71);
            button4.TabIndex = 3;
            button4.Text = "Sezar Çözümleme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(670, 24);
            button5.Name = "button5";
            button5.Size = new Size(227, 78);
            button5.TabIndex = 4;
            button5.Text = "Kaydırmalı Şifreleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(670, 127);
            button6.Name = "button6";
            button6.Size = new Size(227, 71);
            button6.TabIndex = 5;
            button6.Text = "Kaydırmalı Çözümleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button8.Location = new Point(101, 231);
            button8.Name = "button8";
            button8.Size = new Size(250, 71);
            button8.TabIndex = 1;
            button8.Text = "Yer Değiştirme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button7.Location = new Point(411, 231);
            button7.Name = "button7";
            button7.Size = new Size(250, 71);
            button7.TabIndex = 1;
            button7.Text = "Permütasyon Şifreleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button9.Location = new Point(718, 231);
            button9.Name = "button9";
            button9.Size = new Size(250, 71);
            button9.TabIndex = 1;
            button9.Text = "ZigZag Şifreleme";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button10.Location = new Point(101, 335);
            button10.Name = "button10";
            button10.Size = new Size(250, 71);
            button10.TabIndex = 1;
            button10.Text = "Vigenere";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button8_Click;
            // 
            // anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1042, 497);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "anasayfa";
            Text = "Form1";
            Load += anasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button9;
        private Button button10;
    }
}
