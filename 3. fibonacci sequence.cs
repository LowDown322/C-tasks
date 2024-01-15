using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display the fibonacci sequence function");

            Console.WriteLine("---------------------------------------");

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < ; i++)
            {
                Console.Write(fibboFunction(i) + " ");
            }
        }
        static int fibboFunction(int i)
        {
            if (i == 0)
            {
                // i = 0 in this case since the first number of fibonacci is 0
                return i;

            }
            else if (i == 1)
            {
                return i;
            }
            else
            {
                return fibboFunction(i - 1) + fibboFunction(i - 2);
            }
        }
    }
}
