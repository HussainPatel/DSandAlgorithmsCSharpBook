using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            this.Data = null;
            this.Next = null;
        }

        public Node(object _data)
        {
            Data = _data;
            Next = null;
        }     
    }
}
