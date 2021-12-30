using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
   public class genericRepository<T> where T:class
    {
        public genericRepository()
        {
            //context :Ef Dbfirst
        }
        public virtual List<T> Getir()
        {
            //Gelen T tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic olarak bir üst katmana dönmek
            return null;
        }
        public  virtual void yenikayitekle(T data)
        {
            //bize  gelen t tipi içerisindeki T tipinin işart etmiş olduğu tabloya ekliyoruz.
        }

    }
}
