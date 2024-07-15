using System;

namespace ExampleNamespace
{
    public class Program
    {
        // Method to add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add two decimals
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        // Overloaded method to return a string based on a boolean parameter
        public static string Add(int a, int b, bool isDollar)
        {
            int sum = a + b;
            if (isDollar)
            {
                return sum == 1 ? $"{sum} dollar" : $"{sum} dollars";
            }
            return sum.ToString();
        }

        // Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // Testing the methods
            Console.WriteLine(Add(5, 3)); // Output: 8
            Console.WriteLine(Add(5.5m, 3.3m)); // Output: 8.8
            Console.WriteLine(Add(1, 1, true)); // Output: 2 dollars
            Console.WriteLine(Add(1, 0, true)); // Output: 1 dollar
            Console.WriteLine(Add(2, 2, false)); // Output: 4
        }
    }
}