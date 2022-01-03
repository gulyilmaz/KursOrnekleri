
namespace SeyahatAcentesi
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
            this.grbKisisel = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lboxSatilanKoltuklar = new System.Windows.Forms.ListBox();
            this.grbKisisel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKisisel
            // 
            this.grbKisisel.Controls.Add(this.btnKaydet);
            this.grbKisisel.Controls.Add(this.rdbBayan);
            this.grbKisisel.Controls.Add(this.rdbBay);
            this.grbKisisel.Controls.Add(this.txtKoltuk);
            this.grbKisisel.Controls.Add(this.txtTelNo);
            this.grbKisisel.Controls.Add(this.txtSoyad);
            this.grbKisisel.Controls.Add(this.txtAd);
            this.grbKisisel.Controls.Add(this.label5);
            this.grbKisisel.Controls.Add(this.label4);
            this.grbKisisel.Controls.Add(this.label3);
            this.grbKisisel.Controls.Add(this.label2);
            this.grbKisisel.Controls.Add(this.label1);
            this.grbKisisel.Location = new System.Drawing.Point(210, 1);
            this.grbKisisel.Name = "grbKisisel";
            this.grbKisisel.Size = new System.Drawing.Size(324, 212);
            this.grbKisisel.TabIndex = 7;
            this.grbKisisel.TabStop = false;
            this.grbKisisel.Text = "Kişisel Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(113, 165);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Location = new System.Drawing.Point(113, 129);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(55, 17);
            this.rdbBayan.TabIndex = 4;
            this.rdbBayan.TabStop = true;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Location = new System.Drawing.Point(64, 129);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(43, 17);
            this.rdbBay.TabIndex = 3;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Location = new System.Drawing.Point(75, 167);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(32, 20);
            this.txtKoltuk.TabIndex = 2;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(56, 87);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 2;
            this.txtTelNo.Text = "0554 285 50 55";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(56, 56);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "YILMAZ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(56, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Gül";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Koltuk No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tel No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // flwPanel
            // 
            this.flwPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwPanel.Location = new System.Drawing.Point(4, 1);
            this.flwPanel.Name = "flwPanel";
            this.flwPanel.Size = new System.Drawing.Size(200, 573);
            this.flwPanel.TabIndex = 6;
            // 
            // lboxSatilanKoltuklar
            // 
            this.lboxSatilanKoltuklar.FormattingEnabled = true;
            this.lboxSatilanKoltuklar.Location = new System.Drawing.Point(211, 220);
            this.lboxSatilanKoltuklar.Name = "lboxSatilanKoltuklar";
            this.lboxSatilanKoltuklar.Size = new System.Drawing.Size(323, 355);
            this.lboxSatilanKoltuklar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 580);
            this.Controls.Add(this.grbKisisel);
            this.Controls.Add(this.flwPanel);
            this.Controls.Add(this.lboxSatilanKoltuklar);
            this.Name = "Form1";
            this.Text = "Seyahat Acentesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbKisisel.ResumeLayout(false);
            this.grbKisisel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKisisel;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rdbBayan;
        private System.Windows.Forms.RadioButton rdbBay;
        private System.Windows.Forms.TextBox txtKoltuk;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flwPanel;
        private System.Windows.Forms.ListBox lboxSatilanKoltuklar;
    }
}

