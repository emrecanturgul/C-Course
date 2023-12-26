using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_
{
    internal class SoldierCredi : ICrediManager
    {
      public void Hesapla()
        {
            Console.WriteLine("Asker Kredisi Hesaplandı");
        }
        public string Name()
        {
            return "Asker";
        }
    }
}
