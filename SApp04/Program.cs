using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp04
{
    class Program
    {

        static void f(int n)
        {
            Console.WriteLine(n);
            if (n >= 3)
            {
                f(n - 1);
                f(n - 2);
                f(n - 2);
            }
        }


        static void Main(string[] args)
        {
            f(4);
            Console.ReadLine();

            Print(1, 10);

            Console.ReadLine();
        }

        /// <summary>
        /// a < b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Print(int a, int b)
        {
            Console.WriteLine(a);
            Print(a + 1, b);
        }
    }
}
