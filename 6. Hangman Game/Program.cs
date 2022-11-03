using System;
using System.Linq;

namespace _6.Hangman_Game
{
    public class Program
    {
        static void Main()
        {
            // Get an array of words
            string[] words = { "banana", "apple", "shirt", "rumble", "night", "avocado", "umbrella", "academy", "list", "uppercut", "lesson" };

            string[] hangman = { "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========", 
                "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========", 
                "  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========",
                "  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n========="};

            // Call random
            Random rnd = new Random();

            // Pick a word
            string choosed_word = words[rnd.Next(0, words.Length)];


            // Set the display
            var display = (from char ch in choosed_word
                           select '_').ToList();

            // Set player lives
            int player_lives = 6;

            // Make a while loop to the game works
            while (player_lives > 0)
            {
                if (display.Contains('_')) 
                {
                    //Show the hangman picture and the display to the game move on
                    Console.Clear();
                    Console.WriteLine(hangman[player_lives]);
                    Console.WriteLine(string.Join(" ",display));

                    Console.WriteLine(Environment.NewLine + "Guess a letter:");
                    // Make the guess be in lowercase
                    char guess = Convert.ToChar(Console.ReadLine().ToLower());
                    int letter_pos = 0;

                    if (choosed_word.Contains(guess)) 
                    { 
                        if(display.Contains(guess))
                        {
                            Console.WriteLine("You already have guessed this letter");
                        }

                        else
                        {
                            foreach (char ch in choosed_word)
                            {
                                if (ch == guess)
                                {
                                    display.RemoveAt(letter_pos);
                                    display.Insert(letter_pos, ch);
                                }
                                letter_pos++;
                            }
                        }

                    }   
                    else
                    {
                        Console.WriteLine("You guessed wrong, you lose a life");
                        player_lives--;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(hangman[6]);
                    Console.WriteLine(string.Join(" ", display));
                    Console.WriteLine("You have won!");
                    break;
                }
            }

            if (player_lives == 0)
            {
                Console.Clear();
                Console.WriteLine(hangman[player_lives]);
                Console.WriteLine($"You lose, the right word is {choosed_word}" 
                    + Environment.NewLine + "Game over");
            }
        }
    }
}