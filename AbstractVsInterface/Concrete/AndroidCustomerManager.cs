using AbstractVsInterface.Abstracts;
using AbstractVsInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Concrete
{
    public  class AndroidCustomerManager : BaseCustomerManager

    {
        IPersonCheckService _personCheckService;
        public AndroidCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public override void Save (Customer customer )
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); 

            }
            else
            {
                throw new Exception("not a valid Person"); 
            }
        }
    }
}
