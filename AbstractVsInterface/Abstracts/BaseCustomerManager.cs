using AbstractVsInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Abstracts
{
    public abstract  class BaseCustomerManager
    {
         public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db" + customer.Name);
        }
    }
}
