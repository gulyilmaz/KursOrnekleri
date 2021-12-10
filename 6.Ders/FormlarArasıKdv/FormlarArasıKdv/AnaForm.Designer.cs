
namespace FormlarArasıKdv
{
    partial class AnaForm
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
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtKdvOran = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lbKDV = new System.Windows.Forms.Label();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbUrun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.AutoSize = true;
            this.btnGonder.Location = new System.Drawing.Point(79, 184);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(52, 23);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtKdvOran
            // 
            this.txtKdvOran.Location = new System.Drawing.Point(155, 96);
            this.txtKdvOran.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdvOran.Name = "txtKdvOran";
            this.txtKdvOran.Size = new System.Drawing.Size(76, 20);
            this.txtKdvOran.TabIndex = 12;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(155, 65);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(76, 20);
            this.txtFiyat.TabIndex = 11;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(155, 35);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(76, 20);
            this.txtUrunAd.TabIndex = 10;
            // 
            // lbKDV
            // 
            this.lbKDV.AutoSize = true;
            this.lbKDV.Location = new System.Drawing.Point(77, 96);
            this.lbKDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKDV.Name = "lbKDV";
            this.lbKDV.Size = new System.Drawing.Size(52, 13);
            this.lbKDV.TabIndex = 9;
            this.lbKDV.Text = "Kdv Oran";
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Location = new System.Drawing.Point(77, 65);
            this.lbFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(29, 13);
            this.lbFiyat.TabIndex = 8;
            this.lbFiyat.Text = "Fiyat";
            // 
            // lbUrun
            // 
            this.lbUrun.AutoSize = true;
            this.lbUrun.Location = new System.Drawing.Point(77, 35);
            this.lbUrun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUrun.Name = "lbUrun";
            this.lbUrun.Size = new System.Drawing.Size(48, 13);
            this.lbUrun.TabIndex = 7;
            this.lbUrun.Text = "Ürün Adı";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 243);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtKdvOran);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lbKDV);
            this.Controls.Add(this.lbFiyat);
            this.Controls.Add(this.lbUrun);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtKdvOran;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lbKDV;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbUrun;
    }
}

