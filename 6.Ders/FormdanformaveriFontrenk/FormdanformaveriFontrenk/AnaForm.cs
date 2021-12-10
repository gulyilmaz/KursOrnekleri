using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormdanformaveriFontrenk
{
    public partial class AnaForm : Form
    {
        HedefForm hdform = new HedefForm();//ana formda girilen verileri hedef formda göstermek için Hedeffomu formu instance açtık.
        public AnaForm()
        {
            InitializeComponent();
        }
      
      

      
        public void RenkAl()//Renk fontu için metot oluşturduk.
        {
            ColorDialog renk = new ColorDialog();//Color renk dialogunu çağırdık.
            renk.ShowDialog();
            txt_adi.ForeColor = renk.Color;
            txt_soyadi.ForeColor = renk.Color;
            txt_aciklama.ForeColor = renk.Color;
        }
        public void FontAl()
        {
            FontDialog fontlar = new FontDialog();//Fon dialogunu çağırdık.
            fontlar.ShowDialog();
            txt_adi.Font = fontlar.Font;
            txt_soyadi.Font = fontlar.Font;
            txt_aciklama.Font = fontlar.Font;
        }
        public void GonderilecekVeriler()//Gönderilecek veriler için bir metot oluşturduk
        {
            hdform.lbl_adi.Text = txt_adi.Text;/*.Substring(0, 1).ToUpper() + txt_adi.Text.Substring(1);//Girilen ismin ilk harfi küçük girilse bie  büyük harfe dönüştürdük.*/
            hdform.lbl_adi.Font = txt_adi.Font;
            hdform.lbl_adi.ForeColor = txt_adi.ForeColor;

            hdform.lbl_soyadi.Text = txt_soyadi.Text.ToUpper();//Girilen soyismi küçük harf girilse bile büyük harfe dönüştürdük.
            hdform.lbl_soyadi.Font = txt_soyadi.Font;
            hdform.lbl_soyadi.ForeColor = txt_soyadi.ForeColor;

            hdform.lbl_aciklama.Text = txt_aciklama.Text;
            hdform.lbl_aciklama.Font = txt_aciklama.Font;
            hdform.lbl_aciklama.ForeColor = txt_aciklama.ForeColor;

            hdform.Show();
        }
        public void Clear()//Clear metotunu oluşturduk.
        {
            txt_adi.Clear();
            txt_aciklama.Clear();
            txt_soyadi.Clear();
            hdform.Close();
        }

        private void btn_fontayarla_Click_1(object sender, EventArgs e)
        {
            FontAl();//Fontları alma metotunu çağırdık.
           
        }

        private void btn_renkayarla_Click(object sender, EventArgs e)
        {

            RenkAl();//renkleri alma metotunu çağırdık.
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            Clear();//Silme metotunu çağırdık.
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            GonderilecekVeriler();//Gönderilecek Verileri alma metotunu çağırdık.
        }
    }
}
