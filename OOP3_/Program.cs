using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NeedCrediManager needCrediManager = new NeedCrediManager();
            CarCrediManager carCrediManager = new CarCrediManager();
            HouseCrediManager houseCrediManager = new HouseCrediManager();
            ICrediManager houseCrediManager2 = new HouseCrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> loggers = new List<ILoggerService>
            {new SmsLoggerService(), new DataBaseLoggerService()  };
            basvuruManager.BasvuruYap(new SoldierCredi(),loggers);

            List<ICrediManager> krediler = new List<ICrediManager>() { needCrediManager, carCrediManager };
            //basvuruManager.CrediPreView(krediler);
           
           
        }
    }
}
