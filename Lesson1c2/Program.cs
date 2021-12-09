using System;

namespace Lesson1c2  // Виктор Маликов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Console.ReadLine();
            Console.WriteLine($"Output: {Reverse(n)}");
        }
        public static long Reverse(long n)
        //В данном случае ввод — это просто аргумент функции. Просто входной параметр.
        {
            long newN = 0;
            while (n > 0)
            {
                newN = newN * 10 + n % 10;
                n /= 10;
            }
            return newN;
        }
    } 
}
