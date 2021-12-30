
namespace ToDoListUygulama
{
    partial class kayitliste
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
            this.groupBoxislemliste = new System.Windows.Forms.GroupBox();
            this.btniptaledildi = new System.Windows.Forms.Button();
            this.btntamamlanamadi = new System.Windows.Forms.Button();
            this.btntamamlandi = new System.Windows.Forms.Button();
            this.btntumliste = new System.Windows.Forms.Button();
            this.groupBoxliste = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxislemliste.SuspendLayout();
            this.groupBoxliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxislemliste
            // 
            this.groupBoxislemliste.Controls.Add(this.btniptaledildi);
            this.groupBoxislemliste.Controls.Add(this.btntamamlanamadi);
            this.groupBoxislemliste.Controls.Add(this.btntamamlandi);
            this.groupBoxislemliste.Controls.Add(this.btntumliste);
            this.groupBoxislemliste.Location = new System.Drawing.Point(12, 12);
            this.groupBoxislemliste.Name = "groupBoxislemliste";
            this.groupBoxislemliste.Size = new System.Drawing.Size(122, 298);
            this.groupBoxislemliste.TabIndex = 0;
            this.groupBoxislemliste.TabStop = false;
            this.groupBoxislemliste.Text = "İşlem Listesi";
            // 
            // btniptaledildi
            // 
            this.btniptaledildi.Location = new System.Drawing.Point(13, 110);
            this.btniptaledildi.Name = "btniptaledildi";
            this.btniptaledildi.Size = new System.Drawing.Size(95, 23);
            this.btniptaledildi.TabIndex = 1;
            this.btniptaledildi.Text = "İptal Edildi";
            this.btniptaledildi.UseVisualStyleBackColor = true;
            this.btniptaledildi.Click += new System.EventHandler(this.btniptaledildi_Click);
            // 
            // btntamamlanamadi
            // 
            this.btntamamlanamadi.Location = new System.Drawing.Point(13, 81);
            this.btntamamlanamadi.Name = "btntamamlanamadi";
            this.btntamamlanamadi.Size = new System.Drawing.Size(95, 23);
            this.btntamamlanamadi.TabIndex = 1;
            this.btntamamlanamadi.Text = "Tamamlanamadı";
            this.btntamamlanamadi.UseVisualStyleBackColor = true;
            this.btntamamlanamadi.Click += new System.EventHandler(this.btntamamlanamadi_Click);
            // 
            // btntamamlandi
            // 
            this.btntamamlandi.Location = new System.Drawing.Point(13, 52);
            this.btntamamlandi.Name = "btntamamlandi";
            this.btntamamlandi.Size = new System.Drawing.Size(95, 23);
            this.btntamamlandi.TabIndex = 1;
            this.btntamamlandi.Text = "Tamamlandı";
            this.btntamamlandi.UseVisualStyleBackColor = true;
            this.btntamamlandi.Click += new System.EventHandler(this.btntamamlandi_Click);
            // 
            // btntumliste
            // 
            this.btntumliste.Location = new System.Drawing.Point(13, 23);
            this.btntumliste.Name = "btntumliste";
            this.btntumliste.Size = new System.Drawing.Size(95, 23);
            this.btntumliste.TabIndex = 1;
            this.btntumliste.Text = "Tüm Liste";
            this.btntumliste.UseVisualStyleBackColor = true;
            this.btntumliste.Click += new System.EventHandler(this.btntumliste_Click);
            // 
            // groupBoxliste
            // 
            this.groupBoxliste.Controls.Add(this.dataGridView1);
            this.groupBoxliste.Location = new System.Drawing.Point(140, 12);
            this.groupBoxliste.Name = "groupBoxliste";
            this.groupBoxliste.Size = new System.Drawing.Size(358, 298);
            this.groupBoxliste.TabIndex = 1;
            this.groupBoxliste.TabStop = false;
            this.groupBoxliste.Text = "Liste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(352, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // kayitliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 339);
            this.Controls.Add(this.groupBoxliste);
            this.Controls.Add(this.groupBoxislemliste);
            this.Name = "kayitliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayitliste";
            this.Load += new System.EventHandler(this.kayitliste_Load);
            this.groupBoxislemliste.ResumeLayout(false);
            this.groupBoxliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxislemliste;
        private System.Windows.Forms.Button btniptaledildi;
        private System.Windows.Forms.Button btntamamlanamadi;
        private System.Windows.Forms.Button btntamamlandi;
        private System.Windows.Forms.Button btntumliste;
        private System.Windows.Forms.GroupBox groupBoxliste;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}