using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<KupKutu> klist = new List<KupKutu>();
        private void btnkup_Click(object sender, EventArgs e)
        {
            KupKutu k = new KupKutu();
            k.Id = 1;
            k.UrunAd = "Mukavva kutu";
            k.yukseklik = 15;
            klist.Add(k);
            KupKutu k2 = new KupKutu();
           k2.Id = 2;
            k2.UrunAd = "Karton kutu";
            k2.yukseklik = 10;
            klist.Add(k2);

            KupKutu k3 = new KupKutu();
            k3.Id = 3;
            k3.UrunAd = "Tahta kutu";
            k3.yukseklik = 10;
            klist.Add(k3);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = klist;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.DataBoundItem is KupKutu)
            {
                KupKutu k =(KupKutu) dataGridView1.CurrentRow.DataBoundItem;
                int hacim = k.Hacim();
                MessageBox.Show(hacim.ToString());
            }
            else
            {
                DikdortgenKutu d = (DikdortgenKutu)dataGridView1.CurrentRow.DataBoundItem;
                int hacim = d.Hacim();
                MessageBox.Show(hacim.ToString());

            }

        }
        List<DikdortgenKutu> dlist = new List<DikdortgenKutu>();
        private void btndikdortgen_Click(object sender, EventArgs e)
        {
            DikdortgenKutu d = new DikdortgenKutu();
            d.Id = 1;
            d.UrunAd = "Kutu";
            d.UzunKenar = 12;
            d.Kisakenar = 5;
            d.yukseklik = 7;
            dlist.Add(d);
            DikdortgenKutu d2= new DikdortgenKutu();
            d2.Id = 2;
            d2.UrunAd = "metal Kutu";
            d2.UzunKenar = 17;
            d2.Kisakenar = 9;
            d2.yukseklik = 10;
            dlist.Add(d2);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dlist;
        }
    }
}
/*
 console projesi
2 tane ınterface olucak
---Iaraba: marka, model,Model yili,sanzıman ,Özellikoku adında bir metod
---Inumara: yildiz int tipinde 
--Araba sınıfı clası 2 sindende miras alıcak.Model yılı 2005 ten küçükse default deger 2005 değilse value alanı kullanıcın girdiği değer olucak
--araba clasında yıldız propertysi 5 ten büyük girildiyse 5 olarak atansın değilse kullanıcın girdiği değer value ya atansın.
---ozellikOku metodunda da -- Araç Özelliklerimiz+Markası: ....+Şanzıman Türü: .......+ModelYılı: ........+Puani:.........
 
 
 
 
 
 */