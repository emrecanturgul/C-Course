using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personmanager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1, Name = "emre", lastName = "can", age = 23, CustomerId = 1
            };
            SqlServerCustomerDal sqlServerCustomerDal= new SqlServerCustomerDal();
            ICustomerDal oracleCustomerDal = new OracleServerCustomerDal(); 
            personmanager.Add(customer);
            List<ICustomerDal> customerDals = new List<ICustomerDal>() { sqlServerCustomerDal,oracleCustomerDal};
            CustomerManager customerManager = new CustomerManager();
            customerManager.Methods(customerDals);  
        }
        interface IPerson
        {
            int Id { get; set; } 
            string Name { get; set;  }
            string lastName { get; set; } 
            int age { get; set; }

        }
        class Customer: IPerson
        {
            public int Id { get; set; } public string Name { get; set; }public string lastName { get; set; } public int age { get; set; } public int CustomerId { get; set; }   
        }
        class PersonManager
        {   public void Add(IPerson person )
            {
                Console.WriteLine(person.Name + " eklendi");
            } 

        }
    }
}
