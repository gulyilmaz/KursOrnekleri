using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Yontem
{
    public partial class GelenForm : Form
    {
        public GelenForm()
        {
            InitializeComponent();
        }
        public string veri
        {
          set{ label1.Text = value; }
        }
    }
}
