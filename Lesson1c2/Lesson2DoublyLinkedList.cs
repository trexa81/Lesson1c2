using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class DoublyLinkedList : ILesson2
    {
        public string Name => "list";

        public string Description => "2.0 Двусвязный список";

        public void Demo()
        {
            NodeList myList = new NodeList();
            myList.AddNode(56);
            myList.AddNode(862);
            myList.AddNode(123);
            myList.AddNode(342);
            myList.PrintList();
            Console.WriteLine(myList.GetCount());
        }
        
    }
}
