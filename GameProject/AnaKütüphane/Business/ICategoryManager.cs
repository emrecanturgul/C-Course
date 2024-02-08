using GameProject.AnaKütüphane.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks; 

namespace GameProject.AnaKütüphane.Business
{
    public interface ICategoryManager
    {
        void Update(Category category);
        void Delete(Category category); 
        void Add(Category category); 

    }
}
