using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        private void btngonder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = olist;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.ogrenciId = i;
                o.AD = FakeData.NameData.GetFirstName();
                o.Soyad = FakeData.NameData.GetSurname();
                olist.Add(o);
            }
        }
    }
}
