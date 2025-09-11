/* Class Practice 2.5
 * Conversion Types
 * User Input
 */



using System;

namespace ClassPractice1

{
    class ClassPractice1
    {
        static void Main(string[] args)
        {
            /*
            //Declare variables
            string name = " ";
            int age, num1, num2 = 0;
            char sex = ' ';

            // User input (datatype varName = Console.ReadLine();)
            // Alternate User input (datatype varName = value;  varName = Console.ReadLine();)

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your sex(M/F): ");
            sex = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine(" ");


            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + (num1 + num2)); 
            */


            // Declare variables
            string gasName = " ";
            double gasPrice = 0D;
            int gasGallons = 0, gasTax = 0;

            // User input
            Console.WriteLine("Please enter the name of the gas station: ");
            gasName = Console.ReadLine();

            Console.WriteLine("Please enter the gas price: ");
            gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter how many gallons you'd like: ");
            gasGallons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the tax rate: ");
            gasTax = Convert.ToInt32(Console.ReadLine());

            // Output
            Console.WriteLine("********** " + gasName + " **********");
            Console.WriteLine("Gas Price: $" + gasPrice);
            Console.WriteLine("Number of Gallons: " + gasGallons);
            Console.WriteLine("Tax Rate: " + gasTax + "%");
            Console.WriteLine("Subtotal: $" + (gasPrice * gasGallons));
            Console.WriteLine("Tax: $" + (gasTax * .01 * gasPrice * gasGallons));
            Console.WriteLine("Total: $" + ((gasPrice * gasGallons) + (gasTax * .01 * gasPrice * gasGallons)));

        }

    }

}
