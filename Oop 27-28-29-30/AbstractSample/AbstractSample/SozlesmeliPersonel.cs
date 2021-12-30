using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    public class SozlesmeliPersonel : BasePersonel
    {
        public int SaatlikOdeme { get; set; }
        public int calismasuresi { get; set; }

        public override int AylikMaas()
        {
            return SaatlikOdeme * calismasuresi;
        }
    }
}
