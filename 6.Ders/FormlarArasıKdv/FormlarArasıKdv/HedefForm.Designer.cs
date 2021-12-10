
namespace FormlarArasıKdv
{
    partial class HedefForm
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
            this.lbKdvliFiyat = new System.Windows.Forms.Label();
            this.lbKdvOran = new System.Windows.Forms.Label();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbUrunAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKdvliFiyat
            // 
            this.lbKdvliFiyat.AutoSize = true;
            this.lbKdvliFiyat.Location = new System.Drawing.Point(111, 109);
            this.lbKdvliFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKdvliFiyat.Name = "lbKdvliFiyat";
            this.lbKdvliFiyat.Size = new System.Drawing.Size(13, 13);
            this.lbKdvliFiyat.TabIndex = 15;
            this.lbKdvliFiyat.Text = "0";
            // 
            // lbKdvOran
            // 
            this.lbKdvOran.AutoSize = true;
            this.lbKdvOran.Location = new System.Drawing.Point(111, 81);
            this.lbKdvOran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKdvOran.Name = "lbKdvOran";
            this.lbKdvOran.Size = new System.Drawing.Size(13, 13);
            this.lbKdvOran.TabIndex = 14;
            this.lbKdvOran.Text = "0";
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Location = new System.Drawing.Point(111, 54);
            this.lbFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(13, 13);
            this.lbFiyat.TabIndex = 13;
            this.lbFiyat.Text = "0";
            // 
            // lbUrunAd
            // 
            this.lbUrunAd.AutoSize = true;
            this.lbUrunAd.Location = new System.Drawing.Point(111, 31);
            this.lbUrunAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUrunAd.Name = "lbUrunAd";
            this.lbUrunAd.Size = new System.Drawing.Size(13, 13);
            this.lbUrunAd.TabIndex = 12;
            this.lbUrunAd.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kdv li Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kdv Oran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürün Adı";
            // 
            // HedefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 182);
            this.Controls.Add(this.lbKdvliFiyat);
            this.Controls.Add(this.lbKdvOran);
            this.Controls.Add(this.lbFiyat);
            this.Controls.Add(this.lbUrunAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HedefForm";
            this.Text = "HedefForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKdvliFiyat;
        private System.Windows.Forms.Label lbKdvOran;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbUrunAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}