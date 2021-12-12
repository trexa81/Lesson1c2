using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class FibonachiNumbers : ILesson2
    {
        public string Name => "fib";

        public string Description => "1.3.1 Фибоначи без рекурсии";

        public void Demo()
        {
            int k = 10;
            Console.WriteLine($"вывод последовательности  {k} чисел фибоначи");
            Fibonachi(k);
        }

        /// <summary>
        /// Фибоначи без рекурсии.
        /// </summary>
        /// <returns></returns>
        private static int Fibonachi(int n, int p1 = 0, int p2 = 1) //без рекурсии
        {
            if (n <= 1) return p1;
            int p;
            for (int j = 0; j <= n; j++)
            {
                p = p1;
                p1 = p2;
                p2 += p;
                Console.WriteLine(p); //вывод числа
            }
            return p2;
        }
    }
}
