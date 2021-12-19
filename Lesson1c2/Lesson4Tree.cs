using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1c2
{
    internal class Lesson4Tree : ILesson2
    {
        public string Name => "tree";

        public string Description => "4.1 двоичное дерево";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            Tree(10);


            var hashSet = new HashSet<User>();

            var user = new User() { FirstName = "Barbara", SecondName = "Santa" };

            hashSet.Add(user);

            var searchUsser = new User() { FirstName = "Barbara", SecondName = "Santa" };

            Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUsser)}");

        }

        public class User
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }

            public override bool Equals(object obj)
            {
                var user = obj as User;

                if (user == null)
                    return false;

                return FirstName == user.FirstName && SecondName == user.SecondName;
            }

            public override int GetHashCode()
            {
                int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;
                int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
                return firtsNameHashCode ^ secondNameHashCode;
            }
        }

        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }
        }

        // Построение идеально сбалансированного дерева с n узлами
        // со случайными значениями
        public static Node<int> Tree(int n)
        {
            Node<int> newNode = null;
            if (n == 0)
                return null;
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new Node<int>();
                newNode.Data = new Random().Next();
                newNode.Left = Tree(nl);
                newNode.Right = Tree(nr);
            }
            Console.WriteLine(newNode.Data);
            return newNode;
        }

    }
}
