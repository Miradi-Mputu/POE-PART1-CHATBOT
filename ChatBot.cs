using POE_PART1_CHATBOT;
using System;

namespace CybersecurityChatbot
{
    class Chatbot
    {
        private string userName = "";

        public void Start()
        {
            // Ask for the user's name
            Display.TypeText("Bot: Hello! What is your name?", ConsoleColor.Yellow);
            Console.Write("You: ");
            userName = Console.ReadLine();

            // Input validation for name
            while (string.IsNullOrWhiteSpace(userName))
            {
                Display.TypeText("Bot: I didn't catch that. Please enter your name.", ConsoleColor.Red);
                Console.Write("You: ");
                userName = Console.ReadLine();
            }

            // Personalised welcome
            Display.ShowDivider();
            Display.TypeText($"Bot: Nice to meet you, {userName}! I'm here to help you stay safe online.", ConsoleColor.Yellow);
            Display.TypeText("Bot: You can ask me about: passwords, phishing, safe browsing.", ConsoleColor.Yellow);
            Display.TypeText("Bot: Type 'exit' to quit.", ConsoleColor.Yellow);
            Display.ShowDivider();

            // Main chat loop
            while (true)
            {
                Console.WriteLine();
                Console.Write($"{userName}: ");
                string input = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    Display.TypeText("Bot: I didn't quite understand that. Could you rephrase?", ConsoleColor.Red);
                    continue;
                }

                // Exit condition
                if (input.ToLower() == "exit")
                {
                    Display.TypeText($"Bot: Goodbye, {userName}! Stay safe online!", ConsoleColor.Yellow);
                    break;
                }

                // Get and show response
                string response = Conversation.GetResponse(input, userName);
                Display.ShowDivider();
                Display.TypeText($"Bot: {response}", ConsoleColor.Yellow);
                Display.ShowDivider();
            }
        }
    }
}