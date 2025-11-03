// Author: Greg Gonzalez
// Date: 11/03/2025
// CTEC 135

using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Arrays and Lists");
            Console.WriteLine("Author: Greg Gonzalez\n");

            #region Simple Array
            Console.WriteLine("Simple Array");

            // Create an array of int of size 5
            int[] numbers = new int[5];

            // Use a for loop to initialize it to the numbers 11 - 15
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 11 + i;
            }

            // Use a foreach loop to print out the values in the array
            Console.WriteLine("Array values:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            #endregion

            #region List<T>
            Console.WriteLine("List<int>");

            // Create a list of int
            List<int> numberList = new List<int>();

            // Use a for loop to initialize the list to the numbers 21 - 25
            for (int i = 0; i < 5; i++)
            {
                numberList.Add(21 + i);
            }

            // Use a foreach loop to print out the values in the list
            Console.WriteLine("Initial list values:");
            foreach (int num in numberList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Update the values in the list to 31 - 35 using a for loop
            for (int i = 0; i < numberList.Count; i++)
            {
                numberList[i] = 31 + i;
            }

            // Repeat the print using a for loop and indexing
            Console.WriteLine("Updated list values (using indexing):");
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
            #endregion

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}