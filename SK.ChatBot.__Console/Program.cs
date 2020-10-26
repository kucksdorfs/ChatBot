using System;
using System.Configuration;

namespace SK.ChatBot.__Console
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";
            do
            {
                Console.WriteLine("Enter a valid zip code.");

                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input)) {
                    Console.WriteLine(SK.ChatBot.ParsingFactory.Parse($"!Weather {input}"));
                }
            }
            while (!string.IsNullOrEmpty(input));
        }
    }
}
