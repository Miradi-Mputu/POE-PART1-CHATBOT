using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public class AsciiArt
    {
        // Prints each character one at a time to create a typewriter effect
        private static void TypeWrite(string text, int delayMs = 18)
        {
            try
            {
                foreach (char c in text) { Console.Write(c); Thread.Sleep(delayMs); }
                Console.WriteLine();
            }
            catch
            {
                // If the effect fails, print normally so the user still sees the text
                Console.WriteLine(text);
            }
        }

        // Prints the ASCII art logo with a typewriter effect on each line
        // Uses a faster delay so the art renders crisply without feeling slow
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Each line of the logo is typed out one character at a time
            string[] logoLines =
            {
                "====================================================",
                "              CYBER BOT",
                "       Your Online Safety Guide",
                "====================================================",
                "",
                "  ####  ##  ## #####  #####",
                " ##  ## ##  ## ##  ## ##  ##",
                " ##      ####  #####  #####",
                " ##  ##   ##   ##  ## ##  ##",
                "  ####    ##   #####  ##   ##",
                "",
                "",
                " #####   #####  ######",
                " ##  ## ##   ##   ##",
                " ###### ##   ##   ##",
                " ##  ## ##   ##   ##",
                " #####   #####    ##",
                "",
                "====================================================",
            };

            foreach (string line in logoLines)
            {
                TypeWrite(line, 8);
            }

            // Console.ResetColor();
        }
    }
}