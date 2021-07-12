using System;

namespace LeetCodeQuestions
{
    public static class ReverseInteger
    {

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    Console.WriteLine($"Reverse of 1234 is :{ReverseInt(1234)}");
        //    Console.WriteLine($"Reverse of -1234 is :{ReverseInt(-1234)}");
        //    Console.WriteLine($"Reverse of 1534236469 is :{ReverseInt(1534236469)}");

        //    Console.Read();
        //}

        public static int ReverseInt(int number)
        {
            int reverse = 0;

            bool isNegative = number < 0 ? true : false;

            if (isNegative)
                number = number * -1;

            while (number >= 1)
            {
                var remainder = number % 10;
                try
                {
                    reverse = checked(reverse * 10) + remainder; // using checked for int - Arthimetic over flow.
                }
                catch (Exception e)
                {
                    //Console.Write(e.Message);
                    //reverse = 0;
                }
                number = number / 10;
            }

            reverse = (isNegative) ? reverse * -1 : reverse;

            return reverse;

        }
    }

  


}
