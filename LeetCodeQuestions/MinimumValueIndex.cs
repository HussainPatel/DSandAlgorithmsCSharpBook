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

            //int[] arr = new int[] { 15, 20, 25, 82, 87, 110 };

            int[] arr = new int[] { 0, 2, 1, 5, 3, 4 };

            //  int number = 87;
            // Console.WriteLine($"the value {number} was found at index {SearchMinimumValueIndex(arr, number)}");

            var result = BuildArray(arr);

            Console.Read();
        }



        public static int[] BuildArray(int[] nums)
        {
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Length+1);
            Console.WriteLine(nums.Length -1);

            int[] ans = new int[nums.Length];

            for (int i = 0; i <nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
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
