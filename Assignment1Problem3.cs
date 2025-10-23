// Road Trip Budget Estimator

using System;
using System.Globalization;

namespace Assignment1Problem3
{
    class Assignment1Problem3
    {
        static void Main(string[] args)
        {
            // Use invariant culture for numeric parsing to avoid locale issues
            var culture = CultureInfo.InvariantCulture;

            Console.WriteLine("****** Welcome to the Road Trip Budget Estimator ******");

            // 1) INPUTS
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many days will your trip be? ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many miles will you drive in total? ");
            double totalMiles = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your car's MPG? ");
            double mpg = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the average gas price per gallon? ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your nightly hotel cost? ");
            double hotelPerNight = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your daily food budget? ");
            double dailyFood = Convert.ToDouble(Console.ReadLine());

            // 2) CALCULATIONS
            // Guard against division by zero for MPG
            double gasNeeded = mpg != 0 ? (totalMiles / mpg) : 0.0;
            double gasCost = gasNeeded * gasPrice;

            // No hotel on the last night of the trip; ensure non-negative nights
            int hotelNights = Math.Max(days - 1, 0);
            double hotelCost = hotelPerNight * hotelNights;

            double foodCost = dailyFood * Math.Max(days, 0);

            double totalCost = gasCost + hotelCost + foodCost;

            // 3) OUTPUT SUMMARY
            Console.WriteLine();
            Console.WriteLine("=========== ROAD TRIP BUDGET SUMMARY ===========");
            Console.WriteLine($"Name:                 {name}");
            Console.WriteLine($"Trip Duration:        {days} days");
            Console.WriteLine($"Total Miles:          {totalMiles} miles");
            Console.WriteLine($"Fuel Efficiency:      {mpg} MPG");
            Console.WriteLine($"Gas Price:            {gasPrice.ToString("C2", culture)}");
            Console.WriteLine($"Hotel Cost/Night:     {hotelPerNight.ToString("C2", culture)}");
            Console.WriteLine($"Daily Food Budget:    {dailyFood.ToString("C2", culture)}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Gas Needed:           {gasNeeded:F2} gallons");
            Console.WriteLine($"Estimated Gas Cost:   {gasCost.ToString("C2", culture)}");
            Console.WriteLine($"Estimated Hotel Cost: {hotelCost.ToString("C2", culture)}");
            Console.WriteLine($"Estimated Food Cost:  {foodCost.ToString("C2", culture)}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Estimated Trip Total: {totalCost.ToString("C2", culture)}");
            Console.WriteLine("===============================================");
            Console.WriteLine("Thanks for using the Road Trip Budget Estimator!");
        }
    }
}
