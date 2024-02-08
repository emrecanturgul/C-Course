using GameProject.AnaKütüphane.Business;
using GameProject.AnaKütüphane.Entity;
using GameProject.AnaKütüphane.Kontrol; 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.AnaKütüphane.Concretes
{
    public class CustomerManager : KontrolServis,ICustomerManager
    {
        public void Add(Customer customer)
        {
            if (CheckIfRealPerson(customer))
            {
                Console.WriteLine("Müşteri eklendi");
            }

        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
