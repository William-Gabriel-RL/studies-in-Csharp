using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Blackjack_Game
{
    public class Program
    {
        Random rnd = new Random();
        public int DealCard()
        {
            int[] cards = { 11, 2, 3, 4, 5, 6, 7, 8, 10, 10, 10, 10 };
            return cards[rnd.Next(cards.Length)];
        }
        public void FirstDeal(List<int> player, List<int> computer)
        {
            for (int i = 0; i < 2; i++)
            {
                player.Add(DealCard());
                computer.Add(DealCard());
            }
        }
        public int CalculateScore(List<int> list)
        {
            if (list.Sum() == 21 && list.Count() == 2)
            {
                return 0;
            }
            if (list.Contains(11) && list.Sum() == 21)
            {
                list.Remove(11);
                list.Add(1);
            }
            return list.Sum();
        }
        static void Main()
        {
            var logo = "\r\n888     888                888       d8b                888      \r\n888     888                888       Y8P                888      \r\n888     888                888                          888      \r\n88888b. 888 8888b.  .d8888b888  888 8888 8888b.  .d8888b888  888 \r\n888 \"88b888    \"88bd88P\"   888 .88P \"888    \"88bd88P\"   888 .88P \r\n888  888888.d888888888     888888K   888.d888888888     888888K  \r\n888 d88P888888  888Y88b.   888 \"88b  888888  888Y88b.   888 \"88b \r\n88888P\" 888\"Y888888 \"Y8888P888  888  888\"Y888888 \"Y8888P888  888 \r\n                                     888                         \r\n                                    d88P                         \r\n                                  888P   ";

            //Creating the player's and computer's hands
            List<int> playerCards = new List<int>();
            List<int> computerCards = new List<int>();

            Program program = new Program();

            var end = false;
            while (!end)
            {
                Console.WriteLine("Do you want to play a game of Blackjack? Type 'y' or 'n':");
                var gameStart = Console.ReadLine();
                if (gameStart == "y")
                {
                    Console.WriteLine("What's your name?");
                    var playerName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(logo);

                    // First pair for each player
                    program.FirstDeal(playerCards, computerCards);

                    if (playerCards.Sum() < 21 && computerCards.Sum() < 21)
                    {
                        Console.WriteLine(Environment.NewLine + $"{playerName}'s cards: {string.Join(", ", playerCards)}, current score {program.CalculateScore(playerCards)}");
                        Console.WriteLine($"Computer's first card: {computerCards[0]}");

                        while (playerCards.Sum() < 21)
                        {
                            if (playerCards.Sum() == 21 || playerCards.Sum() > 21)
                            {
                                break;
                            }
                            Console.WriteLine("Type 'y' to hit or 'n' to pass:");
                            var hitOrPass = Console.ReadLine();
                            if (hitOrPass == "y")
                            {
                                playerCards.Add(program.DealCard());
                                Console.WriteLine(Environment.NewLine + $"{playerName}'s cards: {string.Join(", ", playerCards)}, current score {program.CalculateScore(playerCards)}");
                                Console.WriteLine($"Computer's first card: {computerCards[0]}");
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (program.CalculateScore(computerCards) != 0 && program.CalculateScore(computerCards) < 18 && program.CalculateScore(playerCards) < 21)
                        {
                            computerCards.Add(program.DealCard());
                        }
                    }
                    Console.WriteLine(Environment.NewLine + $"{playerName}'s final hand: {string.Join(", ", playerCards)} - Final score: {program.CalculateScore(playerCards)}");
                    Console.WriteLine($"Computers's final hand: {string.Join(", ", computerCards)} - Final score: {program.CalculateScore(computerCards)}" + Environment.NewLine);

                    if (program.CalculateScore(computerCards) == program.CalculateScore(playerCards))
                    {
                        Console.WriteLine("It's a draw");
                    }
                    else if (program.CalculateScore(playerCards) == 0 || program.CalculateScore(computerCards) > 21)
                    {
                        Console.WriteLine($"You win, {playerName}");
                    }
                    else if (program.CalculateScore(computerCards) == 0 || program.CalculateScore(playerCards) > 21)
                    {
                        Console.WriteLine("You Lose");
                    }
                    else if (program.CalculateScore(playerCards) > program.CalculateScore(computerCards))
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("You Lose");
                    }
                    end = true;
                }
                else
                {
                    end = true;
                }
            }
        }
    }
}
