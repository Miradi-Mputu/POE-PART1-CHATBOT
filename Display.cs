using System;
using System.Threading;

namespace CybersecurityChatbot
{
    class Display
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
            ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================================");
            Console.WriteLine("   Cybersecurity Awareness Bot v1.0");
            Console.WriteLine("============================================");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Typing effect - prints text slowly like someone is typing
        public static void TypeText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30); // 30ms delay between each character
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void ShowDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
        }
    }
}