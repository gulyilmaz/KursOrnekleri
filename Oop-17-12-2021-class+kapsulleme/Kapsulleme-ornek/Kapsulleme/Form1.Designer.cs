namespace Kapsulleme
{
    partial class Form1
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
            this.lbAd = new System.Windows.Forms.Label();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.LbTckimlik = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lstViewOgrenci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(9, 7);
            this.lbAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(20, 13);
            this.lbAd.TabIndex = 0;
            this.lbAd.Text = "Ad";
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Location = new System.Drawing.Point(9, 33);
            this.lbSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(37, 13);
            this.lbSoyad.TabIndex = 1;
            this.lbSoyad.Text = "Soyad";
            // 
            // LbTckimlik
            // 
            this.LbTckimlik.AutoSize = true;
            this.LbTckimlik.Location = new System.Drawing.Point(9, 58);
            this.LbTckimlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTckimlik.Name = "LbTckimlik";
            this.LbTckimlik.Size = new System.Drawing.Size(51, 13);
            this.LbTckimlik.TabIndex = 2;
            this.LbTckimlik.Text = "TC Kimlik";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(63, 7);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(76, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(63, 33);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(76, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(63, 58);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(76, 20);
            this.txtTcKimlik.TabIndex = 5;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(11, 93);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(56, 19);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lstViewOgrenci
            // 
            this.lstViewOgrenci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewOgrenci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstViewOgrenci.Location = new System.Drawing.Point(0, 138);
            this.lstViewOgrenci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstViewOgrenci.Name = "lstViewOgrenci";
            this.lstViewOgrenci.Size = new System.Drawing.Size(365, 149);
            this.lstViewOgrenci.TabIndex = 7;
            this.lstViewOgrenci.UseCompatibleStateImageBehavior = false;
            this.lstViewOgrenci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TCKimlik";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 115;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(82, 93);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 19);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 287);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstViewOgrenci);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.LbTckimlik);
            this.Controls.Add(this.lbSoyad);
            this.Controls.Add(this.lbAd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.Label LbTckimlik;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ListView lstViewOgrenci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSil;
    }
}

