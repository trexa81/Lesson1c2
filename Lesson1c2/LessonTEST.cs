using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class LessonTEST : ILesson2
    {
        public string Name => "test";

        public string Description => "3.1 Test Stopwatch";
        /// <summary>
        /// тест
        /// </summary>
        public void Demo()
        {
            var length1 = 1000000;
            var length2 = 10000000;
            var length3 = 30000000;
            var length4 = 50000000;
            Console.WriteLine($"Point \t\t DistanceClass \t DistanceStruct");
            Console.WriteLine($"{length1} \t {DistanceClass(length1)} \t\t {DistanceStruct(length1)}");
            Console.WriteLine($"{length2} \t {DistanceClass(length2)} \t\t {DistanceStruct(length2)}");
            Console.WriteLine($"{length3} \t {DistanceClass(length3)} \t\t {DistanceStruct(length3)}");
            Console.WriteLine($"{length4} \t {DistanceClass(length4)} \t\t {DistanceStruct(length4)}");
            Console.WriteLine("Для завершения нажмите любую кнопку");
            Console.ReadKey();
        }
        public static long DistanceClass(int l)
        {
            Random random = new Random();
            var lenght = l;
            var array = new PointClass[lenght];
            for (int k = 0; k < lenght; k++)
            {
                array[k] = new PointClass() { X = random.NextDouble(), Y = random.NextDouble() };
            }

            //создаем объект
            Stopwatch stopwatch1 = new Stopwatch();
            //засекаем время начала операции
            stopwatch1.Start();
            //выполняем какую-либо операцию
            foreach (var k in array)
            {
                var j = 1;
                PointDistanceShort(array[j], array[j - 1]);
            }
            stopwatch1.Stop();
            //Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            return stopwatch1.ElapsedMilliseconds;
        }

        public static long DistanceStruct(int l)
        {
            Random random = new Random();
            var lenght = l;
            var array2 = new PointStruct[lenght];
            for (int k = 0; k < lenght; k++)
            {
                array2[k] = new PointStruct() { X = random.NextDouble(), Y = random.NextDouble() };
            }
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            foreach (var k in array2)
            {
                var j = 1;
                PointDistanceShortStruct(array2[j], array2[j - 1]);
            }
            stopwatch2.Stop();
            //Console.WriteLine(stopwatch2.ElapsedMilliseconds);
            return stopwatch2.ElapsedMilliseconds;
        }
        /********************************/

        public static double PointDistanceShort(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        public static double PointDistanceShortStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        public class PointClass
        {
            public double X;
            public double Y;
        }

        public struct PointStruct
        {
            public double X;
            public double Y;
        }

    }
}
