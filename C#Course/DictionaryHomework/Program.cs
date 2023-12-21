using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("emre", 95);
            myDictionary.Add("can", 87);

            for (int i = 0; i < myDictionary._Length; i++)
            {
                Console.WriteLine($"\nkey = {myDictionary._Keys[i]} and  value = {myDictionary._Values[i]} ");
            }
        }
    }
}
