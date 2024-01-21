using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    internal interface ICustomerDal
    {
        void Add(); 
        void Update();
        void Delete();  
    }
    class SqlServerCustomerDal: ICustomerDal
    {
        public void Add() { Console.WriteLine("Sql servere eklendi"); }
        public void Update() { Console.WriteLine("sql serverinde güncellendi");  }
        public void Delete() { Console.WriteLine("sql serverinde silindi"); }

    }
    class OracleServerCustomerDal: ICustomerDal
    {
        public void Add() { Console.WriteLine("Oracle servere eklendi"); }
        public void Update() { Console.WriteLine("Oracle serverinde güncellendi"); }
        public void Delete() { Console.WriteLine("Oracle serverinde silindi"); }
    }
    
}
