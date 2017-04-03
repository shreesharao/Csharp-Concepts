using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class LinkedListEx
    {
        LinkedList<int> objLinkedList = new LinkedList<int>();

        public void Entry()
        {
            LinkedListNode<int> objNode = new LinkedListNode<int>(4);
            objLinkedList.AddFirst(1);
            objLinkedList.AddFirst(2);

            objLinkedList.AddLast(3);

            objLinkedList.AddLast(objNode);
            objLinkedList.AddBefore(objNode, 5);
            foreach (var item in objLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
