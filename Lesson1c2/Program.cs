using System;
using System.Collections.Generic;

namespace Lesson1c2  // Виктор Маликов DZ№2
{
    internal class Program
    {
        static List<ILesson2> _lessons = new List<ILesson2>()
        {
            new LessonStub (),
            new Lesson1PrimeNumbers(),
            new FibonachiNumbers(),
            new FibonachiNumbersRecursion()
        };
        static void Main(string[] args)
        {

            Console.WriteLine("для запуска задания введите его код.");
            Console.WriteLine("Список заданий:");
            foreach (ILesson2 lesson in _lessons)
            {
                Console.WriteLine($"Код:{lesson.Name} ({lesson.Description})");

            }
            /*********************************************/

            //Console.WriteLine("для проверки простлое ли число введите его: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Number(n1);
            // /*********************************************/
            

            //int k = 10;
            //for (int i = 0; i <= k; i++)
            //{
            //    Console.WriteLine(Fibonachi3(i));
            //}
            //Console.WriteLine($"вывод последовательности  {k} чисел фибоначи");
            //Fibonachi(k);
            Console.WriteLine("*********************************");
        }

        //  Задание №2 сложность функции = O(N^3)
        /*****************************************************/

        static bool Number(int number)
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
        /*****************************************************/

        static int Fibonachi3(int n) // рекурсия
        {

            if (n == 0 || n == 1) return n;
            return Fibonachi3(n - 1) + Fibonachi3(n - 2);

        }
        /*****************************************************/

        static int Fibonachi(int n, int p1 = 0, int p2 = 1) //без рекурсии
        {
            if (n <= 1) return p1;
            int p;
            for (int j = 0; j <= n; j++)
            {
                p = p1;
                p1 = p2;
                p2 += p;
                Console.WriteLine(p);
            }
            return p2;
        }
    } 
}
