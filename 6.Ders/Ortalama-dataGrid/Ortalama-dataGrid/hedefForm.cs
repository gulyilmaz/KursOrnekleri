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
    public partial class hedefForm : Form
    {
        public hedefForm()
        {
            InitializeComponent();
        }

        public void AnaFormdanVeriAl(string Ad, int s1,int s2 ,int s3,int ort )
        {
            int satir = dataGridView1.Rows.Add();
            dataGridView1.Rows[satir].Cells[0].Value = Ad;
            dataGridView1.Rows[satir].Cells[1].Value = s1;
            dataGridView1.Rows[satir].Cells[2].Value = s2;
            dataGridView1.Rows[satir].Cells[3].Value = s3;
            dataGridView1.Rows[satir].Cells[4].Value = ort;
            if(ort>50)
            {
                dataGridView1.Rows[satir].Cells[4].Value = "Geçti";
            }
            else
            {
                dataGridView1.Rows[satir].Cells[5].Value = "Kaldı";
            }
        }
    }
}
