using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListUygulama.businessServices;

namespace ToDoListUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15000;
            timer1.Tick += Tm_zamanla_Tick;
            timer1.Start();
            ButonAcKapa(false);
            sistemgiris kullanicikontrol = new sistemgiris();
            kullanicikontrol.MdiParent = this;
            kullanicikontrol.StartPosition = FormStartPosition.CenterScreen;
            kullanicikontrol.Show();


        }

        private void ButonAcKapa(bool kontrol)
        {
            foreach (Control item in groupBoxislemlistesi.Controls)
            {
                if(item is Button)
                {
                   ((Button)item).Enabled = kontrol;
                }
            }


        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            labelzaman.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void buttonkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Form T;
        private void buttonyenikayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yenikayit"] != null)
            {
                T = Application.OpenForms["yenikayit"];
                T.Focus();//bu form açıksa git focus et
            }
            else
            {
                T = new yenikayit();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void buttonkayitliste_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            if (todoService.kayitKontrol() > 0)
            {
                kayitliste kayitlistesi = new kayitliste();
                kayitlistesi.MdiParent = this;
                kayitlistesi.Show();
            }
            else
            {
                MessageBox.Show("listelenecek kayıt bulunamadı", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
