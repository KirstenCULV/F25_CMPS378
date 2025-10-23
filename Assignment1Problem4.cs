// LADWP Utility Bill Calculator

using System;
using System.Globalization;

namespace Assignment1Problem4Strict
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new CultureInfo("en-US");

            Console.WriteLine("****** Welcome to LADWP Utility Bill Calculator ******");

            // user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter electricity usage in kWh: ");
            double kwh = double.Parse(Console.ReadLine() ?? "0", culture);

            Console.Write("Enter water usage in HCF: ");
            double hcf = double.Parse(Console.ReadLine() ?? "0", culture);

            // Electricity tiered single-rate selection (not cumulative)
            double elecRate;
            if (kwh >= 0 && kwh <= 199) elecRate = 0.13;
            else if (kwh <= 499) elecRate = 0.17;
            else if (kwh <= 999) elecRate = 0.21;
            else elecRate = 0.26;

            // Water tiered single-rate selection (not cumulative)
            double waterRate;
            if (hcf >= 0 && hcf <= 9) waterRate = 2.30;
            else if (hcf <= 24) waterRate = 3.10;
            else if (hcf <= 39) waterRate = 4.20;
            else waterRate = 5.15;

            double elecCharge = kwh * elecRate;
            double waterCharge = hcf * waterRate;
            double total = elecCharge + waterCharge;

            // output
            Console.WriteLine("=========== LADWP MONTHLY BILL ===========");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Electricity Usage: {kwh.ToString("0", culture)} kWh");
            Console.WriteLine($"Rate Applied: {elecRate.ToString("C2", culture)} per kWh");
            Console.WriteLine($"Electricity Charge: {elecCharge.ToString("C2", culture)}");
            Console.WriteLine($"Water Usage: {hcf.ToString("0", culture)} HCF");
            Console.WriteLine($"Rate Applied: {waterRate.ToString("C2", culture)} per HCF");
            Console.WriteLine($"Water Charge: {waterCharge.ToString("C2", culture)}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Amount Due: {total.ToString("C2", culture)}");
            Console.WriteLine("==========================================");
            Console.WriteLine("Thank you for using LADWP!");
        }
    }
}
