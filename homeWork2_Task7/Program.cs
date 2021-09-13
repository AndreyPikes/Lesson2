using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2_Task7
{
    /*Щукин Андрей
     * 7.
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
    class Program
    {
        static void Main(string[] args)
        {
            PrintSequence(2, 5);
            Console.WriteLine("****************");
            Console.WriteLine($"Сумма чисел = {SumSequence(2,5,0)}");

            Console.ReadKey();
        }

        static void PrintSequence(int start, int end)
        {
            Console.WriteLine(start);

            start++;

            if (start <= end) PrintSequence(start, end);
        }

        static long SumSequence(int start, int end, long sum)
        {
            sum = sum + start;
            
            start++;

            if (start <= end) sum = SumSequence(start, end, sum);

            return sum;
        }
    }
}
