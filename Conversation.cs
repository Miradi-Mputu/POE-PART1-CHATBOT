using System;

namespace POE_PART1_CHATBOT
{
    public class Conversation
    {
        public static string AskName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public static void WelcomeUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nWelcome {name}!");
            Console.WriteLine("I am Cyber Bot, your personal online safety guide.");
            Console.WriteLine("I am here to help you learn how to stay safe online.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========================================");
            Console.WriteLine("       HERE IS WHAT YOU CAN ASK ME");
            Console.WriteLine("========================================");

            Console.WriteLine("  1.  passwords");
            Console.WriteLine("  2.  phishing");
            Console.WriteLine("  3.  safe browsing");
            Console.WriteLine("  4.  two factor authentication");
            Console.WriteLine("  5.  malware");
            Console.WriteLine("  6.  ransomware");
            Console.WriteLine("  7.  firewall");
            Console.WriteLine("  8.  virtual private network");
            Console.WriteLine("  9.  social engineering");
            Console.WriteLine("  10. data breach");
            Console.WriteLine("  11. encryption");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================================");
            Console.WriteLine(" Type any topic above to learn more.");
            Console.WriteLine("  Type 'exit' when you are done.");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
    }
}