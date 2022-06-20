// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithmProblems
{
    class program
    {

        public static void Main(String[] args)
        {

            string[] names = { "vijaya lakshmi", "lakshmi vijaya", "harsha talluri", "talluri harsha" };
            AlgorithmProblems.InsertSort value = new AlgorithmProblems.InsertSort();
            value.InsertionSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



        }


    }



}