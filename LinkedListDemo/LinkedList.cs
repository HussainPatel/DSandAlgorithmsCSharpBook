using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        protected Node head;
        protected Node tail;

        public LinkedList()
        {
            
        }

        public bool IsEmpty() => head == null;

        public Node Find(object data)
        {
            Node current = new Node();

            if (IsEmpty())
            {
                return current;
            }

            current = head;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }

                current = current.Next;
            }         
            return current;
        }
        
    }
}
