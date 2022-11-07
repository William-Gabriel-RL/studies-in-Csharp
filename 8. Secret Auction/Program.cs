using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Secret_Auction
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, double> bids = new Dictionary<string, double>();
            Console.WriteLine("Welcome to the secret auction program!");

            bool end = false;

            while (!end)
            {
                Console.WriteLine("What's your name?");
                string user_name = Console.ReadLine();

                Console.WriteLine(Environment.NewLine + "What's your bid?");
                double user_bid = Convert.ToDouble(Console.ReadLine());

                bids.Add(user_name, user_bid);

                Console.WriteLine(Environment.NewLine + "Are there any other bidders? Type 'yes' or 'no'.");
                string keep_going = Console.ReadLine();

                if (keep_going == "yes")
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    var maxValue = bids.Values.Max();
                    var winner = bids.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                    Console.WriteLine($"The winner is {winner} with the bid of {maxValue}");
                    end = true;
                }
            }
        }
    }
}
