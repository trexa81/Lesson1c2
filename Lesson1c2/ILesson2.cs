using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2 //список
{
    /// <summary>
    /// Общий интерфейс урока.
    /// </summary>
    internal interface ILesson2
    {
        /// <summary>
        /// Код урока.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Вывод тестовых данных.
        /// </summary>
        void Demo ();

    }
}
