using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsonproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jsondosyayolu = "c:\\ogrenci\\ogrencilist.txt";
        List<Ogrenci> olist = new List<Ogrenci>();


        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.id = Convert.ToInt32(textBox3.Text);
            o.ad = textBox1.Text;
            o.soyad = textBox2.Text;
            olist.Add(o);
            goster(olist);
        }

        private void goster(List<Ogrenci> olist)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }

        private void buttonserialize_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Open(jsondosyayolu, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(dosya);
            sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(olist));
            sw.Close();
            sw.Dispose();
            dosya.Close();
            MessageBox.Show("Dosya KAYDEDİLDİ");

        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.OpenRead(jsondosyayolu);
            StreamReader dosyaoku = new StreamReader(dosya);
            string veri = dosyaoku.ReadToEnd();
            dosya.Close();
            dosyaoku.Close();
            dosyaoku.Dispose();
            List<Ogrenci> ol = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ogrenci>>(veri);
            goster(ol);
            MessageBox.Show("liste okundu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(jsondosyayolu);
        }
    }
}
