using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    public class FullTimePersonel : BasePersonel
    {
        public int YillikMaas { get; set; }
        public override int AylikMaas()
        {
            return YillikMaas / 12;
        }
    }
}
