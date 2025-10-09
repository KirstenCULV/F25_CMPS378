// Birthday Date Meaning Generator

using System;

namespace Assignment1Problem2
{
    class Assignment1Problem2
    {
        static void Main(string[] args)
        {
            //initialize variables
            int year = 0;
            char loopz = 'W';
            string day, month, yearMeaning = " ";
            string monthMeaning = " ";
            string dayMeaning = " ";

        //loop
        loopBegin:

            //user input
            Console.WriteLine("Welcome to the Birthday Date Meaning Generator!");
            Console.WriteLine("Please enter the month of your birthday: ");
            month = Console.ReadLine();
            Console.WriteLine("Please enter the day of your birthday (1st, 2nd, etc.): ");
            day = Console.ReadLine();
            Console.WriteLine("Please enter the year of your birthday: ");
            year = Convert.ToInt32(Console.ReadLine());

            //process input for month
            if (month == "January")
            {
                monthMeaning = "Janus";
            }

            if (month == "February")
            {
                monthMeaning = "Februa";
            }

            if (month == "March")
            {
                monthMeaning = "Mars";
            }

            if (month == "April")
            {
                monthMeaning = "Aperire";
            }

            if (month == "May")
            {
                monthMeaning = "Maia";
            }

            if (month == "June")
            {
                monthMeaning = "Juno";
            }

            if (month == "July")
            {
                monthMeaning = "Julius";
            }

            if (month == "August")
            {
                monthMeaning = "Augustus";
            }

            if (month == "September")
            {
                monthMeaning = "Seventh";
            }

            if (month == "October")
            {
                monthMeaning = "Eighth";
            }

            if (month == "November")
            {
                monthMeaning = "Ninth";
            }

            if (month == "December")
            {
                monthMeaning = "Tenth";
            }

            //process input for day
            if (day == "1st")
            {
                dayMeaning = "are a self-starter";
            }

            if (day == "2nd")
            {
                dayMeaning = "are a solution finder";
            }

            if (day == "3rd")
            {
                dayMeaning = "are expressive";
            }

            if (day == "4th")
            {
                dayMeaning = "are stable";
            }

            if (day == "5th")
            {
                dayMeaning = "are flexible";
            }

            if (day == "6th")
            {
                dayMeaning = "have a good heart";
            }

            if (day == "7th")
            {
                dayMeaning = "possess a refined mind";
            }

            if (day == "8th")
            {
                dayMeaning = "are self-sufficient";
            }

            if (day == "9th")
            {
                dayMeaning = "are compassionate";
            }

            if (day == "10th")
            {
                dayMeaning = "are a leader";
            }

            if (day == "11th")
            {
                dayMeaning = "have a strong intuition";
            }

            if (day == "12th")
            {
                dayMeaning = "are creative";
            }

            if (day == "13th")
            {
                dayMeaning = "are conscientious";
            }

            if (day == "14th")
            {
                dayMeaning = "are open-minded";
            }

            if (day == "15th")
            {
                dayMeaning = "are loving";
            }

            if (day == "16th")
            {
                dayMeaning = "are inquisitive";
            }

            if (day == "17th")
            {
                dayMeaning = "are independent";
            }

            if (day == "18th")
            {
                dayMeaning = "are open-hearted";
            }

            if (day == "19th")
            {
                dayMeaning = "are capable";
            }

            if (day == "20th")
            {
                dayMeaning = "relate to others";
            }

            if (day == "21st")
            {
                dayMeaning = "are social";
            }

            if (day == "22nd")
            {
                dayMeaning = "are a creator";
            }

            if (day == "23rd")
            {
                dayMeaning = "have a zest for life";
            }

            if (day == "24rd")
            {
                dayMeaning = "have a heart of gold";
            }

            if (day == "25th")
            {
                dayMeaning = "have a great ability to take in information";
            }

            if (day == "26th")
            {
                dayMeaning = "have a desire to succeed";
            }

            if (day == "27th")
            {
                dayMeaning = "are tolerant";
            }

            if (day == "28th")
            {
                dayMeaning = "recognize the value of others";
            }

            if (day == "29th")
            {
                dayMeaning = "are connective";
            }

            if (day == "30th")
            {
                dayMeaning = "are innovative";
            }

            if (day == "31st")
            {
                dayMeaning = "are balanced";
            }

            //process inout for year
            if (year > 1927 && year <= 1945)
            {
                yearMeaning = "the Silent Generation";
            }

            if (year > 1945 && year <= 1964)
            {
                yearMeaning = "a Baby Boomer";
            }

            if (year > 1964 && year <= 1980)
            {
                yearMeaning = "Generation X ";
            }

            if (year > 1980 && year <= 1996)
            {
                yearMeaning = "a Millenial";
            }

            if (year > 1996 && year <= 2012)
            {
                yearMeaning = "Generation Z";
            }

            if (year > 2012 && year <= 2025)
            {
                yearMeaning = "Generation Alpha";
            }

            //output
            Console.WriteLine("The month of " + month + " comes from " + monthMeaning + ".");
            Console.WriteLine("The " + day + " of " + month + " means you " + dayMeaning + ".");
            Console.WriteLine("The year of " + year + " means that you are " + yearMeaning + ".");

            Console.WriteLine("Try another birthday? (Y/N)");
            loopz = Convert.ToChar(Console.ReadLine());

            if (loopz == 'Y')
            {
                goto loopBegin;
            }

            else
            {
                Console.WriteLine("Thank you for playing!");
            }

        }
    }

}

