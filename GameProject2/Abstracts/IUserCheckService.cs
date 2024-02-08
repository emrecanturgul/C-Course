using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstracts
{
    public interface IUserCheckService
    {
        bool isRealPerson(User user); 
       
    }
}
