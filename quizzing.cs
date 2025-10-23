// Street Food POS System
// This system will allow customers to order from a menu, choose
// whether they want a drink, input quantity, and receive a detailed receipt.

using System;
using System.Globalization;

namespace Quiz1
{
    class Program
    {
        static void Main(String[] args)
        {


            // menu display
            Console.WriteLine("*****Welcome to Tacos La Villa POS System***** \n");
            Console.WriteLine("Menu:");
            Console.WriteLine("A - 3 Tacos Combo - $7.00 / $9.00 with drink");
            Console.WriteLine("B - Burrito Meal - $8.50 / $10.50 with drink");
            Console.WriteLine("C - Quesadilla Special - $6.00 / $8.00 with drink");
            Console.WriteLine("D - Loaded Nachos - $5.75 / $7.75 with drink");

            // user input
            Console.WriteLine("Please enter your name: ");
            Console.WriteLine("Please enter your package code: ");
            Console.WriteLine("Would you like to add a drink?(Y/N): ");
            Console.WriteLine("How many combos would you like?: ");

            // process input


            // output
            Console.WriteLine("=======Tacos La Villa Receipt=======");
            Console.WriteLine("Customer Name: ");
            Console.WriteLine("Combo Ordered: ");
            Console.WriteLine("Drink Included: ");
            Console.WriteLine("Quantity: ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Price Per Item: ");
            Console.WriteLine("Subtotal: ");
            Console.WriteLine("Tax(9.5%): ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Total: ");
            Console.WriteLine("Free Dessert?");
            Console.WriteLine("===================");
            Console.WriteLine("Thank you for supporting Tacos La Villa!");

        }
    }
}


