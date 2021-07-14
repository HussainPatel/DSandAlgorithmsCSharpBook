using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Initial Size: {0} ", linkedList.Length());

            Console.WriteLine("Add elements at first to linked List");
            linkedList.AddFirst(4);
            linkedList.AddFirst(2);
            linkedList.AddFirst(0);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());

            Console.WriteLine("Add elements at last to Linked list");
            linkedList.AddLast(6);
            linkedList.AddLast(8);
            linkedList.AddLast(10);
            linkedList.AddLast(12);
            linkedList.AddLast(16);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Remove Elements from First");
            var element = linkedList.RemoveFirst();
            Console.WriteLine("Removed first element {0}", element);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Remove Elements from last");
            var element1 = linkedList.RemoveLast();
            Console.WriteLine("Removed last element {0}", element1);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Remove Elements at position 4");
            var element2 = linkedList.RemoveAtPosition(4);
            Console.WriteLine("Removed element {0}", element2);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Add Element 16 at position 6");
            linkedList.AddAtPostion(16, 6);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());

            Console.WriteLine("Add Element 8 at position 4");
            linkedList.AddAtPostion(8, 4);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Add Element 0 at start");
            linkedList.AddFirst(0);

            linkedList.Display();
            Console.WriteLine("Size: {0}", linkedList.Length());


            Console.WriteLine("Find Elements");
            var result = linkedList.FindElement(1);
            if (result != null)
                Console.WriteLine($"Element Found: {result.Element}");
            else
                Console.WriteLine("Element not found");

            Console.WriteLine("Find Elements");
            var result1 = linkedList.FindElement(16);
            if (result1 != null)
                Console.WriteLine($"Element Found: {result1.Element}");
            else
                Console.WriteLine("Element not found");

            Console.Read();
        }
    }
}
