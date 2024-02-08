using GameProject.AnaKütüphane.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.AnaKütüphane.Kontrol
{
    public interface IKontrolManager
    {
        bool CheckIfRealPerson(Customer customer);
        
    }
}
