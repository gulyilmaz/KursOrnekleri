using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListUygulama.businessServices;
using ToDoListUygulama.entities;

namespace ToDoListUygulama
{
    public partial class sistemgiris : Form
    {
        public sistemgiris()
        {
            InitializeComponent();
        }

        private void txtkullaniciad_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtkullaniciad_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtkullaniciad.Text) || !string.IsNullOrEmpty(txtsifre.Text))
            {
                kullaniciService kullaniciservice = new kullaniciService();
                kullanici kontrolkullanici = kullaniciservice.kullaniciKontrol(txtkullaniciad.Text, txtsifre.Text);
                if (kontrolkullanici != null)
                {
                    Form anaform = Application.OpenForms["Form1"];
                    Panel solpanel =(Panel) anaform.Controls["panel1"];
                    GroupBox grbislemliste =(GroupBox) solpanel.Controls["groupBoxislemlistesi"];
                    foreach (Control item in grbislemliste.Controls)
                    {
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }

                    }
                    MessageBox.Show("Merhaba" + kontrolkullanici.kullaniciAdi, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre ", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
