namespace _07_03_GunlerComboList
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
   this.btnDoldur = new System.Windows.Forms.Button();
   this.cmbGunler = new System.Windows.Forms.ComboBox();
   this.lstGunler = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // btnDoldur
   // 
   this.btnDoldur.Location = new System.Drawing.Point(29, 23);
   this.btnDoldur.Name = "btnDoldur";
   this.btnDoldur.Size = new System.Drawing.Size(100, 23);
   this.btnDoldur.TabIndex = 0;
   this.btnDoldur.Text = "Haftanın Günleri";
   this.btnDoldur.UseVisualStyleBackColor = true;
   this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
   // 
   // cmbGunler
   // 
   this.cmbGunler.FormattingEnabled = true;
   this.cmbGunler.Location = new System.Drawing.Point(29, 52);
   this.cmbGunler.Name = "cmbGunler";
   this.cmbGunler.Size = new System.Drawing.Size(140, 21);
   this.cmbGunler.TabIndex = 1;
   // 
   // lstGunler
   // 
   this.lstGunler.FormattingEnabled = true;
   this.lstGunler.Location = new System.Drawing.Point(29, 206);
   this.lstGunler.Name = "lstGunler";
   this.lstGunler.Size = new System.Drawing.Size(140, 134);
   this.lstGunler.TabIndex = 2;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(378, 423);
   this.Controls.Add(this.lstGunler);
   this.Controls.Add(this.cmbGunler);
   this.Controls.Add(this.btnDoldur);
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnDoldur;
  private System.Windows.Forms.ComboBox cmbGunler;
  private System.Windows.Forms.ListBox lstGunler;
 }
}

