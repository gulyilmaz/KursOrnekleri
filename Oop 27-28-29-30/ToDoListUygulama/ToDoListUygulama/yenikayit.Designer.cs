
namespace ToDoListUygulama
{
    partial class yenikayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.txtkisaaciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtonem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(107, 28);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(115, 20);
            this.txtbaslik.TabIndex = 2;
            this.txtbaslik.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtbaslik.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // txtkisaaciklama
            // 
            this.txtkisaaciklama.Location = new System.Drawing.Point(107, 49);
            this.txtkisaaciklama.Multiline = true;
            this.txtkisaaciklama.Name = "txtkisaaciklama";
            this.txtkisaaciklama.Size = new System.Drawing.Size(115, 70);
            this.txtkisaaciklama.TabIndex = 2;
            this.txtkisaaciklama.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtkisaaciklama.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(107, 143);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(115, 70);
            this.txtaciklama.TabIndex = 4;
            this.txtaciklama.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtaciklama.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Önem Derecesi";
            // 
            // txtonem
            // 
            this.txtonem.Location = new System.Drawing.Point(107, 245);
            this.txtonem.Name = "txtonem";
            this.txtonem.Size = new System.Drawing.Size(115, 20);
            this.txtonem.TabIndex = 6;
            this.txtonem.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtonem.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durum";
            // 
            // cmbdurum
            // 
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanmadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cmbdurum.Location = new System.Drawing.Point(107, 297);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(121, 21);
            this.cmbdurum.TabIndex = 8;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(124, 324);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(75, 23);
            this.btnyenikayit.TabIndex = 9;
            this.btnyenikayit.Text = "Yeni Kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // yenikayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 383);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.cmbdurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtonem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkisaaciklama);
            this.Controls.Add(this.txtbaslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yenikayit";
            this.Text = "Todo-Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbaslik;
        private System.Windows.Forms.TextBox txtkisaaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtonem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.Button btnyenikayit;
    }
}