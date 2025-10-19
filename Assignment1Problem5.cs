// CMPS 378: C# Programming Fall 2025
// Problem 5: AT&T Fiber Internet Bill Calculator (Strict Format)
// Author: Kaya Catano
// Date: 2025-10-18

using System;
using System.Globalization;

namespace Assignment1Problem5Strict
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new CultureInfo("en-US");

            Console.WriteLine("****** Welcome to AT&T Fiber Internet Billing System ******");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Select internet plan speed (300 / 500 / 1000 / 2000 / 5000 Mbps): ");
            string planInput = Console.ReadLine();
            int planSpeed;
            if (!int.TryParse(planInput, out planSpeed))
            {
                Console.WriteLine("Invalid plan speed.");
                return;
            }

            Console.Write("Would you like to add a static IP? (Y/N): ");
            string staticIpInput = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
            bool addStaticIp = staticIpInput == "Y";

            // Base pricing per speed tier
            double basePrice;
            switch (planSpeed)
            {
                case 300: basePrice = 55.00; break;
                case 500: basePrice = 65.00; break;
                case 1000: basePrice = 80.00; break;
                case 2000: basePrice = 110.00; break;
                case 5000: basePrice = 180.00; break;
                default:
                    Console.WriteLine("Invalid plan speed.");
                    return;
            }

            double staticIpCost = addStaticIp ? 15.00 : 0.00;
            double subtotal = basePrice + staticIpCost;
            double tax = Math.Round(subtotal * 0.095, 2, MidpointRounding.AwayFromZero);
            double total = subtotal + tax;

            Console.WriteLine("=========== AT&T FIBER BILLING SUMMARY ===========");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Plan Speed: {planSpeed} Mbps");
            Console.WriteLine($"Base Price: {basePrice.ToString("C2", culture)}");
            if (addStaticIp)
                Console.WriteLine($"Static IP: {staticIpCost.ToString("C2", culture)}");
            else
                Console.WriteLine("Static IP: $0.00");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Subtotal: {subtotal.ToString("C2", culture)}");
            Console.WriteLine($"Tax (9.5%): {tax.ToString("C2", culture)}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Total Due: {total.ToString("C2", culture)}");
            Console.WriteLine("==================================================");
            Console.WriteLine("Thank you for choosing AT&T Fiber!");
        }
    }
}
