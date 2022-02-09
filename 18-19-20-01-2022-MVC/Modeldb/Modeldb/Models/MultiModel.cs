using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modeldb.Models
{
    public class MultiModel
    {
        public List<Products> plist { get; set; }
        public List<Categories> clist { get; set; }
    }
}