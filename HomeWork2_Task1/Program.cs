using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task1
{
    /*Щукин Андрей
     * 1. Написать метод, возвращающий минимальное из трёх чисел.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinNum(new List<int>() { 10, 2, -11 }));
            Console.ReadKey();
        }

        static int MinNum(List<int> list)
        {
            if (list.Count > 0)
            {
                int min = list[0];

                foreach (var e in list)
                {
                    if (e < min) min = e;
                }
                return min;
            }
            else
            {
                Console.WriteLine("Последовательность не содержит чисел для сравнения");
                return 0;
            }
        }
    }
}
