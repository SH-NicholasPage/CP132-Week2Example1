using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace W2E1
{
    internal class Program
    {
        public static void Main()
        {
            int myNumber;
            int myAnswer;
            Console.Write("Please enter a number: ");
            myNumber = Convert.ToInt32(Console.ReadLine());
            myAnswer = myNumber * 2;
            Console.WriteLine(myNumber + " doubled is " + myAnswer);
        }
    }
}