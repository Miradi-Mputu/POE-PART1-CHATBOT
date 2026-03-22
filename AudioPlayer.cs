using System;
using System.IO;
using System.Media;

// This class is responsible for playing the voice greeting audio
namespace POE_PART1_CHATBOT
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Look for greeting.wav directly in the output folder
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

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
                Console.WriteLine($"[Audio could not be played: {ex.Message}]");
                Console.ResetColor();
            }
        }
    }
}