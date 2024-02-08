using GameProject2.Abstracts;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    internal class UserManager : BaseUserManager 
    {

        List<User> users = new List<User>();
        public override void DeleteUser(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user); 
                base.DeleteUser(user);
            }
            else
            {
                Console.WriteLine("User do not contain with this user " + user.Name + user.Surname);
            }
        }
        public override void SignIn(User user, IUserCheckService userCheckService)
        {
            if (userCheckService.isRealPerson(user))
            {
                users.Add(user); 

            } 
            else
            {
                throw new Exception("User is not valid"); 
            }
        }


    }
}
