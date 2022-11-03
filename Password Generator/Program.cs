using System;
using System.Collections.Generic;
using System.Linq;

namespace Password_Generator
{
    public class Program
    {
        static void Main()
        {
            // Call random
            Random rnd = new Random();

            // Create the list of characters
            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] numbers = "1234567890".ToCharArray();
            char[] especial = "!@#$%&*()".ToCharArray();

            // Create a greeting message and explain the propose
            Console.WriteLine("Welcome to the password generator"
                + Environment.NewLine + "Here we will create an strong password for you, with the basic parameters for your security");

            //Ask for the parameters
            Console.WriteLine(Environment.NewLine + "How many letters you like in your password?");
            int pass_letters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "How many numbers you like in your password?");
            int pass_numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "How many especial characters you like in your password?");
            int pass_especial = Convert.ToInt32(Console.ReadLine());

            //Do the magic
            List<char> password = new List<char>();

            foreach (int value in Enumerable.Range(0, pass_letters))
            {
                password.Add(letters[rnd.Next(0, letters.Length)]);
            }

            foreach (int value in Enumerable.Range(0, pass_numbers))
            {
                password.Add(numbers[rnd.Next(0, numbers.Length)]);
            }

            foreach (int value in Enumerable.Range(0, pass_especial))
            {
                password.Add(especial[rnd.Next(0, especial.Length)]);
            }

            var shuffled = password.OrderBy(_ => rnd.Next()).ToList();
            var result = string.Join("", shuffled.ToArray());

            // Show the password
            Console.WriteLine(Environment.NewLine + $"Your password is: {result}");
        }
    }
}