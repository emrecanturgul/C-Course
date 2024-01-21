using AbstractVsInterface.Abstracts;
using AbstractVsInterface.Adapters;
using AbstractVsInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Concrete
{
     public class AppleCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public AppleCustomerManager(IPersonCheckService personCheckService) {
            _personCheckService = personCheckService; 
        }

        public AppleCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
        
    }

}
