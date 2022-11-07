using System;

namespace _4
{
    public class Program
    {
        static void Main()
        {
            //Make the setup
            string rock = "    _______\r\n---'   ____)  \r\n      (_____)  \r\n      (_____)  \r\n      (____)\r\n---.__(___) ";
            string paper = "    _______\r\n---'   ____)____  \r\n          ______)  \r\n          _______)  \r\n         _______)\r\n---.__________) ";
            string scissors = "    _______\r\n---'   ____)____  \r\n          ______)  \r\n       __________)  \r\n      (____)\r\n---.__(___) ";

            string[] game_pos = { rock, paper, scissors };

            //Call random
            Random rnd = new Random();

            // Show the welcome message and explain the rules
            Console.WriteLine("!!! Welcome to the rock-paper-scissors (Jokenpo) game !!!" + Environment.NewLine);
            Console.WriteLine("In this game you have to choose between the number 0, 1, or 2, that corresponds to rock, paper and scissors" + Environment.NewLine);
            Console.WriteLine("Remember:");
            Console.WriteLine("- Rock wins scissors");
            Console.WriteLine("- Paper wins rocks");
            Console.WriteLine("- Scissors wins paper" + Environment.NewLine);

            //Take the player choice
            Console.WriteLine("Rock, paper or scissors? (Type 0, 1 or 2)");
            int player_choice = Convert.ToInt32(Console.ReadLine());

            if (player_choice < 0 || player_choice >= 3)
            {
                Console.WriteLine("Wrong enter, I give you a random choice then...");
                player_choice = rnd.Next(3);
            }
            Console.WriteLine(game_pos[player_choice]);

            //Take the computer choice
            int computer_choice = rnd.Next(3);
            Console.WriteLine(Environment.NewLine + $"The computer choosed" + Environment.NewLine + game_pos[computer_choice]);

            //Compare choices
            if (computer_choice == 0 && player_choice == 2)
            {
                Console.WriteLine("You lose");
            }
            else if ((player_choice == 0 && computer_choice == 2) || (player_choice > computer_choice))
            {
                Console.WriteLine(Environment.NewLine + "You win!!");
            }
            else if (computer_choice == player_choice)
            {
                Console.WriteLine("It's a draw");
            }
            else
            {
                Console.WriteLine("You lose");
            }


            //End the game
            Console.WriteLine(Environment.NewLine + "Thanks for playing!");
            Console.WriteLine("Game Over");
        }
    }
}
