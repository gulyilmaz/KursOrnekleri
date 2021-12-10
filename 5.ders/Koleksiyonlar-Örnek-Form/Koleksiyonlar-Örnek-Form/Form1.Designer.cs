
namespace Koleksiyonlar_Örnek_Form
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
            this.ekle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(37, 38);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(95, 34);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(37, 195);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(95, 34);
            this.listele.TabIndex = 1;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(37, 155);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(95, 34);
            this.ara.TabIndex = 2;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(37, 118);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(95, 34);
            this.duzenle.TabIndex = 3;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(37, 78);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(95, 34);
            this.sil.TabIndex = 4;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(37, 236);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(95, 34);
            this.cikis.TabIndex = 5;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(383, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 282);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

