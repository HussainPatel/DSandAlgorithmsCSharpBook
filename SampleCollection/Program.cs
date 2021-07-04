using System;
using System.Collections;
using System.Diagnostics;

namespace SampleCollection
{

    #region "My Collection Class"
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //        MyCollectionClass names = new MyCollectionClass();

    //        names.Add("Tim");
    //        names.Add("Tom");
    //        names.Add("Smith");

    //        foreach (object item in names)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }

    //        Console.WriteLine($"Number of names {names.Count()}");
    //        names.Remove("Tom");

    //        Console.WriteLine($"number of names after remove {names.Count()}");

    //        names.Clear();
    //        Console.WriteLine($"number of names {names.Count()}");
    //        Console.Read();
    //    }
    //}   

    //public class MyCollectionClass : CollectionBase
    //{

    //    public void Add(object item)
    //    {
    //        InnerList.Add(item);
    //    }
    //    public void Remove(object item)
    //    {
    //        InnerList.Remove(item);
    //    }

    //    public int Count()
    //    {
    //        return InnerList.Count;
    //    }

    //    public void Clear()
    //    {
    //        InnerList.Clear();
    //    }
    //}

    #endregion

    #region "My Swap"
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");

    //        int num1 = 2;
    //        int num2 = 3;

    //        Console.WriteLine($"{num1} and {num2}");

    //        MySwap<int>.Swap(ref num1, ref num2);

    //        Console.WriteLine($"{num1} and {num2}");

    //        string s1 = "Hello";
    //        string s2 = "World";

    //        Console.WriteLine($"{s1} and {s2}");

    //        MySwap<string>.Swap(ref s1, ref s2);

    //        Console.WriteLine($"{s1} and {s2}");


    //        Console.Read();
    //    }
    //}

    //public static class MySwap<T>
    //{
    //    public static void Swap(ref T s1, ref T s2)
    //    {
    //        var temp = s1;
    //        s1 = s2;
    //        s2 = temp;
    //    }
    //}

    #endregion


    #region "Generic Node Class"
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");

    //        Node<string> node1 = new Node<string>("Matt",null);
    //        Node<string> node2 = new Node<string>( "Accenture", node1);

    //        Console.Read();
    //    }
    //}

    //public class Node<T>
    //{
    //    T data;
    //    Node<T> link;
    //    public Node(T data,Node<T> link )
    //    {
    //        this.data = data;
    //        this.link = link;
    //    }
    //}

    #endregion

    #region "Timing Class"
    public class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;

        public Timing()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public void StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public TimeSpan Result()
        {
            return duration;
        }
    }
    #endregion



    #region "Timing Class Test"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[100000];            

            BuildArray(nums);            

            Timing tObj = new Timing();
            
            tObj.StartTime();

            DisplayNums(nums);

            tObj.StopTime();                      

            Console.WriteLine($"The total duration is : {tObj.Result()} ");

            Console.Read();
        }

        public static void BuildArray(int[] nums)
        {
            for (int i = 0; i <= 99999; i++)
            {
                nums[i] = i;
            }
        }

        public static void DisplayNums(int[] nums)
        {
            for (int i = 0; i <= nums.GetUpperBound(0); i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }


    #endregion
}


