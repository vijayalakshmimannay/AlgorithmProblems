﻿// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithmProblems
{
    class program
    {
        static void Main(String[] args)
        {

            Mergesorting ob = new Mergesorting();
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            ob.printArray(arr);
        }

    }

}



