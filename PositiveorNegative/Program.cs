using System;

namespace PositiveorNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            Console.WriteLine("Please enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());

            if(number1 >= 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");

            }
        }

    }
}