using System;
using POE_PART1_CHATBOT;
// this is the main class of the whole program, all the classes have been called in this class to allow them to run in sync
class Program
{
    static void Main()
    {
        Console.Clear();
        //class to activate the audio 
        AudioPlayer.PlayGreeting();
        //this class activated the logo display class to run
        Display.ShowLogo();

        //this is for the conversation class, it will take in the users input which will first be their name and then give it to the class
        // to welcome the user and then start the chat bot
        string name = Conversation.AskName();
        Conversation.WelcomeUser(name);

        //this is the class that will start the chat bot and take in the users name to start the conversation
        ChatBot bot = new ChatBot();
        bot.StartChat(name);
    }
}