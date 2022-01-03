using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatAcentesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int arakoltuk = 3;
            int boshazirlananlaricineklencekler = 0;

            int koridoricinboshazırlanankoltuklarharic = 0;

            for (int i = 1; i <= 54+boshazirlananlaricineklencekler; i++)
            {
                Button btn = new Button();
                btn.Width = 37;
                btn.Margin = new Padding(all: 1);
                if(i==arakoltuk)
                {
                    arakoltuk += 5;
                    btn.Height = 0;
                    boshazirlananlaricineklencekler++;

                }
                else
                {
                    koridoricinboshazırlanankoltuklarharic++;
                    btn.Height = 37;
                    btn.Text = koridoricinboshazırlanankoltuklarharic.ToString();
                    btn.Tag = koridoricinboshazırlanankoltuklarharic;

                }
                btn.Click += btn_click;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                flwPanel.Controls.Add(btn);



            }

            grbKisisel.Enabled = false;
            Label lblKapi = new Label();
            lblKapi.Height = 37;
            lblKapi.Width = 77;
            lblKapi.BorderStyle = BorderStyle.FixedSingle;
            lblKapi.BackColor = Color.Cornsilk;
            lblKapi.Margin = new Padding(39, 1, 0, 0);
            lblKapi.Text = "KAPI";
            lblKapi.TextAlign = ContentAlignment.MiddleCenter;
            flwPanel.Controls.Add(lblKapi);
            rdbBay.Checked = true;
            txtKoltuk.Enabled = false;



        }
        Button secilenbutonhafizadatut;
        private void btn_click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
            grbKisisel.Enabled = true;
            txtKoltuk.Text = mybtn.Tag.ToString();
            secilenbutonhafizadatut = mybtn;


        }
        string boslar;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control txt in grbKisisel.Controls)
            {
                if(txt is TextBox)
                {
                    TextBox mytxt = txt as TextBox;
                    if (string.IsNullOrEmpty(mytxt.Text))
                    {
                        boslar = mytxt.Name + "-";
                            }
                    if(!string.IsNullOrEmpty(boslar))
                    {
                        MessageBox.Show(boslar, "Şu nesneleri boş bıraktınız");
                        mytxt.Select();
                        return;
                    }

                }
                
            }
            string cinsiyet = rdbBay.Checked ? rdbBay.Text : rdbBayan.Text;
            string veriler = txtKoltuk.Text + " nolu koltuk :" + txtAd.Text + txtSoyad.Text + " " + cinsiyet + " Tel no:" + txtTelNo.Text;
            lboxSatilanKoltuklar.Items.Add(veriler);
            cinsiyet = rdbBay.Checked ? "..//..//Images//man.png" : "..//..//Images//woman.png";
            secilenbutonhafizadatut.BackgroundImage = Image.FromFile(cinsiyet);
            secilenbutonhafizadatut.Enabled = false;
            secilenbutonhafizadatut.BackColor = rdbBay.Checked ? Color.Azure : Color.LightPink;
            grbKisisel.Enabled = false;
            MessageBox.Show("kayıt başarılı");


        }
    }
}
