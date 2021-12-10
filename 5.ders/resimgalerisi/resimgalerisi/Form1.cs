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

namespace resimgalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] resimler;
        int hangiresim = 0;
        int i;
        bool baslat = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            resimler = Directory.GetFiles("../../resimler", "*.jpg");//proje klasörüne göre 2 kalasör yukarı çık
            foreach (string item in resimler)
            {
                Button btn = new Button();
                btn.Width = btn.Height = 68;
                btn.Margin = new Padding(0);//dış kenarlarında boşluk bırakılmayacak
                btn.BackgroundImage = Image.FromFile(item);
                btn.BackgroundImageLayout = ImageLayout.Stretch;//arka plan resmini kontrole göre sığdır
                btn.Tag = i++;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_click;
            }
        }
        void btn_click(object sender,EventArgs e)
        {
            Button tiklanan = sender as Button;
            pictureBox1.Image = Image.FromFile(resimler[Convert.ToInt32(tiklanan.Tag)]);


        }

        private void btnilk_Click(object sender, EventArgs e)
        {
            hangiresim = 0;
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);
        }

        private void btnson_Click(object sender, EventArgs e)
        {
            hangiresim = resimler.Length - 1;
         //   pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

            pictureBox1.ImageLocation = resimler[hangiresim];
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            hangiresim++;
            if (hangiresim > resimler.Length - 1) hangiresim = 0;
            //  pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

            pictureBox1.ImageLocation = resimler[hangiresim];

        }

        private void btnonceki_Click(object sender, EventArgs e)
        {
            hangiresim--;
            if (hangiresim <0) hangiresim = resimler.Length - 1;
            // pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

            pictureBox1.ImageLocation = resimler[hangiresim];
        }

        private void btnrastgele_Click(object sender, EventArgs e)
        {
            int rastgeleresim = 0;
            Random rnd = new Random();
            rastgeleresim = rnd.Next(0, resimler.Length);
            if(rastgeleresim==hangiresim)//aynı resim denk gelirse
                rastgeleresim= rnd.Next(0, resimler.Length);

            pictureBox1.ImageLocation = resimler[hangiresim];
            hangiresim = rastgeleresim;
        }

        private void btnslayt_Click(object sender, EventArgs e)
        {
            if (baslat)
            {  btnslayt.Text = "Slaytı Durdur";
            timer1.Interval = 700;//0,7 saniyede bir çalış
            timer1.Start();
                baslat = false;

            }
            else
            {
                timer1.Stop();
                btnslayt.Text = "Slaytı Başlat";
                baslat = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hangiresim++;
            if (hangiresim > resimler.Length - 1)
                hangiresim = 0;//sondaysa

            pictureBox1.ImageLocation = resimler[hangiresim];

        }
    }
}
