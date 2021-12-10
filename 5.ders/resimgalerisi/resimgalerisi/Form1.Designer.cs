
namespace resimgalerisi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnilk = new System.Windows.Forms.Button();
            this.btnonceki = new System.Windows.Forms.Button();
            this.btnrastgele = new System.Windows.Forms.Button();
            this.btnslayt = new System.Windows.Forms.Button();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.btnson = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 362);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 325);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnilk
            // 
            this.btnilk.Location = new System.Drawing.Point(226, 343);
            this.btnilk.Name = "btnilk";
            this.btnilk.Size = new System.Drawing.Size(66, 33);
            this.btnilk.TabIndex = 2;
            this.btnilk.Text = "<<";
            this.btnilk.UseVisualStyleBackColor = true;
            this.btnilk.Click += new System.EventHandler(this.btnilk_Click);
            // 
            // btnonceki
            // 
            this.btnonceki.Location = new System.Drawing.Point(298, 343);
            this.btnonceki.Name = "btnonceki";
            this.btnonceki.Size = new System.Drawing.Size(66, 33);
            this.btnonceki.TabIndex = 3;
            this.btnonceki.Text = "<";
            this.btnonceki.UseVisualStyleBackColor = true;
            this.btnonceki.Click += new System.EventHandler(this.btnonceki_Click);
            // 
            // btnrastgele
            // 
            this.btnrastgele.Location = new System.Drawing.Point(370, 343);
            this.btnrastgele.Name = "btnrastgele";
            this.btnrastgele.Size = new System.Drawing.Size(112, 33);
            this.btnrastgele.TabIndex = 4;
            this.btnrastgele.Text = "Rastgele Resimler";
            this.btnrastgele.UseVisualStyleBackColor = true;
            this.btnrastgele.Click += new System.EventHandler(this.btnrastgele_Click);
            // 
            // btnslayt
            // 
            this.btnslayt.Location = new System.Drawing.Point(488, 343);
            this.btnslayt.Name = "btnslayt";
            this.btnslayt.Size = new System.Drawing.Size(112, 33);
            this.btnslayt.TabIndex = 5;
            this.btnslayt.Text = "Slayt Gösterisi";
            this.btnslayt.UseVisualStyleBackColor = true;
            this.btnslayt.Click += new System.EventHandler(this.btnslayt_Click);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Location = new System.Drawing.Point(606, 343);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(66, 33);
            this.btnsonraki.TabIndex = 6;
            this.btnsonraki.Text = ">";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // btnson
            // 
            this.btnson.Location = new System.Drawing.Point(678, 343);
            this.btnson.Name = "btnson";
            this.btnson.Size = new System.Drawing.Size(66, 33);
            this.btnson.TabIndex = 7;
            this.btnson.Text = ">>";
            this.btnson.UseVisualStyleBackColor = true;
            this.btnson.Click += new System.EventHandler(this.btnson_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnson);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.btnslayt);
            this.Controls.Add(this.btnrastgele);
            this.Controls.Add(this.btnonceki);
            this.Controls.Add(this.btnilk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnilk;
        private System.Windows.Forms.Button btnonceki;
        private System.Windows.Forms.Button btnrastgele;
        private System.Windows.Forms.Button btnslayt;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Button btnson;
        private System.Windows.Forms.Timer timer1;
    }
}

