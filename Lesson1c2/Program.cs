using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace Lesson1c2  // Виктор Маликов DZ№3.1
{
    internal class Program
    {
        private static List<ILesson2> _lessons = new List<ILesson2>()
        {
            new LessonStub (),
            new LessonTEST(),
            new Lesson1PrimeNumbers(),
            new FibonachiNumbers(),
            new FibonachiNumbersRecursion(),
            new DoublyLinkedList()
        };

        static void Main()
        {
            Console.WriteLine("Список заданий:");
            foreach (ILesson2 lesson in _lessons)
            {
                Console.WriteLine($"Код:{lesson.Name} ({lesson.Description})");
            }
            Console.WriteLine("длязавершения задания введите: end");
            Console.Write("для запуска задания введите его код: ");
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput != "end")
                {
                    List<T>(userInput);
                }
                break;
            }
            Console.WriteLine("*********************************");
        }

        /// <summary>
        /// выбор задания из списка
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userInput"></param>
        private static void List<T>(string userInput)
        {
            Console.Clear();
            foreach (ILesson2 myLesson in _lessons)
            {
                if (myLesson.Name == userInput)
                {
                    myLesson.Demo();
                }
            }
            Main();
        }
    } 
}
