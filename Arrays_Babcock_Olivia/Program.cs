using System;

namespace Arrays_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Asks the user to enter a whole number for the array size.
            Console.WriteLine("Enter a whole number for the array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            /// Asks the user to enter a whole number to add to the array.
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            /// Tells the sum of the array
            Console.WriteLine($"The sum of the array is {sum}");

            Array.Sort(numbers);

            /// Shows all numbers entered in the array.
            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
