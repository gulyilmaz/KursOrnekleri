using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koleksiyonlar_Örnek_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList();
        private void ekle_Click(object sender, EventArgs e)
        {
            dizi.Add(textBox1.Text);
           listBox1.Items.Add(textBox1.Text);
        }

      
        private void listele_Click(object sender, EventArgs e)
        {
            listbox_temizle();
        }
        private void listbox_temizle()
        {
            listBox1.Items.Clear();
            foreach (object item in dizi)
            {
                listBox1.Items.Add(item);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            dizi.Remove(textBox1.Text);
            dizi.Remove(listBox1.SelectedItem);
            listbox_temizle();
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenindex = listBox1.SelectedIndex;
                dizi[secilenindex] = textBox1.Text;
                listbox_temizle();
            }
            catch
            {
                MessageBox.Show("düzenlemek istediğiniz değeri seçmediniz");
            }
        }

        private void ara_Click(object sender, EventArgs e)
        {
           bool kontrol= dizi.Contains(textBox1.Text);
            if (kontrol)
            {
                int eleman = dizi.IndexOf(textBox1.Text);
                MessageBox.Show($"aradığın değer dizinin {eleman + 1}. elemanı");
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
