using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Counter { get; set; }

        public void AddFirst(int number) 
        { 
            Node node = new Node(number);
            Counter++;
            if (Head == null) // Head == null or Tail == null it doesn't matter which one
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }

        public void AddLast(int number)
        {
            Node node = new Node(number);
            Counter++;
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public Node RemoveFirst()
        {
            Node nodeToRemove = Head;
            Head = Head.Next;
            Head.Previous = null;
            nodeToRemove.Next = null;
            Counter--;
            return nodeToRemove;
        }
        public Node RemoveLast()
        {
            Node nodeToRemove = Tail;
            Tail = Tail.Previous;
            Tail.Next = null;
            nodeToRemove.Previous = null;
            Counter--;
            return nodeToRemove;
        }
        public void CustomForEach(Action<int> callback)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                callback(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public int[] CustomToArray()
        {
            int[] array = new int[Counter];
            int index = 0;
            Node node = Head;

            while (node != null)
            {
                array[index] = node.Value;
                index++;
                node = node.Next;
            }

            // The While loop can be replaced by calling the CustomForEach method:
            /*
             * CustomForEach(x =>
             * {
             *    array[index++] = x;
             * });
             */
            return array;
        }
    }
}
