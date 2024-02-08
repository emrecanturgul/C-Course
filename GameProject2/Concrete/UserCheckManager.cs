using GameProject2.Abstracts;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    internal class UserCheckManager : IUserCheckService
    {    
         public bool isRealPerson(User user)  
        {
            Console.WriteLine("kullanıcı edevlet sistemi verileri tarafından onaylanmıştır");
            return true; 
        }

        
    }
}
