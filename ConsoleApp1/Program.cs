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
            bool flag = true;
            int boof = 0;
            //Сортировка пузырьками
            do {
                flag = false;
                for (int i = 0; i < masInt.Length - 1; i++)
                {
                    if (masInt[i] > masInt[i + 1])
                    {
                        boof = masInt[i];
                        masInt[i] = masInt[i + 1];
                        masInt[i + 1] = boof;
                        flag = true;
                    }
                }
            } while (flag);
            Console.WriteLine("Сортировка пузырьками");
            count = 0;
            foreach (int item in masInt)
            {
                count++;
                Console.WriteLine("[{0}] {1}", count, item);
            }
            //Сортировка вставкой
            int max;
            for (int i = 0; i < masInt.Length; i++)
            {
                max = i;
                for (int j = i+1; j < masInt.Length; j++)
                {
                    if (masInt[max] < masInt[j])
                    {
                        max = j;
                    }
                }
                boof = masInt[i];
                masInt[i] = masInt[max];
                masInt[max] = boof;
            }
            Console.WriteLine("Сортировка вставкой");
            count = 0;
            foreach (int item in masInt)
            {
                count++;
                Console.WriteLine("[{0}] {1}", count, item);
            }
        }
    }
}
