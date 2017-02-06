using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");
            int[] masInt = { 1, 3, 23, 34, 99, 12, 2 };
            int count = 0;
            foreach (int item in masInt)
            {
                count++;
                Console.WriteLine("[{0}] {1}", count, item);
            }
        }
    }
}
