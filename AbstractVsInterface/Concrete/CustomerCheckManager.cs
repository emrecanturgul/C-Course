using AbstractVsInterface.Abstracts;
using AbstractVsInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Concrete
{
    public  class CustomerCheckManager: IPersonCheckService 
    {   
        public bool CheckIfRealPerson(Customer customer)
        {   
            //dış bir sistemi sisteme adapte ederken adapter adlı bir design pattern kullanılcak 
            return true;
        }

        
    }
}
