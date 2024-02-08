using GameProject.AnaKütüphane.Entity;
using GameProject.AnaKütüphane.Concretes; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.AnaKütüphane.Kontrol
{
   public class KontrolServis : IKontrolManager 
    {
         public bool CheckIfRealPerson(Customer customer)
        {
            Boolean isReal = false; 
            if (customer.Name != null)
            {
                isReal = true; 
            }
            return isReal; 
        }
    }
}
