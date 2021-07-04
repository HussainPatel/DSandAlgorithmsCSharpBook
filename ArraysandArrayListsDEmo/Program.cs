using System;

namespace ArraysandArrayListsDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;  // declare array variable

            numbers = new int[5]; // initiate the array and provide the size of the array;

            //you can combine these two sentences in to one line.
            int[] numbers1 = new int[5];

            // you can also declare, initialize and assign data to array
            // when you declare array using this technique, you dont have to specify the size / number of elements 
            int[] numbers2 = new int[] {1,2,3,4,5};  // The list of numbers, called the initialization list, is delimited with curly braces, and each element is delimited with a comma


            numbers2[4] = 100;
            numbers2.SetValue(1000, 4);

            var myNumber = numbers2[4];
            var myNumber1 = numbers2.GetValue(1);
            Console.WriteLine($"{myNumber}   ----  {myNumber1}");

            for (int i = 0; i <= numbers2.GetUpperBound(0); i++)
            {
                Console.WriteLine($"array number2[{i}] is {numbers2[i]}");
            }
         }
    }
}
