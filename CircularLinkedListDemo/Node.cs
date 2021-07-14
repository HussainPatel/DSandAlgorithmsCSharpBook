using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListDemo
{
   public class Node
    {
        public object Element { get; set; }

        public Node Next { get; set; }

        public Node()
        {
            Element = null;
            Next = null;
        }

        public Node(object element, Node next)
        {
            Element = element;
            Next = next;
        }
    }
}
