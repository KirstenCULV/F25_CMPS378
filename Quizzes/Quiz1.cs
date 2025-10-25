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
            char drink, packageCode = ' ';
            double taxRate = 9.5D;
            double itemPrice, comboNum, perItem, subtotal, dessertDifference, taxAmount, total = 0D;

            // menu display
            Console.WriteLine("********Welcome to Tacos La Villa POS System******** \n");
            Console.WriteLine("Menu:");
            Console.WriteLine("A - 3 Tacos Combo - $7.00      / $9.00 with drink");
            Console.WriteLine("B - Burrito Meal - $8.50       / $10.50 with drink");
            Console.WriteLine("C - Quesadilla Special - $6.00 / $8.00 with drink");
            Console.WriteLine("D - Loaded Nachos - $5.75      / $7.75 with drink \n");

            // user input
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your package code: ");
            packageCode = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Would you like to add a drink?(Y/N): ");
            drink = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("How many combos would you like?: \n");
            comboNum = Convert.ToDouble(Console.ReadLine());

            // process input
            if (drink == 'Y' || drink == 'y')
            {
				perItem = 2.00D;
                drinkIncluded = "Yes";
            }

            else
            {
				itemPrice = 0.00D;
				perItem = 0.00D; 
				drinkIncluded = "No";
            }

            if (packageCode == 'A' || packageCode == 'a')
            {
                comboOrdered = "3 Tacos Combo";
                perItem = (perItem + 7.00D);
                itemPrice = (perItem + 0.00D);
            }

            else if (packageCode == 'B' || packageCode == 'b')
            {
                comboOrdered = "Burrito Meal";
                perItem = (perItem + 8.50D);
                itemPrice = (perItem + 0.00D);
            }

            else if (packageCode == 'C' || packageCode == 'c')
            {
                comboOrdered = "Quesadilla Special";
                perItem = (perItem + 6.00D);
                itemPrice = (perItem + 0.00D);
            }

            else if (packageCode == 'D' || packageCode == 'd')
            {
                comboOrdered = "Loaded Nachos";
                perItem = (perItem + 5.75D);
                itemPrice = (perItem + 0.00D);
            }
			
			else
			{
				comboOrdered = "Invalid Selection";
				perItem = 0.00D;
				itemPrice = 0.00D;
			}

            subtotal = (itemPrice * comboNum);
			Math.Round(subtotal, 3);
			
            taxAmount = ((subtotal * taxRate) / 100D);
			Math.Round(taxAmount, 2);
			
            total = (taxAmount + subtotal);
			Math.Round(total, 2);

            if (subtotal > 20.00D)
            {
                freeDessert = "Congratulaions! You get a free dessert!";
            }
            
            else
            {
                dessertDifference = (20.00D - subtotal);
                freeDessert = "Only $" + dessertDifference + " more to earn a free dessert!";
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
