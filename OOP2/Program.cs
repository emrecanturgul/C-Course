using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            
        IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "123";
            customer1.Id = 1; 
            customer1.Name = "Emre";
            customer1.Surname = "Turgul";
            customer1.IdNo = "222222222"; 
        CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.CustomerNo = "124";
            customer2.Id = 2;
            customer2.CompanyName = "Turgul Comp.";
            customer2.TaxNo = "123456789";
        Customer customer3 = new IndividualCustomer();
        Customer customer4 = new CoorporateCustomer(); 
        CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
                 

        }
    }
}

