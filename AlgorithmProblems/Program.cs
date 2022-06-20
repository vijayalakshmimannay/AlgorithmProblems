// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithmProblems
{
    class program
    {

        public static void Main(String[] args)
        {
            String[] input = { "vijaya", "lakshmi", "harsha", "aarna" };
            String find = "lakshmi";
            AlgorithmProblems.BinarySearch example = new AlgorithmProblems.BinarySearch();
            int result = example.binarySearch(input, find);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }

    }



}