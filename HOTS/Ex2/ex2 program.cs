using System;
using static System.Console;
/*
 * 
 * Write a C# program named ex2 that asks for any three real (double) numbers and prints
 * the average value of those numbers. Credit for the correct result will not be given if the average 
 * isn't correct for any 3 given numbers.
 * 
 * 
 */

namespace Ex2
{
    class Program
        //const MINVALUE = 0;
        //const MAXVALUE = 100;
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int numberTot = 0;
            double avg = 0;

            Write("\n\n\t\tEnter Number 1: ");
            number1 = Convert.ToInt32(ReadLine());

            Write("\n\t\tEnter Number 2: ");
            number2 = Convert.ToInt32(ReadLine());

            Write("\n\t\tEnter Number 3: ");
            number3 = Convert.ToInt32(ReadLine());

            numberTot = number1 + number2 + number3;

            avg = numberTot / 3.0;

            WriteLine("\n\n\t\tEnter Number 1: " + number1.ToString());
            WriteLine("\n\t\tEnter Number 2: " + number2.ToString());
            WriteLine("\n\t\tEnter Number 3: " + number3.ToString());
            WriteLine("\n\t\tAverage Number: " + avg.ToString());






            
        }
    }
}
