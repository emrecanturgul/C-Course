using GameProject.AnaKütüphane.Business;
using GameProject.AnaKütüphane.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.AnaKütüphane.Concretes
{
    public class CategoryManager : ICategoryManager
    {
        public void Add(Category category)
        {
            Console.WriteLine("Kategori eklendi" + category.Name);
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Kategori silindi" + category.Name);
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategori güncellendi" + category.Name);
        }
    }
}
