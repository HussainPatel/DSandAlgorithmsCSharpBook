using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        protected Node head;
        protected Node tail;
        protected int size;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public bool IsEmpty() => head == null;

        public int Length() => size;

        public void Display()
        {
            var current = head;

            while (current != null)
            {
                Console.Write(current.Element + " -->");
                current = current.Next;
            }

            Console.WriteLine("");
        }      

        public void AddFirst(object element)
        {
            var node = new Node(element, null);

            if (IsEmpty())
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }

            size = size + 1;
        }

        public void AddLast(object element)
        {
            var node = new Node(element, null);

            if (IsEmpty())
            {
                head = node;
            }
            else
                tail.Next = node;

            tail = node;
            size = size + 1;
        }

        public void AddAtPostion(object element, int position)
        {
            var node = new Node(element, null);

            if (IsEmpty())
            {
                head = node;
                tail = node;
            }

            var current = head;
            int p = 1;

            while (p < position - 1)
            {
                current = current.Next;
                p = p + 1;
            }

            node.Next = current.Next;
            current.Next = node;
           

            size = size + 1;
        }

        public object RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the linked list is Empty");
                return -1;
            }

            var element = head.Element;
            head = head.Next;
            size = size - 1;

            // chekc after deleting the head if the list is empty -
            // in this case we need ot point tail to empty.
            if (IsEmpty())
            {
                tail = null;
            }

            return element;
        }

        public object RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the linked list is empty");
                return -1;
            }

            var current = head;
            var position = 1;
            while (position < Length() - 1)
            {
                current = current.Next;
                position = position + 1;
            }

            tail = current;
            current = current.Next;
            var element = current.Element;
            tail.Next = null;

            size = size - 1;

            return element;
        }

        public object RemoveAtPosition(object position)
        { 
            if((int)position <= 0 || (int)position >= size - 1)
            {
                Console.WriteLine("invalid position");
                return -1;
            }

            var current = head;
            int p = 1;

            while (p < (int)position - 1)
            {
                current = current.Next;
                p = p + 1;
            }

            var element = current.Next.Element;
            current.Next = current.Next.Next;
            size = size - 1;

            return element;
        }

        public Node FindElement(object element)
        {

            if (IsEmpty())
            {
                Console.WriteLine("The linked list is emplty");
                return new Node();
            }

            var current = head;

            while (current != null)
            {
                if (current.Element.Equals(element)) // object type elements are compared using the .Equals to chekc if they are === or using cast to specific data type.
                {
                    return current;
                }
                current = current.Next;
            }
            return current;
        }
    }
}
