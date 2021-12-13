using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class NodeList : ILinkedList
    {
        private Node head;
        private Node tail;

        /// <summary>
        /// длина списка
        /// </summary>
        public int Length { get; private set; }

        public void AddNode(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.PrevNode = tail;
                tail.NextNode = newNode;
            }
            tail = newNode;
            Length++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException(); //заглушка
        }

        public int GetCount()
        {
            return Length;
            //throw new NotImplementedException(); //заглушка
        }

        public void RemoveNode(int index)
        { 
            throw new NotImplementedException(); //заглушка
        }

        public void RemoveNode(Node node)
        {
            if (node.NextNode == null)
                return;

            var nextItem = node.NextNode.NextNode;
            node.NextNode = nextItem;

        }

        public void PrintList()
        {
            String list = " ";
            Node current = head;
            while (current != null)
            {
                list += $"{current.Value}, ";
                current = current.NextNode;
            }
            Console.WriteLine(list);
            Console.WriteLine(Length);
        }

    }
}
