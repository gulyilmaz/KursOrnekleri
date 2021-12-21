using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalitim_ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> olist = new List<Ogrenci>();
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Bolum = FakeData.TextData.GetAlphabetical(8);
                o.Id = i;
                o.Ad = FakeData.NameData.GetFirstName();
                o.Soyad = FakeData.NameData.GetSurname();
                o.tcno = FakeData.NumberData.GetNumber(0, 12333333);
                int sayi = rnd.Next(2);
                if (sayi == 1)
                {
                    o.Cins = "E";

                }
                else
                {
                    o.Cins = "K";
                }

              


                olist.Add(o);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            goster();


        }

        private void goster()
        {
            dataGridView1.DataSource = olist;
            // dataGridView1.Columns[6].Visible = false;

        }
    }
}
