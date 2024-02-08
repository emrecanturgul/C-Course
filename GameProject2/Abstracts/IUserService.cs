using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstracts
{
    public  interface IUserService
    {
        public void UpdateInformation(User InSystem , User afterUpdate); 
        public void SignIn (User user, IUserCheckService userCheckService);   
        
        public void DeleteUser(User user ); 



    }
}
