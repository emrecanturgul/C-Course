using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstracts
{
    public abstract class BaseUserManager : IUserService
    {       
         
        public virtual void DeleteUser (User user ) {

            Console.WriteLine("User Deleted" + user);
        } 
         public virtual void SignIn(User user, IUserCheckService userCheckService)
        {
                 
             
        } 
        public void UpdateInformation(User inSystem , User afterUpdate)
        {
            inSystem.Name = afterUpdate.Name; 
            inSystem.Surname = afterUpdate.Surname; 
            inSystem.DateOfBirth = afterUpdate.DateOfBirth; 
            inSystem.NationalityId = afterUpdate.NationalityId;
            Console.WriteLine("User update process is done");

        }
    }
}
