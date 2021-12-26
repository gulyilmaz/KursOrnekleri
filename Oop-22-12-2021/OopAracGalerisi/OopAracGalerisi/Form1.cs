using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAracGalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string rsmYol = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            rsmYol += "/Image";
            if (!Directory.Exists(rsmYol)) Directory.CreateDirectory(rsmYol);///proje çalışınca proje kalasöründe ımage klasörü oluştu
            foreach (Control item in grbArac.Controls)
            {
                if (item is ComboBox)
                {
                    (item as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;//Dropdown özelliğinin kontrolde geçerli olaması için as ile tip çevrimi yapmak zorundayım.
                }
            }
            openFileDialog.InitialDirectory = Application.ExecutablePath;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRenk.TextAlign = ContentAlignment.BottomLeft;//butonların metni alt ve sola yaslı olsun
            lblRenk.BorderStyle = BorderStyle.FixedSingle;
            colorDialog.FullOpen = true;
            numYil.Maximum = DateTime.Today.Year;
            numYil.Minimum = 2005;
            numMotor.Minimum = 1000;
            numMotor.Maximum = 5000;
            numMotor.Increment = 100;//100 100artsın ya da azalsın
            EnumYukle(Enum.GetNames(typeof(AracTuru)), cmbArac);
            EnumYukle(Enum.GetNames(typeof(Marka)), cmbMarka);
            EnumYukle(Enum.GetNames(typeof(Model)), cmbModel);
            EnumYukle(Enum.GetNames(typeof(SanzimanTuru)), cmbSanziman);
            EnumYukle(Enum.GetNames(typeof(YakitTuru)), cmbYakit);
            EnumYukle(Enum.GetNames(typeof(KasaTipi)), cmbKasa);
        }
        private void EnumYukle(string[] Enums, ComboBox cmb)
        {
            cmb.Items.AddRange(Enums);
            cmb.SelectedIndex = 0;
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            lblRenk.BackColor = colorDialog.Color;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            AracGalerisi arac = new AracGalerisi()
            {
                AracinTuru = (AracTuru)cmbArac.SelectedIndex,
                isGaranti = chkGaranti.Checked,
                KasaTip = (KasaTipi)cmbKasa.SelectedIndex,
                Markasi = (Marka)cmbMarka.SelectedIndex,
                Modeli = (Model)cmbModel.SelectedIndex,
                ModelYili = (int)numYil.Value,
                MotorGucu = (int)numMotor.Value,
                Renk = (Color)lblRenk.BackColor,
                Sanzimani = (SanzimanTuru)cmbSanziman.SelectedIndex,
                YakitTipi = (YakitTuru)cmbYakit.SelectedIndex,
                AracResmi = pictureBox.Image
            };
            lstArac.Items.Add(arac);
        }

        private void chkGaranti_CheckedChanged(object sender, EventArgs e)
        {
            chkGaranti.Text = chkGaranti.Checked ? "Garantisi Var" : "Garantisi Yok";
        }

        private void lstArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArac.SelectedIndex != -1) AracClassDoldur();

        }
        private void AracClassDoldur()
        {
            AracGalerisi secilenArac = (AracGalerisi)lstArac.SelectedItem;
            cmbArac.SelectedIndex = (int)secilenArac.AracinTuru;
            chkGaranti.Checked = secilenArac.isGaranti;
            cmbKasa.SelectedIndex = (int)secilenArac.KasaTip;
            cmbMarka.SelectedIndex = (int)secilenArac.Markasi;
            cmbModel.SelectedIndex = (int)secilenArac.Modeli;
            numYil.Value = secilenArac.ModelYili;
            numMotor.Value = secilenArac.MotorGucu;
            lblRenk.BackColor = secilenArac.Renk;
            cmbSanziman.SelectedIndex = (int)secilenArac.Sanzimani;
            cmbYakit.SelectedIndex = (int)secilenArac.YakitTipi;
            pictureBox.Image = btnKucukResim.BackgroundImage = secilenArac.AracResmi;
          

        }

        private void temizle()
        {
            
            cmbArac.SelectedIndex = 0;
        }

        private void lstArac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { lstArac.Items.Remove(lstArac.SelectedItem);

                temizle();
            }

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Image resim = Image.FromFile(openFileDialog.FileName);
            pictureBox.Image = btnKucukResim.BackgroundImage = resim;
        }

        private void btnKucukResim_DragEnter(object sender, DragEventArgs e)
        {
           
                object suruklenen = e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    Image resim = Image.FromFile(((string[])suruklenen)[0]);
                    pictureBox.Image = btnKucukResim.BackgroundImage = resim;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sadece İmaj yükleyiniz.");
                }

            
        }


      
    }
    }

