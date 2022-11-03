using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Caesar_Cypher
{
    public class Program
    {
        public char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static void Main()
        {
            string logo = "           \r\n ,adPPYba, ,adPPYYba,  ,adPPYba, ,adPPYba, ,adPPYYba, 8b,dPPYba,  \r\na8\"     \"\" \"\"     `Y8 a8P_____88 I8[    \"\" \"\"     `Y8 88P'   \"Y8  \r\n8b         ,adPPPPP88 8PP\"\"\"\"\"\"\"  `\"Y8ba,  ,adPPPPP88 88          \r\n\"8a,   ,aa 88,    ,88 \"8b,   ,aa aa    ]8I 88,    ,88 88          \r\n `\"Ybbd8\"' `\"8bbdP\"Y8  `\"Ybbd8\"' `\"YbbdP\"' `\"8bbdP\"Y8 88   \r\n            88             88                                 \r\n           \"\"             88                                 \r\n                          88                                 \r\n ,adPPYba, 88 8b,dPPYba,  88,dPPYba,   ,adPPYba, 8b,dPPYba,  \r\na8\"     \"\" 88 88P'    \"8a 88P'    \"8a a8P_____88 88P'   \"Y8  \r\n8b         88 88       d8 88       88 8PP\"\"\"\"\"\"\" 88          \r\n\"8a,   ,aa 88 88b,   ,a8\" 88       88 \"8b,   ,aa 88          \r\n `\"Ybbd8\"' 88 88`YbbdP\"'  88       88  `\"Ybbd8\"' 88          \r\n              88                                             \r\n              88           \r\n";
            Console.WriteLine(logo);

            Program loop = new Program();
            loop.DoLoop();
        }
        public void Caesar(string direction, string text, int shift)
        {
            List<char> text_list = new List<char>();
            int new_index;

            foreach(char ch in text)
            {
                if (alphabet.Contains(ch))
                {
                    int alphabet_index = Array.IndexOf(alphabet, ch);
                    if (direction == "encode")
                    {
                        new_index = alphabet_index + shift;
                        while (new_index > 26)
                        {
                            new_index-=26;
                        }
                        text_list.Add(alphabet[new_index]);
                    }
                    else if (direction == "decode")
                    {
                        new_index = alphabet_index + shift;
                        while (new_index < 0)
                        {
                            new_index += 26;
                        }
                        text_list.Add(alphabet[new_index]);
                    }

                }
                else
                {
                    text_list.Add(ch);
                }
            }
            Console.WriteLine(string.Join("", text_list));
        }
        public void DoLoop()
        {
            bool is_on = true;
            while (is_on)
            {
                Console.WriteLine("Type 'encode' to encrypt or type 'decode' to decrypt:");
                string direction = Console.ReadLine();

                Console.WriteLine(Environment.NewLine + "Type you message:");
                string text = Console.ReadLine();

                Console.WriteLine("Type the shift numbers:");
                int shift = Convert.ToInt32(Console.ReadLine());

                Caesar(direction, text, shift);

                Console.WriteLine(Environment.NewLine + "Want to restart the program? Type 'yes' or 'no':");
                string finish = Console.ReadLine();

                if (finish == "no")
                {
                    is_on = false;
                }
            }
        }
    }
}
