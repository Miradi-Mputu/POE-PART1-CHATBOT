using System;
using System.IO;
using System.Media;
//This class is responsible for playing the greeting audio when the program starts, it is called in the main method of the program class,
//it uses the System.Media.SoundPlayer class to play a wav file located in the AudioPlayer folder
namespace POE_PART1_CHATBOT
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                //this line of code locates the audio in the folder and combines it with the base directory of the program to create the full path to the audio file
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AudioPlayer", "greeting.wav");
                //i used an If statment that if the audio is found it should play it, else it will print the error message in read 
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Voice greeting file not found - continuing without audio]");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Audio error: " + ex.Message + "]");
                Console.ResetColor();
            }
        }
    }
}