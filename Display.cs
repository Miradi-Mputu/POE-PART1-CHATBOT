using System;
using System.Threading;

namespace POE_PART1_CHATBOT
{
    public class Display
    {
        // Prints text one character at a time to create a typewriter effect
        // Every other class calls this method to print anything to the screen
        // a typewrite method was created to keep the code cleaner throughput the whole 
        public static void TypeWrite(string text, int delayMs = 18)
        //string text, int delayMs = 18 this line of code defines the type write effect, it will take the strings given in the other classes
        //and print them one character at a time with a delay of 18 milliseconds
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
        //the following method contains the logo display of the chatbot
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