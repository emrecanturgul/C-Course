using AbstractVsInterface.Abstracts;

using AbstractVsInterface.Adapters;
using AbstractVsInterface.Concrete;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace AbstractVsInterface
{
    
    class Program
    {   static void Main(string[] args)
        {
            // kahve dükkanları için müşteri yönetimi yapan bir sistem 
            //starbucks ve nero firmaları 
            //iki firma da veri tabanına kaydetmek istiyor 
            //mernis doğrulaması istiyor starbucks nero öyle bir şey istemiyor 
            //starbucks her kahve alımında yıldız kazandırmak istiyor 

            BaseCustomerManager customerManager = new AndroidCustomerManager(new MernisServiceAdapter());
            

            BaseCustomerManager customerManager2 = new AppleCustomerManager(new MernisServiceAdapter()); 

            customerManager2.Save(new Entities.Customer { DateOfBirth = new DateTime(2004,06,07), Name = "Emrecan", LastName = "Turgul", NationalityId = "123456789", Id = 1 });
            Console.ReadLine(); 



        }

    }
    
}