using CyberSecurityChatbot;
using System;
using CyberBot;

class Program
{
    static void Main()
    {
        Console.Clear();

        VoiceGreeting.PlayGreeting();

        AsciiArt.ShowLogo();

        string name = UserInteraction.AskName();

        UserInteraction.WelcomeUser(name);

        ChatBot bot = new ChatBot();
        bot.StartChat(name);
    }
}