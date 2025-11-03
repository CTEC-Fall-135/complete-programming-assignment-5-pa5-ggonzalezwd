// Author: Greg Gonzalez
// Date: 11/03/2025
// CTEC 135

using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2: Stacks and Queues");
            Console.WriteLine("Author: Greg Gonzalez\n");

            #region Stack
            Console.WriteLine("Stack (LIFO - Last In, First Out)");

            // Declare and initialize a stack with the numbers 1 - 5 using initialization syntax
            int[] initArray = { 1, 2, 3, 4, 5 };
            Stack<int> stack = new Stack<int>(initArray);

            // Demonstrate use of the enumerator to print out the members in the stack
            Console.WriteLine("Stack contents (using foreach):");
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Print a peek at the top member in the stack
            Console.WriteLine($"Peek at top of stack: {stack.Peek()}");
            Console.WriteLine();

            // Write a loop that pops the elements off of the stack and prints each
            Console.WriteLine("Popping elements from stack:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine();
            #endregion

            #region Queue
            Console.WriteLine("Queue (FIFO - First In, First Out)");

            // Declare a queue
            Queue<int> queue = new Queue<int>();

            // Initialize the queue with the numbers 1-5 using a for loop
            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }

            // Demonstrate use of the enumerator to print out the members in the queue
            Console.WriteLine("Queue contents (using foreach):");
            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Print a peek at the front member in the queue
            Console.WriteLine($"Peek at front of queue: {queue.Peek()}");
            Console.WriteLine();

            // Write a loop that dequeues the elements from the queue and prints each
            Console.WriteLine("Dequeuing elements from queue:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            #endregion

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}