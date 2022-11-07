using System;

namespace _3
{
    public class Program
    {
        static void Main()
        {
            // Show an welcome message
            Console.WriteLine(" .___________________________________________________. " +
                "\r\n |                         _                         | " +
                "\r\n |                                                   | " +
                "\r\n |              '                    `               | " +
                "\r\n |                                                   | " +
                "\r\n |                                                   | " +
                "\r\n |       /                 -                 \\       | " +
                "\r\n |                  '             `                  | " +
                "\r\n |                                                   | " +
                "\r\n |             /                       \\             | " +
                "\r\n |   .                     _                     .   | " +
                "\r\n |                      '     `                      | " +
                "\r\n |          '        /           \\        `          | " +
                "\r\n |                  .             .                  | " +
                "\r\n |                                                   | " +
                "\r\n | |       |       |       o       |       |       | | " +
                "\r\n |                                                   | " +
                "\r\n |                  `             '                  | " +
                "\r\n |          .        \\           /        .          | " +
                "\r\n |                      .  _  .                      | " +
                "\r\n |   `                                           '   | " +
                "\r\n |             \\                       /             | " +
                "\r\n |                                                   | " +
                "\r\n |                  .             .                  | " +
                "\r\n |       \\                 -                 /       | " +
                "\r\n |                                                   | " +
                "\r\n |                                                   | " +
                "\r\n |              .                    .               | " +
                "\r\n |                         _                         | " +
                "\r\n |___________________________________________________|");
            Console.WriteLine("Welcome to the ??????");
            Console.WriteLine("To play this game you only need to answer the simple questions that will appear to you.");
            Console.WriteLine("If you choose badly than the game is over and you have to restart.");

            //Using loops and conditionals make the game run
            bool game_over;

            Console.WriteLine(Environment.NewLine + "Do you wanna play? 'y' or 'n'");
            char game_start = Convert.ToChar(Console.ReadLine());
            if (game_start == 'y')
            {
                Console.Clear();
                Console.WriteLine("What's your name?");
                string user_name = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + $"Let's begin, {user_name}...");

                Console.WriteLine(Environment.NewLine + "You wake up in a cold and dark room. " +
                    "Your face is on the floor and your arms are tied back. " +
                    "You feel something nearby your hands. " +
                    "You 'take' or 'wait'?");
                string choice_1 = Console.ReadLine();
                if (choice_1 == "take")
                {
                    Console.WriteLine(Environment.NewLine + "You feel that is a loose sharp object, but seems to be thin and fragile. " +
                        "You try to go 'slow' or 'quick' to get out?");
                    string choice_2 = Console.ReadLine();
                    if (choice_2 == "slow")
                    {
                        Console.WriteLine(Environment.NewLine + "Slowly you go futher and you cut the thing that made you tied. " +
                            "But the dark remains. You feel the walls, but can't find a door. " +
                            "You try the floor, and the result is the same, but in the ceiling you find a hand cranck. " +
                            "You spin and a watterfall came in. You 'wait' or 'prepare' to swim to the top?");
                        string choice_3 = Console.ReadLine();
                        if (choice_3 == "prepare")
                        {
                            Console.WriteLine(Environment.NewLine + "You feel that's the moment. " +
                                "You hold your breath and swim up the most quickly you can. " +
                                "You barely survive. Now you can see water to every side. " +
                                "You can't see the land, but at least you survived. " +
                                "You swim to a side with the hope to be the right one. Only the future can tells...");
                            Console.WriteLine(Environment.NewLine + $"Thanks for play, {user_name}, but that's all...");
                            game_over = true;
                        }
                        else
                        {
                            Console.WriteLine(Environment.NewLine + $"You wait and this sentences you. When you try to swim it's too late. You drown, {user_name}");
                            game_over = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine(Environment.NewLine + $"The rush is a sin, you create a deep wound and broke the object. " +
                            $"You bleed and wait for the death, {user_name}");
                        game_over = true;
                    }
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + $"You wait for 3 days until the death came to see you, {user_name}");
                    game_over = true;
                }
            }
            else
            {
                game_over = true;
            }
            //Show the game over message
            if (game_over == true)
            {
                Console.WriteLine("Game Over!");
            }
        }
    }
}
