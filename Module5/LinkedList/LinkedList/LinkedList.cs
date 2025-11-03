// Author: Greg Gonzalez
// Date: 11/03/2025
// CTEC 135

using System;
using System.Collections.Generic;

namespace LinkedListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4: Linked List");
            Console.WriteLine("Author: Greg Gonzalez\n");

            // Create a string array with first words of a nursery rhyme
            string[] rhymeWords = { "Twinkle", "twinkle", "little", "star", "how", "I", "wonder", "what", "you", "are" };

            // Use the string array as argument to create a linked list
            LinkedList<string> rhyme = new LinkedList<string>(rhymeWords);

            Console.WriteLine("Print using foreach (enumerator)");
            // Print the rhyme on a single line using the enumerator
            foreach (string word in rhyme)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Traditional linked list traversal (walking the list)");
            // Create a node variable and walk the list
            LinkedListNode<string> node = rhyme.First;
            while (node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }
            Console.WriteLine("\n");

            Console.WriteLine("After removing 'little'");
            // Remove a word from the middle of the list
            rhyme.Remove("little");
            foreach (string word in rhyme)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("After adding 'little' back");
            // Add the word back in
            LinkedListNode<string> twinkleNode = rhyme.Find("twinkle");
            if (twinkleNode != null)
            {
                rhyme.AddAfter(twinkleNode, "little");
            }
            foreach (string word in rhyme)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}