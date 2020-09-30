using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiV1.Helper
{
    public class Tablas
    {
      public  int[] factores { get; set; }
       public int[] FactoresLIST { get; set; }
        public Tablas() {
            FactoresLIST = new int [10];
        }

      
    }
}