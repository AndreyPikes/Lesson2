using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            int counter = 0;

            do
            {
                Console.Write("Введите число от 0 до 100: ");
                number = int.Parse(Console.ReadLine());
                counter++; // counter = counter + 1;
            }
            while (number >= 0 && number <= 100);

            Console.WriteLine($"Вы совершили {counter} попыток ввода.");
            Console.WriteLine();

            counter = 0;

            while(counter < 10)
            {
                Console.Write($"{counter}   ");
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();

            // for (инициализация; условия; итерация)
            // {
            // }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}   ");
            }

            counter = 0;

            while (true)
            {
                counter++;
                if (counter > 10)
                {
                    break;
                }
            }

            counter = 0;

            for (; ; )
            {
                counter++;
                if (counter > 10)
                {
                    break;
                }
            }

            int a = 12;
            char c = 'H';
            string str = "Hello!";

            Console.WriteLine();

            counter = 0;
            foreach(char e in str)
            {
                Console.WriteLine(e + " - " + counter );
                counter++;

            }



            Console.ReadLine();


        }
    }
}
