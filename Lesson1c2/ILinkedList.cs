namespace Lesson1c2
{

    //int GetCount(); // возвращает количество элементов в списке
    //void AddNode(int value);  // добавляет новый элемент списка
    //void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
    //void RemoveNode(int index); // удаляет элемент по порядковому номеру
    //void RemoveNode(Node node); // удаляет указанный элемент
    //Node FindNode(int searchValue); // ищет элемент по его значению


    internal interface ILinkedList
    {
        /// <summary>
        /// возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        int GetCount();

        /// <summary>
        /// + новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        void AddNode(int value);

        /// <summary>
        /// + новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        void AddNodeAfter(Node node, int value);

        /// <summary>
        /// удаляет элемент по номеру
        /// </summary>
        /// <param name="index"></param>
        void RemoveNode(int index);

        /// <summary>
        /// удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        void RemoveNode(Node node);

        /// <summary>
        /// ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        Node FindNode(int searchValue);
    }
}