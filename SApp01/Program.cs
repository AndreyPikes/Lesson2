using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            if (number < 0) // < > == != >= <=
            {
                Console.WriteLine($"{number} больше нуля.");
            }
            else
            {
                Console.WriteLine($"{number} меньше или равен нулю.");
            }


            double imt = 18.5;

            if ( imt <= 19.5)
            {
                Console.WriteLine("Вам необходимо поправиться.");
            }
            else if (imt > 19.5 && imt < 27)
            {
                Console.WriteLine("У вас нормальный вес.");
            }
            else //if (imt >= 27)
            {
                Console.WriteLine("Вам необходимо похудеть.");
            }

            /*if(imt <= 19.5)
            {
                Console.WriteLine("Вам необходимо поправиться.");
            }
            
            if (imt > 19.5 && imt < 27)
            {
                Console.WriteLine("У вас нормальный вес.");
            }

            if (imt >= 27)
            {
                Console.WriteLine("Вам необходимо похудеть.");
            }*/

            Console.WriteLine("Введите два целых числа.");

            Console.Write("Введите первое число: ");
            int a =  int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int max;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine($"Наибольшее значение: {max}");

            // (?) if-then-else

            max = a > b ? a : b;

            Console.WriteLine("Наибольшее значение: {0}", a > b ? a : b);
            Console.WriteLine("Наибольшее значение: {0}", a > b ? a : (a == 1 ? a : b));
            Console.WriteLine("Наибольшее значение: {0}", a > b ? a : GetNumber(b));

            Console.ReadLine();

        }

        static void ProcessNumber(int i)
        {
            //....
        }
        static int GetNumber(int i)
        {
            return i * i;
        }
    }
}
