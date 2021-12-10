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
    public partial class HedefForm : Form
    {
        public HedefForm()
        {
            InitializeComponent();
        }
        public void AnaFormdanVeriAl(string urunAd, decimal Fiyat, decimal kdvoran, decimal kdvliFiyat)
        {
            lbUrunAd.Text = urunAd;
            lbFiyat.Text = Fiyat.ToString();
            lbKdvOran.Text = kdvoran.ToString();
            lbKdvliFiyat.Text = kdvliFiyat.ToString();
        }
    }

}
