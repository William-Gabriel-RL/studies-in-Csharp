using System;

namespace _11.Guess_Number
{
    public class Program
    {
        public int SetDifficulty()
        {
            Console.WriteLine(Environment.NewLine + "Choose a difficulty. Type 'easy' or 'hard'...");
            var difficulty = Console.ReadLine();
            if (difficulty.ToLower() == "easy")
            {
                return 10;
            }
            return 5;
        }
        public int CheckGuess(int guess, int secretNumber, int lifes)
        {
            if (guess > secretNumber)
            {
                Console.WriteLine("Too High");
                return lifes -= 1;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too Low");
                return lifes -= 1;
            }
            Console.WriteLine(Environment.NewLine + $"You Won");
            return 101;
        }
        public void Game()
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            var secretNumber = rnd.Next(1, 101);
            var lifes = SetDifficulty();

            var guess = 0;
            while (guess != secretNumber)
            {
                if (lifes > 0)
                {
                    if (lifes == 101)
                    {
                        break;
                    }
                    Console.WriteLine(Environment.NewLine + $"You have {lifes} attemps");
                    Console.WriteLine("Make a guess:");
                    guess = Convert.ToInt32(Console.ReadLine());
                    lifes = CheckGuess(guess, secretNumber, lifes);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + $"You Lost, the secret number was {secretNumber}");
                    break;
                }
            }
        }
        static void Main()
        {
            Program program = new Program();
            program.Game();
        }
    }
}
