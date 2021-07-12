using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public static class MinimumValue
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    int[] arr = new int[] { 15, 20, 25, 82, 87, 110 };

        //    int number = 81;
        //    Console.WriteLine($"the value {number} was found {SeqSearch(arr, number)}");

        //    Console.Read();
        //}


        public static int SeqSearch(int[] arr, int number)
        {
            var min = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == number)
                    min = arr[i];
                else
                    min = 0;
            }
            return min;
        }
    }
}
