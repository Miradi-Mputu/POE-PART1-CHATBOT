using System;
using System.Threading;

namespace POE_PART1_CHATBOT
{
    public class Display
    {
        // Prints text one character at a time to create a typewriter effect
        // Every other class calls this method to print anything to the screen
        public static void TypeWrite(string text, int delayMs = 18)
        {
            try
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(delayMs);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                // If the effect fails, print normally so no text is lost
                Console.WriteLine(text);
                Console.WriteLine("[Typewriter error: " + ex.Message + "]");
            }
        }

        // Prints the ASCII art logo using the typewriter effect
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] lines =
            {
                "====================================================",
                "                   CYBER BOT",
                "             Your Online Safety Guide",
                "====================================================",
                "  ####  ##  ## #####  #####",
                " ##  ## ##  ## ##  ## ##  ##",
                " ##      ####  #####  #####",
                " ##  ##   ##   ##  ## ##  ##",
                "  ####    ##   #####  ##   ##",
                "",
                " #####   #####  ######",
                " ##  ## ##   ##   ##",
                " ###### ##   ##   ##",
                " ##  ## ##   ##   ##",
                " #####   #####    ##",
                "====================================================",
            };

            foreach (string line in lines)
            {
                TypeWrite(line, 8);
            }

            Console.ResetColor();
        }
    }
}