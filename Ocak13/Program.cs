using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ocak13
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager(); 
            employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Ekleme(new CustomerManager());
            

             
        }
         interface IPersonManager
        {
            void Add(); 

        }
        //inherits - class - implements - interface 
        class CustomerManager: IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri Eklendi");
            }
        }
        class EmployeeManager: IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Çalışan eklendi");
            }
        }
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("stajyer eklendi ");
            }
        }
        class ProjectManager
        {
            public void Ekleme(IPersonManager personManager)
            { 
                    
                personManager.Add();
                

            }
        }
    } 
}
