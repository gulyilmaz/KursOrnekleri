using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulama.entities;

namespace ToDoListUygulama.database
{
   public static class sanaldatabase
    {
        public static List<kullanici> kullaniciTablo;
        public static List<todo> todoTablo;
       static sanaldatabase()
        { kullaniciTablo = new List<kullanici>();
            kullaniciTablo.Add(new kullanici()
            {
                id = Guid.NewGuid(), kullaniciAdi="test1",sifre="1"
            });
            todoTablo = new List<todo>();


        }

    }
}
