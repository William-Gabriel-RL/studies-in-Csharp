using System;

namespace Estudos
{
    public class Program
    {
        static void Main()
        {
            // Creating a greeting message.
            Console.WriteLine("Hello, this is the band name Generator!" + Environment.NewLine);

            // Ask the user for the city that they grew up in.
            Console.WriteLine("Which city that you have be grow up in?");
            string user_city = Console.ReadLine();

            // Ask the user for the name of a pet.
            Console.WriteLine(Environment.NewLine + "Cool! Now tell me a name of a pet:");
            string user_pet = Console.ReadLine();

            // Combine the name of their city and pet then show them their band name.
            string city_pet = user_city + " has " + user_pet;
            string pet_city = user_pet + " in " + user_city;

            Console.WriteLine(Environment.NewLine + "Well done! I have two suggestions for you right here.");
            Console.WriteLine($"The first one is '{city_pet}' or you can choose the second one: '{pet_city}'");
            Console.WriteLine("Hope you have enjoyed");
        }
    }
}
