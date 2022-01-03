using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqOgrencisehir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        List<sehir> slist = new List<sehir>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.id = i;
                o.Ad = FakeData.NameData.GetFirstName();
                o.Maas = FakeData.NumberData.GetNumber(1000, 5000);
                o.sehirid = FakeData.NumberData.GetNumber(1, 81);
                olist.Add(o);
            }
            for (int i = 1; i < 81; i++)
            {
                sehir s = new sehir();
                s.sehirid = i;
                s.sehirAd = FakeData.PlaceData.GetCity();
                slist.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = slist;
            txtBoxSayi.Text = olist.Count().ToString();
            txtBoxTMaas.Text = olist.Sum(x => x.Maas).ToString();

        }
        Ogrenci secilenogr;
        sehir secsehir;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenogr =(Ogrenci) dataGridView1.CurrentRow.DataBoundItem;
            txtBoxId.Text = secilenogr.id.ToString();
            txtBoxAd.Text = secilenogr.Ad;
            txtBoxMaas.Text = secilenogr.Maas.ToString();
            secsehir = slist.Find(x => x.sehirid == secilenogr.sehirid);
            txtBoxSehir.Text = secsehir.sehirAd;
        }
    }
}
