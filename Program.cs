using System;
using POE_PART1_CHATBOT;

class Program
{
    static void Main()
    {
        Console.Clear();

        AudioPlayer.PlayGreeting();

        Display.ShowLogo();

        string name = Conversation.AskName();

        Conversation.WelcomeUser(name);

        ChatBot bot = new ChatBot();
        bot.StartChat(name);
    }
}