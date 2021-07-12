using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public static class MinimumValueIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] { 15, 20, 25, 82, 87, 110 };

            int number = 87;
            Console.WriteLine($"the value {number} was found at index {SearchMinimumValueIndex(arr, number)}");

            Console.Read();
        }


        static int SearchMinimumValueIndex(int[] arr, int number)
        {
            int index = 0;

            while (index < arr.Length - 1)
            {
                if (arr[index] == number)
                {
                    return index;
                }

                index = index + 1;
            }

            return -1;
        }
    }
}
