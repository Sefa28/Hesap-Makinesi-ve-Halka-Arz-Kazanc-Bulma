using System.Windows.Forms;

namespace proje1
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            adettxt = new TextBox();
            label4 = new Label();
            adi = new TextBox();
            fiyattxt = new TextBox();
            button1 = new Button();
            guntxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            liste = new ListBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textara = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkKhaki;
            groupBox1.Controls.Add(adettxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(adi);
            groupBox1.Controls.Add(fiyattxt);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(guntxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // adettxt
            // 
            adettxt.BackColor = Color.Goldenrod;
            adettxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            adettxt.Location = new Point(311, 267);
            adettxt.Name = "adettxt";
            adettxt.Size = new Size(266, 38);
            adettxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(116, 267);
            label4.Name = "label4";
            label4.Size = new Size(189, 31);
            label4.TabIndex = 9;
            label4.Text = "Kaç adet aldınız:";
            // 
            // adi
            // 
            adi.BackColor = Color.Goldenrod;
            adi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            adi.Location = new Point(311, 55);
            adi.Name = "adi";
            adi.Size = new Size(266, 38);
            adi.TabIndex = 8;
            // 
            // fiyattxt
            // 
            fiyattxt.BackColor = Color.Goldenrod;
            fiyattxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fiyattxt.Location = new Point(311, 129);
            fiyattxt.Name = "fiyattxt";
            fiyattxt.Size = new Size(266, 38);
            fiyattxt.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(363, 331);
            button1.Name = "button1";
            button1.Size = new Size(214, 54);
            button1.TabIndex = 6;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guntxt
            // 
            guntxt.BackColor = Color.Goldenrod;
            guntxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            guntxt.Location = new Point(311, 192);
            guntxt.Name = "guntxt";
            guntxt.Size = new Size(266, 38);
            guntxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 179);
            label3.Name = "label3";
            label3.Size = new Size(287, 66);
            label3.TabIndex = 2;
            label3.Text = "Kaç günük değer artışını \r\nögrenmek istiyorsunuz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 129);
            label2.Name = "label2";
            label2.Size = new Size(242, 31);
            label2.TabIndex = 1;
            label2.Text = "Halka arz açılış fiyatı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(299, 31);
            label1.TabIndex = 0;
            label1.Text = "Halka arz olan şirketin adı:";
            // 
            // liste
            // 
            liste.BackColor = Color.DarkKhaki;
            liste.ColumnWidth = 25;
            liste.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            liste.ForeColor = SystemColors.WindowText;
            liste.FormattingEnabled = true;
            liste.ItemHeight = 28;
            liste.Location = new Point(6, 26);
            liste.Name = "liste";
            liste.ScrollAlwaysVisible = true;
            liste.Size = new Size(616, 480);
            liste.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(378, 520);
            button2.Name = "button2";
            button2.Size = new Size(214, 54);
            button2.TabIndex = 11;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkKhaki;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(liste);
            groupBox2.Location = new Point(668, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(628, 596);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(53, 520);
            button3.Name = "button3";
            button3.Size = new Size(214, 54);
            button3.TabIndex = 12;
            button3.Text = "Aktar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkKhaki;
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textara);
            groupBox3.Location = new Point(10, 434);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(630, 200);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(175, 79);
            button4.Name = "button4";
            button4.Size = new Size(214, 109);
            button4.TabIndex = 11;
            button4.Text = "Şirketin adını yaz\r\n karını bul\r\n\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textara
            // 
            textara.BackColor = Color.Goldenrod;
            textara.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textara.Location = new Point(175, 35);
            textara.Name = "textara";
            textara.Size = new Size(214, 38);
            textara.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1317, 649);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox guntxt;
        private TextBox adi;
        private TextBox fiyattxt;
        private ListBox liste;
        private Label label4;
        private TextBox adettxt;
        private Button button2;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private Button button4;
        private TextBox textara;
    }
}