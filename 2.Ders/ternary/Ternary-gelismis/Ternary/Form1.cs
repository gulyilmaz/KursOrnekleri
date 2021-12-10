using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            DateTime dogTarihi = dateTimePicker1.Value;
            TimeSpan kacGunGecti = DateTime.Now.Subtract(dogTarihi);//iki tarih arasında değer döndürür
            DateTime yas = DateTime.MinValue + kacGunGecti;
            //min value 01.01.0001 ondan bir çıkarıyoruz
            int yil = yas.Year - 1;
            int ay = yas.Month - 1;
            int gün = yas.Day - 1;
            int yasSiniriKac = Convert.ToInt32( textBox2.Text);
            string yasi = yil + " Yıl";
            yasi += ay > 0 ? ay + " Ay " : string.Empty;

            yasi += gün> 0 ? gün + " Gün" : string.Empty;
            if(yil<= yasSiniriKac-1)
            {
                MessageBox.Show(textBox1.Text + " Yaşınız : " + yasi + "  yaşınız tutmuyor ", Environment.UserName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { MessageBox.Show(textBox1.Text + " Yaşınız: " + yasi, Environment.UserName, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
