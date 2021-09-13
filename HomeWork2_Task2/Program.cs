using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task2
{
    /* Щукин Андрей
     * 2. Написать метод подсчета количества цифр числа.*/
    class Program
    {
        static void Main(string[] args)
        {
            long myNum = 43543658400;

            long newNum = myNum;

            int counter = 0;

            do
            {
                long reminder = newNum % 10;
                newNum = newNum / 10;
                
                Console.WriteLine(reminder);

                counter++;
            }
            while (newNum > 0);

            Console.WriteLine($"Число цифр числа = {counter}");

            Console.ReadKey();
        }
    }
}
