using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka
{
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }
        List<musteri> mlist = new List<musteri>();
        private void buttonekle_Click(object sender, EventArgs e)
        {
            musteri m = new musteri();
            m.Id = Convert.ToInt32(textBoxId.Text);
            m.Ad = textBoxAd.Text;
            m.Soyad = textBoxSoyad.Text;
            m.KrediKart = textBoxkkart.Text;
            mlist.Add(m);
            temizle();
        }

        private void temizle()
        {
            textBoxId.Clear();
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxkkart.Clear();
        }

        private void buttongoster_Click(object sender, EventArgs e)
        {
            List<musteri> m = new List<musteri>();
            
                foreach (var item in mlist)
                {
                    musteri mst = new musteri();
                    mst.Ad = item.Ad;
                    mst.Soyad = item.Soyad;
                    mst.Id = item.Id;
                    mst.KrediKart = item.KrediKart;
                    m.Add(mst);

                }
               
                
            
            dataGridView1.DataSource = m;


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { musteri secmusteri = (musteri)dataGridView1.CurrentRow.DataBoundItem;
            textBoxad1.Text = secmusteri.Ad;
            textBoxsoyad1.Text = secmusteri.Soyad;
            textBoxkart1.Text = secmusteri.getkredikart();

        }
    }
}
