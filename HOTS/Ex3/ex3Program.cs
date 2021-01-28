using System;
using static System.Console;
/*
 * 
 * Write a C# program named ex3 that prompts the user for a name, street address, city, state, zip
 * code, and quantity of t-shirts ordered at $14.99 each. In an attractive format(similar to the one
 * below), display all the inpiut data as well as the following:
 * 
 * 
 *      -Total Price: defined as number ordered times price each
 *      -Sales tax: defined as 8% of the total price
 *      -Amount Due: defined as amount due before tax, plus tax
 *      
 */

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            String StreetAddress;
            String City;
            String State;
            String Zip;
            String tshirts;
            double noshirts = 0.0;
            double Total = 0.0;
            double SalesTax = 0.08;
            double amountdue = 0.0;

            Write("Enter your name: ");
            Name = Console.ReadLine();

            Write("Street Address: ");
            StreetAddress = Console.ReadLine();

            Write("City: ");
            City = Console.ReadLine();

            Write("State: ");
            State = Console.ReadLine();

            Write("Zip: ");
            Zip = Console.ReadLine();

            Write("How many T-Shirts did you want to order? ");
            noshirts = Convert.ToInt32(ReadLine());




            WriteLine("\n\n");
            Write("Receipt for: \n");
            Write(Name + "\n");
            Write(StreetAddress + "\n");
            Write(City + ", " + State + " " + Zip + "\n");
            
           

            WriteLine("\n");
            Write(noshirts  +  " tshirts ordered @ $14.99 each");
            tshirts = Console.ReadLine();
            

            WriteLine("\n");
            Total = (noshirts * 14.99);
            SalesTax = (Total * 0.08);
            amountdue = (Total + SalesTax);
            


            WriteLine("\n");
            Write("Total:   $" + Math.Round(Total, 2) + "\n");
            Write("Tax:   $" + Math.Round(SalesTax, 2) + "\n");
            Write("-------------" + "\n");
            Write("Amount Due:    $" + Math.Round(amountdue, 2) + "\n");



            


            


            



            




            
            

            





        }
    }
}