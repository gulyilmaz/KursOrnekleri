using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e)
        {
          
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                
                o.Ad = FakeData.NameData.GetFirstName();
                o.SoyAd = FakeData.NameData.GetSurname();
                o.sinav1 = FakeData.NumberData.GetNumber(0, 100);
                o.sinav2 = FakeData.NumberData.GetNumber(0, 100);
                o.OgrenciNo = FakeData.NumberData.GetNumber(1000, 9000);
                o.ortalama = o.Ortalama();
                olist.Add(o);
            }
            
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = olist;
        }
        int secilenid;
        Ogrenci secogr;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenid =(int) dataGridView1.CurrentRow.Cells[0].Value;
            secogr = olist.Find(x => x.OgrenciNo == secilenid);

            txtogrno.Text = secogr.OgrenciNo.ToString();
            txtad.Text = secogr.Ad;
            txtsoyad.Text = secogr.SoyAd;
            txt1sinav.Text = secogr.sinav1.ToString();
            txt2sinav.Text = secogr.sinav2.ToString();
            txtort.Text = secogr.ortalama.ToString();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist.Where(x => x.ortalama < 50).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist.Where(x => x.ortalama > 50).ToList();
        }
    }
}
