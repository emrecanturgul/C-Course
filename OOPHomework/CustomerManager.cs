using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    internal class CustomerManager
    {
        public void Methods(List<ICustomerDal> customerDals)
        {

            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
                customerDal.Add();
                customerDal.Update(); 

            }
        }
    }
} 
