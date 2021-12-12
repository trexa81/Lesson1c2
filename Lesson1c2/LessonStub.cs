using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class LessonStub : ILesson2
    {
        public string Name => "stab";

        public string Description => "0.Пустое задание";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Пустой");

        }
    }
}
