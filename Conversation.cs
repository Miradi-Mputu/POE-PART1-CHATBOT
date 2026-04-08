using System;
//in this class 
namespace POE_PART1_CHATBOT
{
    public class Conversation
    {
        // Asks for the user's name and keeps asking until they type something
        public static string AskName()
        {
            string name = "";

            while (string.IsNullOrWhiteSpace(name))
            {
                Display.TypeWrite("Enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Display.TypeWrite("Name cannot be empty. Please try again.");
                    Console.ResetColor();
                }
            }

            return name;
        }

        // Greets the user by name then shows the topic list
        public static void WelcomeUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Display.TypeWrite("\nWelcome " + name + "!");
            Display.TypeWrite("I am Cyber Bot, your personal online safety guide.");
            Display.TypeWrite("I am here to help you learn how to stay safe online.");
            Console.ResetColor();

            ShowTopicList();
        }

        // Prints the full list of topics - also called when the user types 'menu'
        //this method is incharge of showing the topic list to the user, it is called in the welcome user method and also when the user types 'menu'
        // and at the beginning of the program after the user enters their name
        //this method is also called in the other classes when a certain body of code is completed and the user requests for it 
        public static void ShowTopicList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Display.TypeWrite("\n========================================");
            Display.TypeWrite("       HERE IS WHAT YOU CAN ASK ME");
            Display.TypeWrite("========================================");
            Display.TypeWrite("  1.  passwords");
            Display.TypeWrite("  2.  phishing");
            Display.TypeWrite("  3.  safe browsing");
            Display.TypeWrite("  4.  two factor authentication");
            Display.TypeWrite("  5.  malware");
            Display.TypeWrite("  6.  ransomware");
            Display.TypeWrite("  7.  firewall");
            Display.TypeWrite("  8.  virtual private network");
            Display.TypeWrite("  9.  social engineering");
            Display.TypeWrite("  10. data breach");
            Display.TypeWrite("  11. encryption");
            Display.TypeWrite("----------------------------------------");
            Display.TypeWrite("  Type a topic above to learn more.");
            Display.TypeWrite("  Type 'menu' to see this list again.");
            Display.TypeWrite("  Type 'exit' to leave.");
            Display.TypeWrite("========================================\n");
            Console.ResetColor();
        }
    }
}