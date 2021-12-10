using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdborta.Checked= true;
            cmbmenu.SelectedIndex = 0;
        }

        double[] fiyat = { 20, 24, 18 };
        double siparisFiyatBiriktir = 0;
        //Sipariş için notları biriktirmek için
        StringBuilder siparisnotlarım = new StringBuilder();
        double ekstra, toplamhesap;

        private void btnhesap_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toplamhesap.ToString());
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            listsiparisler.Items.Clear();
            //aldığın notu temizle
            siparisnotlarım.Clear();
            siparisFiyatBiriktir = 0;
            ekstra = 0;
            if(cmbmenu.SelectedIndex!=-1)
            {
                siparisFiyatBiriktir = fiyat[cmbmenu.SelectedIndex];
                //cmbden seçilen item içeriğini al stringe çevir ve ekle
                siparisnotlarım.Append(cmbmenu.SelectedItem.ToString());
                if(rdborta.Checked)
                {
                    siparisnotlarım.Append(" Orta Menü: ");
                }
                else if(rdbbuyuk.Checked)
                {
                    siparisFiyatBiriktir += 2;
                    siparisnotlarım.Append(" Büyük Menü (Farkı + 2 TL): ");
                }
                else if(rdbking.Checked)
                {
                    siparisFiyatBiriktir += 4;
                    siparisnotlarım.Append(" King Menü (Farkı + 4 TL): ");
                }
                //ekstralar groupbox kontrolunde bu yüzden onun kontrolllerinde dönücez
                foreach (Control checkekstra in grbekstralar.Controls)
                {//bu kontrol eğer bir checkboxa rastladı ve bu seçili ise
                    if (checkekstra is CheckBox && (checkekstra as CheckBox).Checked)
                    {
                        ekstra += 0.50;
                    }
                }
                    if(ekstra>0)
                    {
                        siparisnotlarım.Append(" Ekstralar: ");
                        //ekstra değişkenindeki sayısal veriyi currency tipine çevir yaz
                        siparisnotlarım.Append(ekstra.ToString("C2"));
                        siparisFiyatBiriktir += ekstra;
                    }
                    int adet = Convert.ToInt32(numadet.Value);
                    siparisFiyatBiriktir *= adet;
                    siparisnotlarım.Append(" "+adet.ToString());
                    siparisnotlarım.Append(" Adet: ");
                    siparisnotlarım.Append(" Toplam: ");
                    listsiparisler.Items.Add(siparisnotlarım.ToString() + siparisFiyatBiriktir.ToString("C2"));
                    toplamhesap += siparisFiyatBiriktir;

                



            }
        }
    }
}
