using System;

namespace Lesson1c2  // Виктор Маликов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Number(int.Parse(Console.ReadLine()));
           // int n = int.Parse(Console.ReadLine());

        }

        static bool Number(int number)
        {
            Console.WriteLine("для проверки простлое ли число введите его: ");
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
