
namespace Hamburgerci
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdborta = new System.Windows.Forms.RadioButton();
            this.rdbbuyuk = new System.Windows.Forms.RadioButton();
            this.rdbking = new System.Windows.Forms.RadioButton();
            this.grbekstralar = new System.Windows.Forms.GroupBox();
            this.checksogan = new System.Windows.Forms.CheckBox();
            this.checkpeynir = new System.Windows.Forms.CheckBox();
            this.checkDomates = new System.Windows.Forms.CheckBox();
            this.checkketcap = new System.Windows.Forms.CheckBox();
            this.checktursu = new System.Windows.Forms.CheckBox();
            this.checkmayonez = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numadet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listsiparisler = new System.Windows.Forms.ListBox();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btnhesap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbekstralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numadet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgerci.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü";
            // 
            // cmbmenu
            // 
            this.cmbmenu.FormattingEnabled = true;
            this.cmbmenu.Items.AddRange(new object[] {
            "Hamburger (20,00 TL)",
            "CheeseBurger (24,00 TL)",
            "ChickenBurger (18,00 TL)"});
            this.cmbmenu.Location = new System.Drawing.Point(68, 224);
            this.cmbmenu.Name = "cmbmenu";
            this.cmbmenu.Size = new System.Drawing.Size(154, 21);
            this.cmbmenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boyut";
            // 
            // rdborta
            // 
            this.rdborta.AutoSize = true;
            this.rdborta.Location = new System.Drawing.Point(68, 270);
            this.rdborta.Name = "rdborta";
            this.rdborta.Size = new System.Drawing.Size(45, 17);
            this.rdborta.TabIndex = 4;
            this.rdborta.TabStop = true;
            this.rdborta.Text = "Orta";
            this.rdborta.UseVisualStyleBackColor = true;
            // 
            // rdbbuyuk
            // 
            this.rdbbuyuk.AutoSize = true;
            this.rdbbuyuk.Location = new System.Drawing.Point(129, 270);
            this.rdbbuyuk.Name = "rdbbuyuk";
            this.rdbbuyuk.Size = new System.Drawing.Size(55, 17);
            this.rdbbuyuk.TabIndex = 5;
            this.rdbbuyuk.TabStop = true;
            this.rdbbuyuk.Text = "Büyük";
            this.rdbbuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbking
            // 
            this.rdbking.AutoSize = true;
            this.rdbking.Location = new System.Drawing.Point(205, 270);
            this.rdbking.Name = "rdbking";
            this.rdbking.Size = new System.Drawing.Size(46, 17);
            this.rdbking.TabIndex = 6;
            this.rdbking.TabStop = true;
            this.rdbking.Text = "King";
            this.rdbking.UseVisualStyleBackColor = true;
            // 
            // grbekstralar
            // 
            this.grbekstralar.Controls.Add(this.checkmayonez);
            this.grbekstralar.Controls.Add(this.checktursu);
            this.grbekstralar.Controls.Add(this.checkketcap);
            this.grbekstralar.Controls.Add(this.checkDomates);
            this.grbekstralar.Controls.Add(this.checkpeynir);
            this.grbekstralar.Controls.Add(this.checksogan);
            this.grbekstralar.Location = new System.Drawing.Point(22, 314);
            this.grbekstralar.Name = "grbekstralar";
            this.grbekstralar.Size = new System.Drawing.Size(229, 158);
            this.grbekstralar.TabIndex = 7;
            this.grbekstralar.TabStop = false;
            this.grbekstralar.Text = "Ekstralar";
            // 
            // checksogan
            // 
            this.checksogan.AutoSize = true;
            this.checksogan.Location = new System.Drawing.Point(11, 34);
            this.checksogan.Name = "checksogan";
            this.checksogan.Size = new System.Drawing.Size(57, 17);
            this.checksogan.TabIndex = 8;
            this.checksogan.Text = "Soğan";
            this.checksogan.UseVisualStyleBackColor = true;
            // 
            // checkpeynir
            // 
            this.checkpeynir.AutoSize = true;
            this.checkpeynir.Location = new System.Drawing.Point(145, 34);
            this.checkpeynir.Name = "checkpeynir";
            this.checkpeynir.Size = new System.Drawing.Size(55, 17);
            this.checkpeynir.TabIndex = 9;
            this.checkpeynir.Text = "Peynir";
            this.checkpeynir.UseVisualStyleBackColor = true;
            // 
            // checkDomates
            // 
            this.checkDomates.AutoSize = true;
            this.checkDomates.Location = new System.Drawing.Point(11, 77);
            this.checkDomates.Name = "checkDomates";
            this.checkDomates.Size = new System.Drawing.Size(68, 17);
            this.checkDomates.TabIndex = 9;
            this.checkDomates.Text = "Domates";
            this.checkDomates.UseVisualStyleBackColor = true;
            // 
            // checkketcap
            // 
            this.checkketcap.AutoSize = true;
            this.checkketcap.Location = new System.Drawing.Point(143, 77);
            this.checkketcap.Name = "checkketcap";
            this.checkketcap.Size = new System.Drawing.Size(60, 17);
            this.checkketcap.TabIndex = 9;
            this.checkketcap.Text = "Ketçap";
            this.checkketcap.UseVisualStyleBackColor = true;
            // 
            // checktursu
            // 
            this.checktursu.AutoSize = true;
            this.checktursu.Location = new System.Drawing.Point(11, 117);
            this.checktursu.Name = "checktursu";
            this.checktursu.Size = new System.Drawing.Size(53, 17);
            this.checktursu.TabIndex = 10;
            this.checktursu.Text = "Turşu";
            this.checktursu.UseVisualStyleBackColor = true;
            // 
            // checkmayonez
            // 
            this.checkmayonez.AutoSize = true;
            this.checkmayonez.Location = new System.Drawing.Point(143, 117);
            this.checkmayonez.Name = "checkmayonez";
            this.checkmayonez.Size = new System.Drawing.Size(69, 17);
            this.checkmayonez.TabIndex = 11;
            this.checkmayonez.Text = "Mayonez";
            this.checkmayonez.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // numadet
            // 
            this.numadet.Location = new System.Drawing.Point(54, 489);
            this.numadet.Name = "numadet";
            this.numadet.Size = new System.Drawing.Size(120, 20);
            this.numadet.TabIndex = 9;
            this.numadet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Büyük Menü Farkı 2 TL, King Menü 4 TL, Ekstralar 0,50Krş ";
            // 
            // listsiparisler
            // 
            this.listsiparisler.FormattingEnabled = true;
            this.listsiparisler.Location = new System.Drawing.Point(323, 23);
            this.listsiparisler.Name = "listsiparisler";
            this.listsiparisler.Size = new System.Drawing.Size(521, 446);
            this.listsiparisler.TabIndex = 11;
            // 
            // btnsiparis
            // 
            this.btnsiparis.Location = new System.Drawing.Point(323, 483);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(75, 23);
            this.btnsiparis.TabIndex = 12;
            this.btnsiparis.Text = "Sipariş Al";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(413, 483);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(75, 23);
            this.btnhesap.TabIndex = 13;
            this.btnhesap.Text = "Hesap";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 586);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.listsiparisler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numadet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbekstralar);
            this.Controls.Add(this.rdbking);
            this.Controls.Add(this.rdbbuyuk);
            this.Controls.Add(this.rdborta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbekstralar.ResumeLayout(false);
            this.grbekstralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdborta;
        private System.Windows.Forms.RadioButton rdbbuyuk;
        private System.Windows.Forms.RadioButton rdbking;
        private System.Windows.Forms.GroupBox grbekstralar;
        private System.Windows.Forms.CheckBox checkmayonez;
        private System.Windows.Forms.CheckBox checktursu;
        private System.Windows.Forms.CheckBox checkketcap;
        private System.Windows.Forms.CheckBox checkDomates;
        private System.Windows.Forms.CheckBox checkpeynir;
        private System.Windows.Forms.CheckBox checksogan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numadet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listsiparisler;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btnhesap;
    }
}

