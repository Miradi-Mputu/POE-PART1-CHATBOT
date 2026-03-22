using System;

namespace CybersecurityChatbot
{
    class Conversation
    {
        public static string GetResponse(string input, string userName)
        {
            // Convert to lowercase so we can match easily
            string lowerInput = input.ToLower();

            // General questions
            if (lowerInput.Contains("how are you"))
            {
                return $"I'm doing great, {userName}! Ready to help you stay cyber-safe!";
            }
            else if (lowerInput.Contains("purpose") || lowerInput.Contains("what can you do"))
            {
                return "My purpose is to educate you about cybersecurity. I can help with topics like passwords, phishing, and safe browsing.";
            }
            else if (lowerInput.Contains("what can i ask"))
            {
                return "You can ask me about: passwords, phishing, safe browsing, or just say hello!";
            }

            // Password topic
            else if (lowerInput.Contains("password"))
            {
                return "Use strong passwords with a mix of letters, numbers, and symbols. " +
                       "Never reuse passwords across different sites. " +
                       "Consider using a password manager like Bitwarden or LastPass!";
            }

            // Phishing topic
            else if (lowerInput.Contains("phishing"))
            {
                return "Phishing is when attackers pretend to be trustworthy sources to steal your info. " +
                       "Never click suspicious links in emails. " +
                       "Always verify the sender's email address before responding.";
            }

            // Safe browsing topic
            else if (lowerInput.Contains("browsing") || lowerInput.Contains("safe") || lowerInput.Contains("internet"))
            {
                return "For safe browsing: always look for 'https://' in website URLs. " +
                       "Avoid public Wi-Fi for sensitive tasks. " +
                       "Keep your browser updated to get the latest security patches.";
            }

            // Hello / hi
            else if (lowerInput.Contains("hello") || lowerInput.Contains("hi"))
            {
                return $"Hello, {userName}! How can I help you with cybersecurity today?";
            }

            // Default response for unrecognised input
            else
            {
                return "I didn't quite understand that. Could you rephrase? " +
                       "Try asking about: passwords, phishing, or safe browsing.";
            }
        }
    }
}