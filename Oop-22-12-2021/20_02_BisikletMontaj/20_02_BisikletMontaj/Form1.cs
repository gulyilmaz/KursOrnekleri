using System;
using System.Windows.Forms;

namespace BisikletClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFren.Items.AddRange(Enum.GetNames(typeof(FrenTipi)));
            cmbFren.SelectedIndex = 0;
            cmbKadro.Items.AddRange(Enum.GetNames(typeof(KadroTipi)));
            cmbKadro.SelectedIndex = 0;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Bisiklet bcycle = new Bisiklet
            {
                Fren = (FrenTipi)cmbFren.SelectedIndex,
                Kadro = (KadroTipi)cmbKadro.SelectedIndex,

                ModelYili = dateModelYılı.Value.Year
            };
            txtYasi.Text = bcycle.Yasi.ToString();
            MessageBox.Show(bcycle.ToString());
        }
    }
}