
namespace InterfaceProje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkup = new System.Windows.Forms.Button();
            this.btndikdortgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnkup
            // 
            this.btnkup.Location = new System.Drawing.Point(125, 220);
            this.btnkup.Name = "btnkup";
            this.btnkup.Size = new System.Drawing.Size(75, 23);
            this.btnkup.TabIndex = 1;
            this.btnkup.Text = "Küp Liste";
            this.btnkup.UseVisualStyleBackColor = true;
            this.btnkup.Click += new System.EventHandler(this.btnkup_Click);
            // 
            // btndikdortgen
            // 
            this.btndikdortgen.Location = new System.Drawing.Point(274, 220);
            this.btndikdortgen.Name = "btndikdortgen";
            this.btndikdortgen.Size = new System.Drawing.Size(113, 23);
            this.btndikdortgen.TabIndex = 2;
            this.btndikdortgen.Text = "Dikdörtgen Liste";
            this.btndikdortgen.UseVisualStyleBackColor = true;
            this.btndikdortgen.Click += new System.EventHandler(this.btndikdortgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.btndikdortgen);
            this.Controls.Add(this.btnkup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkup;
        private System.Windows.Forms.Button btndikdortgen;
    }
}

