using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = txtAd.Text;
            o.Soyad = txtSoyad.Text;
            o.TCKimlik = Convert.ToInt64(txtTcKimlik.Text);
            ListViewItem Kayit = new ListViewItem();
           
            Kayit.Text = o.TCKimlik.ToString();
            Kayit.SubItems.Add(o.Ad);
            Kayit.SubItems.Add(o.Soyad);
          
            lstViewOgrenci.Items.Add(Kayit);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstViewOgrenci.Items.Remove(lstViewOgrenci.SelectedItems[0]);
        }
    }
}
