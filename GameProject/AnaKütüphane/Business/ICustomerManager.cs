using GameProject.AnaKütüphane.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.AnaKütüphane.Business
{
    public  interface ICustomerManager
    {
        void Update(Customer customer );
        void Delete(Customer customer);
        void Add(Customer customer);

    }
}
