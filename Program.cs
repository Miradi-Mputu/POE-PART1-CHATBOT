using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Display.ShowLogo();
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}