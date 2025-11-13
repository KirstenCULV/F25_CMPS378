// CMPS 378: C# Programming Fall 2025
//Assignment 2 Problem 1: Freelance Project Income Tracker
// Author: Kaya Catano

using System;
using System.Globalization;

namespace Assignment2Problem1
{
    class Program
    {
        static void Main()
        {
            var culture = new CultureInfo("en-US");
            Console.WriteLine("****** Welcome to Freelance Project Income Tracker ******");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many projects would you like to enter? ");
            int projectCount = int.Parse(Console.ReadLine() ?? "0");

            double totalIncome = 0;
            string topProject = "";
            double topIncome = 0;

            for (int i = 1; i <= projectCount; i++)
            {
                Console.WriteLine($"\nProject #{i}:");
                Console.Write("Enter project name: ");
                string projName = Console.ReadLine();

                Console.Write("Enter hours worked: ");
                double hours = double.Parse(Console.ReadLine() ?? "0", culture);

                Console.Write("Enter hourly rate: ");
                double rate = double.Parse(Console.ReadLine() ?? "0", culture);

                double income = hours * rate;
                totalIncome += income;

                if (income > topIncome)
                {
                    topIncome = income;
                    topProject = projName;
                }
            }

            double avgIncome = projectCount > 0 ? totalIncome / projectCount : 0;

            Console.WriteLine("\n========== FREELANCE INCOME SUMMARY ==========");
            Console.WriteLine($"Freelancer Name:         {name}");
            Console.WriteLine($"Projects Logged:         {projectCount}");
            Console.WriteLine();
            Console.WriteLine($"Total Income:            {totalIncome.ToString("C2", culture)}");
            Console.WriteLine($"Average Project Income:  {avgIncome.ToString("C2", culture)}");
            Console.WriteLine($"Highest-Earning Project: {topProject} ({topIncome.ToString("C2", culture)})");
            Console.WriteLine("==============================================");
            Console.WriteLine("Thank you for using the Income Tracker!");
        }
    }
}