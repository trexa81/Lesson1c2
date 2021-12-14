using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class FibonachiNumbersRecursion : ILesson2
    {
        public string Name => "fib2";

        public string Description => "1.3.2 Фибоначи рекурсией";

        public void Demo()
        {
            int k = 10;
            Console.WriteLine($"вывод последовательности  {k} чисел фибоначи");
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(Fibonachi3(i));
            }
        }

        /// <summary>
        /// Фибоначи рекурсией.
        /// </summary>
        /// <returns></returns>
        static int Fibonachi3(int n) // рекурсия
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi3(n - 1) + Fibonachi3(n - 2);
        }
    }
}
