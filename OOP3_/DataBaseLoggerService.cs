using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_
{
    class DataBaseLoggerService:ILoggerService 
    {
        public void Log(ICrediManager crediManager)
        {
            Console.WriteLine($"Log to Database for {crediManager.Name()}");

        }
    }
}
