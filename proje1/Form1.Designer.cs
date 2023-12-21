namespace proje1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            txt3 = new TextBox();
            txt4 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MidnightBlue;
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(51, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "                Hesap Makinesi";
            // 
            // txt2
            // 
            txt2.Location = new Point(229, 163);
            txt2.Name = "txt2";
            txt2.PasswordChar = '*';
            txt2.Size = new Size(180, 38);
            txt2.TabIndex = 4;
            // 
            // txt1
            // 
            txt1.Location = new Point(229, 83);
            txt1.Name = "txt1";
            txt1.Size = new Size(180, 38);
            txt1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(229, 234);
            button1.Name = "button1";
            button1.Size = new Size(180, 61);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 163);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(204, 41);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 80);
            label4.Name = "label4";
            label4.Size = new Size(204, 41);
            label4.TabIndex = 0;
            label4.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 163);
            label3.Name = "label3";
            label3.Size = new Size(92, 41);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(229, 234);
            button2.Name = "button2";
            button2.Size = new Size(180, 61);
            button2.TabIndex = 2;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt3
            // 
            txt3.Location = new Point(229, 83);
            txt3.Name = "txt3";
            txt3.Size = new Size(180, 38);
            txt3.TabIndex = 3;
            // 
            // txt4
            // 
            txt4.Location = new Point(229, 163);
            txt4.Name = "txt4";
            txt4.PasswordChar = '*';
            txt4.Size = new Size(180, 38);
            txt4.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MidnightBlue;
            groupBox2.Controls.Add(txt4);
            groupBox2.Controls.Add(txt3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(646, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 329);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "                  halka arz kazancını bul";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1170, 468);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txt2;
        private TextBox txt1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Button button2;
        private TextBox txt3;
        private TextBox txt4;
        private GroupBox groupBox2;
    }
}