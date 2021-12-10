using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıKdv
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            VeriGonder();
        }

        private void VeriGonder()
        {

            string UrunAd = txtUrunAd.Text;
            decimal Fiyat = Convert.ToDecimal(txtFiyat.Text);
            decimal KdvOran = Convert.ToDecimal(txtKdvOran.Text);
            decimal KdvliFiyat = Fiyat * (1 + KdvOran / 100);
            HedefForm frm = new HedefForm();
            frm.AnaFormdanVeriAl(UrunAd, Fiyat, KdvOran, KdvliFiyat);
            frm.Show();
        }
    }
}
