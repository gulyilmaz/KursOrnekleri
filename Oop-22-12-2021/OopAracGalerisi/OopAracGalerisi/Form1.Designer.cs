
namespace OopAracGalerisi
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lstArac = new System.Windows.Forms.ListBox();
            this.grbArac = new System.Windows.Forms.GroupBox();
            this.btnKucukResim = new System.Windows.Forms.Button();
            this.chkGaranti = new System.Windows.Forms.CheckBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.cmbKasa = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSanziman = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMotor = new System.Windows.Forms.NumericUpDown();
            this.numYil = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grbArac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(493, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(549, 446);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // lstArac
            // 
            this.lstArac.AllowDrop = true;
            this.lstArac.FormattingEnabled = true;
            this.lstArac.Location = new System.Drawing.Point(320, 38);
            this.lstArac.Name = "lstArac";
            this.lstArac.Size = new System.Drawing.Size(154, 420);
            this.lstArac.TabIndex = 12;
            this.lstArac.SelectedIndexChanged += new System.EventHandler(this.lstArac_SelectedIndexChanged);
            this.lstArac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstArac_KeyDown);
            // 
            // grbArac
            // 
            this.grbArac.Controls.Add(this.btnKucukResim);
            this.grbArac.Controls.Add(this.chkGaranti);
            this.grbArac.Controls.Add(this.btnResim);
            this.grbArac.Controls.Add(this.btnRenk);
            this.grbArac.Controls.Add(this.btnOlustur);
            this.grbArac.Controls.Add(this.cmbKasa);
            this.grbArac.Controls.Add(this.cmbYakit);
            this.grbArac.Controls.Add(this.label10);
            this.grbArac.Controls.Add(this.label1);
            this.grbArac.Controls.Add(this.label9);
            this.grbArac.Controls.Add(this.lblRenk);
            this.grbArac.Controls.Add(this.label8);
            this.grbArac.Controls.Add(this.cmbSanziman);
            this.grbArac.Controls.Add(this.label7);
            this.grbArac.Controls.Add(this.cmbModel);
            this.grbArac.Controls.Add(this.label6);
            this.grbArac.Controls.Add(this.cmbMarka);
            this.grbArac.Controls.Add(this.label5);
            this.grbArac.Controls.Add(this.cmbArac);
            this.grbArac.Controls.Add(this.label4);
            this.grbArac.Controls.Add(this.label3);
            this.grbArac.Controls.Add(this.numMotor);
            this.grbArac.Controls.Add(this.numYil);
            this.grbArac.Location = new System.Drawing.Point(8, 2);
            this.grbArac.Name = "grbArac";
            this.grbArac.Size = new System.Drawing.Size(286, 489);
            this.grbArac.TabIndex = 14;
            this.grbArac.TabStop = false;
            this.grbArac.Text = "Araçlar";
            // 
            // btnKucukResim
            // 
            this.btnKucukResim.AllowDrop = true;
            this.btnKucukResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKucukResim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKucukResim.Location = new System.Drawing.Point(13, 292);
            this.btnKucukResim.Name = "btnKucukResim";
            this.btnKucukResim.Size = new System.Drawing.Size(247, 172);
            this.btnKucukResim.TabIndex = 11;
            this.btnKucukResim.UseVisualStyleBackColor = true;
      
            this.btnKucukResim.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnKucukResim_DragEnter);
            // 
            // chkGaranti
            // 
            this.chkGaranti.AutoSize = true;
            this.chkGaranti.Checked = true;
            this.chkGaranti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGaranti.Location = new System.Drawing.Point(112, 240);
            this.chkGaranti.Name = "chkGaranti";
            this.chkGaranti.Size = new System.Drawing.Size(86, 17);
            this.chkGaranti.TabIndex = 10;
            this.chkGaranti.Text = "Garantisi Var";
            this.chkGaranti.UseVisualStyleBackColor = true;
            this.chkGaranti.CheckedChanged += new System.EventHandler(this.chkGaranti_CheckedChanged);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(16, 263);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(106, 23);
            this.btnResim.TabIndex = 7;
            this.btnResim.Text = "Aracın Resmi";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(13, 180);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(93, 23);
            this.btnRenk.TabIndex = 7;
            this.btnRenk.Text = "Aracın Rengi";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(128, 263);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(132, 23);
            this.btnOlustur.TabIndex = 7;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // cmbKasa
            // 
            this.cmbKasa.FormattingEnabled = true;
            this.cmbKasa.Location = new System.Drawing.Point(112, 156);
            this.cmbKasa.Name = "cmbKasa";
            this.cmbKasa.Size = new System.Drawing.Size(148, 21);
            this.cmbKasa.TabIndex = 9;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(112, 129);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(148, 21);
            this.cmbYakit.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Motor Gücü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Garanti Durumu";
            // 
            // lblRenk
            // 
            this.lblRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRenk.Location = new System.Drawing.Point(112, 180);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(148, 21);
            this.lblRenk.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kasa Tipi";
            // 
            // cmbSanziman
            // 
            this.cmbSanziman.FormattingEnabled = true;
            this.cmbSanziman.Location = new System.Drawing.Point(112, 102);
            this.cmbSanziman.Name = "cmbSanziman";
            this.cmbSanziman.Size = new System.Drawing.Size(148, 21);
            this.cmbSanziman.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yakıt Türü";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(112, 75);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(148, 21);
            this.cmbModel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şanzıman Türü";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(112, 48);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(148, 21);
            this.cmbMarka.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aracın Modeli";
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(112, 21);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(148, 21);
            this.cmbArac.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aracın Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Araç Türü";
            // 
            // numMotor
            // 
            this.numMotor.Location = new System.Drawing.Point(204, 214);
            this.numMotor.Name = "numMotor";
            this.numMotor.Size = new System.Drawing.Size(56, 20);
            this.numMotor.TabIndex = 6;
            // 
            // numYil
            // 
            this.numYil.Location = new System.Drawing.Point(55, 214);
            this.numYil.Name = "numYil";
            this.numYil.Size = new System.Drawing.Size(74, 20);
            this.numYil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Araç İncele";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "images";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 508);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lstArac);
            this.Controls.Add(this.grbArac);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grbArac.ResumeLayout(false);
            this.grbArac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox lstArac;
        private System.Windows.Forms.GroupBox grbArac;
        private System.Windows.Forms.Button btnKucukResim;
        private System.Windows.Forms.CheckBox chkGaranti;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ComboBox cmbKasa;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSanziman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMotor;
        private System.Windows.Forms.NumericUpDown numYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

