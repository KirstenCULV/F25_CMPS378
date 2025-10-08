// BMI Calculator

using System;

namespace Assignment1Problem1

{
    class Assignment1Problem1
    {
        static void Main(string[] args)
        {
            //intialize variables
            double weightPounds, heightFeet, heightInches = 0D;
            string name, sex;
            int age;

            //user input
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your sex (male/female): ");
            sex = Console.ReadLine();

            Console.WriteLine("Please enter your height in feet: ");
            heightFeet = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your height in inches: ");
            heightInches = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your weight in pounds: ");
            weightPounds = Convert.ToDouble(Console.ReadLine());

            //process responses
            double heightInInches = (heightFeet * 12) + heightInches;
            double BMI = (703.0D * (weightPounds / (heightInInches * heightInInches)));
            double BMIRounded = Math.Round(BMI, 2);

            //determine BMI
            string yourBMI;
            if (BMI < 16)
                yourBMI = "Severe Thinness";
            else if (BMI >= 16 && BMI < 17)
                yourBMI = "Moderate Thinness";
            else if (BMI >= 17 && BMI < 18.5)
                yourBMI = "Mild Thinness";
            else if (BMI >= 18.5 && BMI < 25)
                yourBMI = "Normal";
            else if (BMI >= 25 && BMI < 30)
                yourBMI = "Overweight";
            else if (BMI >= 30 && BMI < 35)
                yourBMI = "Obese Class 1";
            else if (BMI >= 35 && BMI < 40)
                yourBMI = "Obese Class 2";
            else
                yourBMI = "Obese Class 3";

            //output
            Console.WriteLine("Hi " + name + ". You are " + sex + ". You are " + age + " years old. " +
                "You are currently " + heightFeet + "'" + heightInches + " and currently weigh " + 
                weightPounds + " pounds. Your BMI is " + BMIRounded + " which is " + yourBMI + ". " +
                "Thank you for using the BMI Calculator!");
        }
    }
}
 