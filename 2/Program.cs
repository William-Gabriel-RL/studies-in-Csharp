using System;

namespace _2
{
    public class Program
    {
        static void Main()
        {
            //This is a tip calculator
            //Show a welcome message for the user
            Console.WriteLine("Hello there, welcome to the tip calculator");

            //Get the total bill, the percentage of the tip and how many people will split the total
            Console.WriteLine("What was the total bill? Ex: 15,52");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Wha percentage tip would you like to give? 10, 12 or 15?");
            double tip_percentage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "How many people to split the bill?");
            double split_number = Convert.ToDouble(Console.ReadLine());

            //Now the math
            double total_bill = bill + (bill * (tip_percentage / 100));
            double each_part = total_bill / split_number;

            // Show the result
            Console.WriteLine(Environment.NewLine + $"The total bill was ${Math.Round(total_bill, 2)} and each person should pay ${Math.Round(each_part, 2)}");
        }
    }
}
