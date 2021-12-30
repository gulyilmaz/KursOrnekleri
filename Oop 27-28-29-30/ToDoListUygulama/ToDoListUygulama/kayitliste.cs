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
    public partial class kayitliste : Form
    {
        todoService todoService;
        public kayitliste()
        {
            InitializeComponent();
            todoService = new todoService();
        }

        private void kayitliste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false;

        }

        private List<todo> TumListe()
        {
            return todoService.kayitListe();
        }

        private void btntumliste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btntamamlandi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btntamamlanamadi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanmadı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btniptaledildi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            dataGridView1.Columns["id"].Visible = false;

        }
    }
}
