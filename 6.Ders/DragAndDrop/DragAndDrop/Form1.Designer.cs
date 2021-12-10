
namespace DragAndDrop
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
            this.lstboxgonderen = new System.Windows.Forms.ListBox();
            this.lstboxalan = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstboxgonderen
            // 
            this.lstboxgonderen.FormattingEnabled = true;
            this.lstboxgonderen.Location = new System.Drawing.Point(22, 12);
            this.lstboxgonderen.Name = "lstboxgonderen";
            this.lstboxgonderen.Size = new System.Drawing.Size(145, 212);
            this.lstboxgonderen.TabIndex = 0;
            this.lstboxgonderen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxgonderen_MouseDown);
            // 
            // lstboxalan
            // 
            this.lstboxalan.FormattingEnabled = true;
            this.lstboxalan.Location = new System.Drawing.Point(255, 12);
            this.lstboxalan.Name = "lstboxalan";
            this.lstboxalan.Size = new System.Drawing.Size(145, 212);
            this.lstboxalan.TabIndex = 1;
            this.lstboxalan.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstboxalan_DragDrop);
            this.lstboxalan.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstboxalan_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstboxalan);
            this.Controls.Add(this.lstboxgonderen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxgonderen;
        private System.Windows.Forms.ListBox lstboxalan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

