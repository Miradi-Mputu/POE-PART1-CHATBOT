using System;
using System.IO;
using System.Media;

namespace POE_PART1_CHATBOT
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AudioPlayer", "greeting.wav");

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