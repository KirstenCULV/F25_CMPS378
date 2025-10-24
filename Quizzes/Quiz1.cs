// Street Food POS System
// This system will allow customers to order from a menu, choose
// whether they want a drink, input quantity, and receive a detailed receipt.

using System;

namespace Quiz1
{
    class Program
    {
        static void Main(String[] args)
        {
            // intialize variables
            string name, comboOrdered, drinkIncluded, freeDessert = " ";
            char packageCode, drink = ' ';
            int comboNum = 0;
            double taxRate = 9.5D;
            double itemPrice, perItem, subtotal, dessertDifference, taxAmount, total = 0D;

            // menu display
            Console.WriteLine("*****Welcome to Tacos La Villa POS System***** \n");
            Console.WriteLine("Menu:");
            Console.WriteLine("A - 3 Tacos Combo - $7.00 / $9.00 with drink");
            Console.WriteLine("B - Burrito Meal - $8.50 / $10.50 with drink");
            Console.WriteLine("C - Quesadilla Special - $6.00 / $8.00 with drink");
            Console.WriteLine("D - Loaded Nachos - $5.75 / $7.75 with drink");

            // user input
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine;
            Console.WriteLine("Please enter your package code: ");
            packageCode = Convert.ToChar(Console.ReadLine);
            Console.WriteLine("Would you like to add a drink?(Y/N): ");
            drink = Convert.ToChar(Console.ReadLine);
            Console.WriteLine("How many combos would you like?: ");
            comboNum = Convert.ToInt32(Console.ReadLine);

            // process input
            if (drink = 'Y' || 'y')
            {
                itemPrice = 2.00;
                drinkIncluded = "Yes";
            }

            else
            {
                drinkIncluded = "No";
            }

            if (comboNum = 'A' || 'a')
            {
                comboOrdered = "3 Tacos Combo";
                perItem = 7.00;
                itemPrice = (itemPrice + perItem);
            }

            if (comboNum = 'B' || 'b')
            {
                comboOrdered = "Burrito Meal";
                perItem = 8.50;
                itemPrice = (itemPrice + perItem);
            }

            if (comboNum = 'C' || 'c')
            {
                comboOrdered = "Quesadilla Special";
                perItem = 6.00;
                itemPrice = (itemPrice + perItem);
            }

            if (comboNum = 'D' || 'd')
            {
                comboOrdered = "Loaded Nachos";
                perItem = 5.75;
                itemPrice = (itemPrice + perItem);
            }

            subtotal = (itemPrice * comboNum);
            taxAmount = ((subtotal * 9.5) / 100);
            total = (taxAmount + subtotal);

            if (subtotal > 20.00)
            {
                freeDessert = "Congratulaions! You get a free dessert!";
            }
            
            else
            {
                dessertDifference = (20.00 - subtotal);
                freeDessert = "Only " + dessertDifference + " more to earn a free dessert!";
            }

            // output
            Console.WriteLine("=======Tacos La Villa Receipt=======");
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Combo Ordered: " + comboOrdered);
            Console.WriteLine("Drink Included: " + drinkIncluded);
            Console.WriteLine("Quantity: " + comboNum);
            Console.WriteLine("-------------------");
            Console.WriteLine("Price Per Item: $" + perItem);
            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Tax(9.5%): $" + taxAmount);
            Console.WriteLine("-------------------");
            Console.WriteLine("Total: $" + total);
            Console.WriteLine(freeDessert);
            Console.WriteLine("===================");
            Console.WriteLine("Thank you for supporting Tacos La Villa!");

        }
    }
}


