// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithmProblems
{
    class program
    {
        static void Main(String[] args)
        {
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            AnagramSort anagram = new AnagramSort();
            //Check if words are anagram  
            if (anagram.Anagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }
            Console.ReadLine();


        }

    }

}



