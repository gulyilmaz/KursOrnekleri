using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        //{
        //     new Ogrenci{Id=1, Ad="Şamil" ,Soyad= "Yılmaz"},
        //     new Ogrenci{Id=1, Ad="Selen" ,Soyad= "Yılmaz"},
        //     new Ogrenci{Id=1, Ad="Güner Pak" ,Soyad= "Yılmaz"}
        //};
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Id = 1;
            o1.Ad = "Şamil";
            o1.Soyad = "Yılmaz";
            olist.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Id = 2;
            o2.Ad = "Kamil";
            o2.Soyad = "Yılmaz";
            o2.ToString();
            olist.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Id = 3;
            o3.Ad = "Selen";
            o3.Soyad = "Yılmaz";
            olist.Add(o3);
            
            listBox1.DataSource = olist;
            //listBox1.DisplayMember = "Ad";
            //listBox1.ValueMember = "Id";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci ogr = (Ogrenci)listBox1.SelectedItem;
            txtBoxId.Text = ogr.Id.ToString();
            txtBoxAd.Text = ogr.Ad;
            txtBoxSoyad.Text = ogr.Soyad;
            textBox1.Text = ogr.ToString();
        }
    }
}
