namespace BisikletClass
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.cmbFren = new System.Windows.Forms.ComboBox();
   this.cmbKadro = new System.Windows.Forms.ComboBox();
   this.dateModelYılı = new System.Windows.Forms.DateTimePicker();
   this.txtYasi = new System.Windows.Forms.TextBox();
   this.btnClass = new System.Windows.Forms.Button();
   this.label3 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 43);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(48, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Fren Tipi";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 109);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(55, 13);
   this.label2.TabIndex = 0;
   this.label2.Text = "Kadro Tipi";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 216);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(27, 13);
   this.label4.TabIndex = 0;
   this.label4.Text = "Yaşı";
   // 
   // cmbFren
   // 
   this.cmbFren.FormattingEnabled = true;
   this.cmbFren.Location = new System.Drawing.Point(92, 40);
   this.cmbFren.Name = "cmbFren";
   this.cmbFren.Size = new System.Drawing.Size(170, 21);
   this.cmbFren.TabIndex = 0;
   // 
   // cmbKadro
   // 
   this.cmbKadro.FormattingEnabled = true;
   this.cmbKadro.Location = new System.Drawing.Point(92, 106);
   this.cmbKadro.Name = "cmbKadro";
   this.cmbKadro.Size = new System.Drawing.Size(170, 21);
   this.cmbKadro.TabIndex = 1;
   // 
   // dateModelYılı
   // 
   this.dateModelYılı.Location = new System.Drawing.Point(92, 178);
   this.dateModelYılı.Name = "dateModelYılı";
   this.dateModelYılı.Size = new System.Drawing.Size(170, 20);
   this.dateModelYılı.TabIndex = 5;
   // 
   // txtYasi
   // 
   this.txtYasi.Enabled = false;
   this.txtYasi.Location = new System.Drawing.Point(92, 212);
   this.txtYasi.Name = "txtYasi";
   this.txtYasi.Size = new System.Drawing.Size(170, 20);
   this.txtYasi.TabIndex = 3;
   // 
   // btnClass
   // 
   this.btnClass.Location = new System.Drawing.Point(162, 250);
   this.btnClass.Name = "btnClass";
   this.btnClass.Size = new System.Drawing.Size(100, 23);
   this.btnClass.TabIndex = 6;
   this.btnClass.Text = "Class\'a Gönder";
   this.btnClass.UseVisualStyleBackColor = true;
   this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 181);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(52, 13);
   this.label3.TabIndex = 0;
   this.label3.Text = "Model Yılı";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(298, 337);
   this.Controls.Add(this.btnClass);
   this.Controls.Add(this.label4);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.txtYasi);
   this.Controls.Add(this.dateModelYılı);
   this.Controls.Add(this.cmbKadro);
   this.Controls.Add(this.cmbFren);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox cmbFren;
  private System.Windows.Forms.ComboBox cmbKadro;
  private System.Windows.Forms.DateTimePicker dateModelYılı;
  private System.Windows.Forms.TextBox txtYasi;
  private System.Windows.Forms.Button btnClass;
  private System.Windows.Forms.Label label3;
 }
}

