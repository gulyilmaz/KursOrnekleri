namespace OgrenciProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(37, 210);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(75, 23);
            this.BtnOlustur.TabIndex = 0;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(223, 38);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 2;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(223, 64);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAd.TabIndex = 3;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(223, 90);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSoyad.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox textBox1;
    }
}

