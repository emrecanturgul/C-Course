using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_
{
    class CarCrediManager : ICrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
        public string Name()
        {
            return "araba"; 
        }
    }
}
