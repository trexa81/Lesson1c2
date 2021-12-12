using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class Lesson1PrimeNumbers : ILesson2
    {
        public string Name => "prime";

        public string Description => "1.1 Простые числа";

        public void Demo()
        {
            Console.WriteLine("для проверки простлое ли число введите его: ");
            int n = int.Parse(Console.ReadLine());
            //int n = 6586;
            Console.WriteLine($"Простое? {Number(n)}"); ;
        }

        /// <summary>
        /// Простое ли число.
        /// </summary>
        /// <returns></returns>
        private bool Number(int number)
        {
            int d = 0;
            if (number % 2 == 0)
            {
                Console.WriteLine($"число: {number} не простое");
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    d++;
                }
            }
            if (d == 0)
            {
                Console.WriteLine($"число: {number} простое");
                return true;
            }
            Console.WriteLine($"число: {number} не простое");
            return false;
        }
    }
}
