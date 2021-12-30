using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulama.database;
using ToDoListUygulama.entities;

namespace ToDoListUygulama.businessServices
{
    public class todoService
    {
        public int kayitKontrol()
        {
            return sanaldatabase.todoTablo.Count;
        }

        public List<todo> kayitListe()
        {
            return sanaldatabase.todoTablo;
        }
        public int kayitYeni(todo data)
        {
            try {
                sanaldatabase.todoTablo.Add(data);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }


    }
}
