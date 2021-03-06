using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class Node
    {
        public object Element { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            this.Element = null;
            this.Next = null;
        }

        public Node(object _data, Node _link)
        {
            this.Element = _data;
            this.Next = _link;
        }
    }
}
