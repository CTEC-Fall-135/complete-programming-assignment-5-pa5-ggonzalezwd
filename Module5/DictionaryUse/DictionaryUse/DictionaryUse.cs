// Author: Greg Gonzalez
// Date: 11/03/2025
// CTEC 135

using System;
using System.Collections.Generic;

namespace DictionaryUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3: Dictionary");
            Console.WriteLine("Author: Greg Gonzalez\n");

            // Use initialization syntax to create a dictionary with three entries
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            // Use the add method to add (99, "ninety-nine")
            dict.Add(99, "ninety-nine");

            Console.WriteLine("Dictionary Contents (using KeyValuePair)");
            // Demonstrate use of the enumerator using KeyValuePair<>
            foreach (KeyValuePair<int, string> entry in dict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Dictionary Contents (using var)");
            // Demonstrate use of the enumerator using var (implicit type)
            foreach (var entry in dict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine();

            // Reassign the value of 99 to "99" using indexing notation
            dict[99] = "99";

            // Print the value of 99 using indexing notation
            Console.WriteLine($"Value of key 99: {dict[99]}");
            Console.WriteLine();

            // Remove the 2 item
            dict.Remove(2);

            Console.WriteLine("Updated Dictionary (after removing key 2)");
            // Print the updated dictionary
            foreach (var entry in dict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}