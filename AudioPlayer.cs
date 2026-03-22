using System;
using System.IO;
using System.Media;
//this class is responsible for running the voice audio
//the audio is found in a folder in this code and has been integrated into
namespace CyberSecurityChatbot
{
    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AudioPlayer", "greeting.wav");

                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio greeting could not be played.");
            }
        }
    }
}