
namespace ToDoListUygulama
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxislemlistesi = new System.Windows.Forms.GroupBox();
            this.buttonkapat = new System.Windows.Forms.Button();
            this.buttonkayitliste = new System.Windows.Forms.Button();
            this.buttonyenikayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelzaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxislemlistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxislemlistesi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 477);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxislemlistesi
            // 
            this.groupBoxislemlistesi.Controls.Add(this.buttonkapat);
            this.groupBoxislemlistesi.Controls.Add(this.buttonkayitliste);
            this.groupBoxislemlistesi.Controls.Add(this.buttonyenikayit);
            this.groupBoxislemlistesi.Location = new System.Drawing.Point(12, 157);
            this.groupBoxislemlistesi.Name = "groupBoxislemlistesi";
            this.groupBoxislemlistesi.Size = new System.Drawing.Size(150, 308);
            this.groupBoxislemlistesi.TabIndex = 3;
            this.groupBoxislemlistesi.TabStop = false;
            this.groupBoxislemlistesi.Text = "İşlem Listesi";
            // 
            // buttonkapat
            // 
            this.buttonkapat.Location = new System.Drawing.Point(13, 77);
            this.buttonkapat.Name = "buttonkapat";
            this.buttonkapat.Size = new System.Drawing.Size(126, 23);
            this.buttonkapat.TabIndex = 3;
            this.buttonkapat.Text = "Uygulama Kapat";
            this.buttonkapat.UseVisualStyleBackColor = true;
            this.buttonkapat.Click += new System.EventHandler(this.buttonkapat_Click);
            // 
            // buttonkayitliste
            // 
            this.buttonkayitliste.Location = new System.Drawing.Point(13, 48);
            this.buttonkayitliste.Name = "buttonkayitliste";
            this.buttonkayitliste.Size = new System.Drawing.Size(126, 23);
            this.buttonkayitliste.TabIndex = 3;
            this.buttonkayitliste.Text = "Kayıt Liste";
            this.buttonkayitliste.UseVisualStyleBackColor = true;
            this.buttonkayitliste.Click += new System.EventHandler(this.buttonkayitliste_Click);
            // 
            // buttonyenikayit
            // 
            this.buttonyenikayit.Location = new System.Drawing.Point(13, 19);
            this.buttonyenikayit.Name = "buttonyenikayit";
            this.buttonyenikayit.Size = new System.Drawing.Size(126, 23);
            this.buttonyenikayit.TabIndex = 2;
            this.buttonyenikayit.Text = "Yeni Kayıt";
            this.buttonyenikayit.UseVisualStyleBackColor = true;
            this.buttonyenikayit.Click += new System.EventHandler(this.buttonyenikayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoListUygulama.Properties.Resources.Checklist_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelzaman);
            this.panel2.Location = new System.Drawing.Point(631, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 54);
            this.panel2.TabIndex = 2;
            // 
            // labelzaman
            // 
            this.labelzaman.AutoSize = true;
            this.labelzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelzaman.Location = new System.Drawing.Point(21, 16);
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Size = new System.Drawing.Size(167, 25);
            this.labelzaman.TabIndex = 0;
            this.labelzaman.Text = "28/12/2021 11:40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo-Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxislemlistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxislemlistesi;
        private System.Windows.Forms.Button buttonkapat;
        private System.Windows.Forms.Button buttonkayitliste;
        private System.Windows.Forms.Button buttonyenikayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelzaman;
        private System.Windows.Forms.Timer timer1;
    }
}

