using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulama.database;
using ToDoListUygulama.entities;

namespace ToDoListUygulama.businessServices
{
  public  class kullaniciService
    {
        public kullanici kullaniciKontrol(string kullaniciAdi,string sifre)
        {
            return sanaldatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();
        }
    }
}
