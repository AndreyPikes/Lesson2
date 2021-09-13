using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{



    class Program
    {

        static int GetNumber(int i)
        {
            return i * i;
        }

        static void Task1()
        {
            Console.WriteLine("Task1 ...");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 ...");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("1 - Task1");
            Console.WriteLine("2 - Task2");
            Console.WriteLine("3 - Task3");
            Console.WriteLine("0 - Завершение работы приложения");
            Console.WriteLine("=====================");

            //int taskNumber = 0;
            //do
            //{
            //    Console.Write("Введите номер задачи:");
            //    taskNumber = int.Parse(Console.ReadLine());

            //    switch (taskNumber)
            //    {
            //        case 0:
            //            Console.WriteLine("Завершение работы программы");
            //            break;
            //        case 1:
            //            Task1();
            //            break;
            //        case 2:
            //            Task2();
            //            break;
            //        case 3:
            //            Task3();
            //            break;
            //        default:
            //            Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
            //            break;
            //    }
            //}
            //while (taskNumber != 0);

            while(true)
            {
                Console.Write("Введите номер задачи:");
                 int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        Console.ReadLine();
                        return;
                        //break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }

            
        }

        static void Task3()
        {
            Console.WriteLine("Task3 ...");
        }
    }
}
