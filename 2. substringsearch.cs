using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String searchString = "rocknroll is good for your soul";
            String subStringToFind = "roll is good";

            Console.WriteLine("input the string: rocknroll is good for your soul");
            String stringToSearch = Console.ReadLine().ToUpper();
           
            Console.WriteLine("input the substring to search: roll is good");
            subStringToFind = Console.ReadLine();
            if (stringToSearch.Contains(subStringToFind))
            {
                Console.WriteLine("substing exists in the main string");
            }
            else
            {
                Console.WriteLine("substring not found");
            }
        }
    }
}
