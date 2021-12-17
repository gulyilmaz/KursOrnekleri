using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataUret;

namespace OgrenciUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            olist.Clear();
            for (int i = 1; i < 100; i++)
            {
                Ogrenci o = new Ogrenci();
                BAU bau = new BAU();
                o.Id = i;
                o.Ad = bau.GetName();
                o.Soyad = bau.GetSurname();
                o.DogumYeri = bau.City();
                o.DogumTarih = bau.GetBackDate(20);
                o.KursBitisTarih = bau.GetForwardDate(3);
                olist.Add(o);
            }
            dataGridView1.DataSource = olist;
        }
    }
}
