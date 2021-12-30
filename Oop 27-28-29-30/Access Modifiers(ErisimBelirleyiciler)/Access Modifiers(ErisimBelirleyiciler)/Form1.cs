using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Modifiers_ErisimBelirleyiciler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Public: Uygulamamızın içinde veya dışarısında ulaşılabilir.
            //Private:Sadec tanımlandığı class içerisinde erişilebilir.
            //protected:Normal kullanımda private gibi gibi çalışır.Kalıtım alınırsa public olarak işlem görür.
            //internal:Bu namespace in içerisnde ulaşılabilir. Clasların varsayılan erişim belirleyicisidir.

            Kisi k = new Kisi();
            Ogrenci o = new Ogrenci();
            

        }
    }
}
