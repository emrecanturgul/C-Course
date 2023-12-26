using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager,ILoggerService loggerService )
        {
             crediManager.Hesapla();
           
        }
        public void CrediPreView(List<ICrediManager> loans)
        {
            foreach(var item in loans)
            {
                item.Hesapla();

            }

        }
    }
}
