using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapsulproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ogrenci> olist = new List<ogrenci>();
        private void btnEkle_Click(object sender, EventArgs e)
        { ogrenci o = new ogrenci();
            o.Id = Convert.ToInt32(textBoxId.Text);
            o.Ad = textBoxAd.Text;
            o.Soyad = textBoxsoyad.Text;
            olist.Add(o);
        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }
    }
}
