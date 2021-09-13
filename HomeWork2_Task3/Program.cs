using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task3
{
    /* Щукин Андрей
     * 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            bool isRightInput;
            int currentNumber;            

            Console.WriteLine("Введите последовательность чисел через ENTER, 0 - последнее число");
            do
            {
                isRightInput = int.TryParse(Console.ReadLine(), out currentNumber);

                if (isRightInput && currentNumber > 0 && (currentNumber % 2 != 0))
                {
                    summ += currentNumber;
                }
            }
            while (currentNumber != 0 || !isRightInput);

            Console.WriteLine("Результат:");
            
            Console.WriteLine($"Сумма: {summ}");

            Console.ReadLine();
        }
    }
}
