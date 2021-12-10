using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_dataGrid
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        hedefForm frm = new hedefForm();
        private void button1_Click(object sender, EventArgs e)
        {
           
            verigonder();
            
        }

        private void verigonder( )
        {
            string ad = textBox1.Text;
            int s1 =Convert.ToInt32( textBox2.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            int s3 = Convert.ToInt32(textBox4.Text);
            int ort = (s1 + s2 + s3) / 3;
            frm.AnaFormdanVeriAl(ad,s1,s2,s3,ort);
            frm.Show();
        }
    }
}
