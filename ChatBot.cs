using System;

namespace POE_PART1_CHATBOT
{
    public class ChatBot
    {
        // Prints a yellow topic heading before each response
        private void PrintHeading(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display.TypeWrite("\nChatBot:");
            Display.TypeWrite("========================================");
            Display.TypeWrite(title);
            Display.TypeWrite("========================================");
            Console.ResetColor();
        }

        // Prints the next step options after every response
        private void PrintNextStep()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Display.TypeWrite("\n----------------------------------------");
            Display.TypeWrite("  Type a topic to keep learning.");
            Display.TypeWrite("  Type 'menu' to see the topic list.");
            Display.TypeWrite("  Type 'exit' to leave.");
            Display.TypeWrite("----------------------------------------");
            Console.ResetColor();
        }

        // Checks what the user typed and returns a matching keyword for the switch
        private string GetTopic(string input)
        {
            if (input.Contains("menu")) return "menu";
            if (input.Contains("exit")) return "exit";
            if (input.Contains("how are you")) return "howareyou";
            if (input.Contains("purpose")) return "purpose";
            if (input.Contains("password")) return "password";
            if (input.Contains("phishing")) return "phishing";
            if (input.Contains("safe browsing")) return "safebrowsing";
            if (input.Contains("two factor") || input.Contains("2fa") || input.Contains("authentication")) return "2fa";
            if (input.Contains("malware") || input.Contains("virus") || input.Contains("trojan")) return "malware";
            if (input.Contains("ransomware") || input.Contains("ransom")) return "ransomware";
            if (input.Contains("firewall")) return "firewall";
            if (input.Contains("vpn") || input.Contains("virtual private network")) return "vpn";
            if (input.Contains("social engineering") || input.Contains("manipulation")) return "socialengineering";
            if (input.Contains("data breach") || input.Contains("data leak")) return "databreach";
            if (input.Contains("encryption") || input.Contains("encrypted")) return "encryption";

            return "unknown";
        }

        // Main chat loop - keeps running until the user types exit
        public void StartChat(string name)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nYou: ");
                    Console.ResetColor();

                    string input = Console.ReadLine();

                    if (input == null)
                    {
                        Display.TypeWrite("[Error: Input stream closed.]");
                        break;
                    }

                    input = input.ToLower().Trim();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Display.TypeWrite("Please type something so I can help you.");
                        continue;
                    }

                    switch (GetTopic(input))
                    {
                        case "menu":
                            Conversation.ShowTopicList();
                            break;

                        case "howareyou":
                            Display.TypeWrite("I am running smoothly and ready to help you stay safe online!");
                            PrintNextStep();
                            break;

                        case "purpose":
                            Display.TypeWrite("I am here to teach you how to stay safe online.");
                            Display.TypeWrite("Ask me about any cybersecurity topic and I will explain it simply.");
                            PrintNextStep();
                            break;

                        case "password":
                            PrintHeading("PASSWORDS");
                            Display.TypeWrite("A password is a secret word or combination of letters,");
                            Display.TypeWrite("numbers, and symbols that only you know.");
                            Display.TypeWrite("You use it to prove who you are when logging in.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  Weak   : password123");
                            Display.TypeWrite("  Strong : $uN#8kPz!mQ2@");
                            PrintNextStep();
                            break;

                        case "phishing":
                            PrintHeading("PHISHING");
                            Display.TypeWrite("Phishing is when a criminal pretends to be someone you trust");
                            Display.TypeWrite("to trick you into giving away your personal information.");
                            Display.TypeWrite("It usually happens through fake emails or websites.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  You get an email saying your bank account is locked.");
                            Display.TypeWrite("  You click the link and enter your password on a fake site.");
                            Display.TypeWrite("  The criminals now have your login details.");
                            PrintNextStep();
                            break;

                        case "safebrowsing":
                            PrintHeading("SAFE BROWSING");
                            Display.TypeWrite("Safe browsing means being careful about which websites");
                            Display.TypeWrite("you visit and what you click on while online.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  A pop-up says: 'You won an iPhone! Click here!'");
                            Display.TypeWrite("  Clicking it could install harmful software on your device.");
                            PrintNextStep();
                            break;

                        case "2fa":
                            PrintHeading("TWO FACTOR AUTHENTICATION");
                            Display.TypeWrite("Two factor authentication adds a second login step.");
                            Display.TypeWrite("After your password, you enter a code sent to your phone.");
                            Display.TypeWrite("Even if someone steals your password, they still cannot log in.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  You log into email with your password.");
                            Display.TypeWrite("  A 6 digit code is sent to your phone.");
                            Display.TypeWrite("  You enter the code to get in.");
                            PrintNextStep();
                            break;

                        case "malware":
                            PrintHeading("MALWARE");
                            Display.TypeWrite("Malware is harmful software designed to damage your device");
                            Display.TypeWrite("or steal your information. Types include viruses and trojans.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  You download a free game from an untrusted site.");
                            Display.TypeWrite("  It secretly records your passwords and sends them to a criminal.");
                            PrintNextStep();
                            break;

                        case "ransomware":
                            PrintHeading("RANSOMWARE");
                            Display.TypeWrite("Ransomware locks all your files and demands money to unlock them.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  An employee opens an email attachment.");
                            Display.TypeWrite("  All company files get locked.");
                            Display.TypeWrite("  A message appears: 'Pay or lose everything.'");
                            PrintNextStep();
                            break;

                        case "firewall":
                            PrintHeading("FIREWALL");
                            Display.TypeWrite("A firewall monitors all traffic coming in and out of your device");
                            Display.TypeWrite("and blocks anything that looks suspicious.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  A criminal tries to connect to your computer remotely.");
                            Display.TypeWrite("  Your firewall detects and blocks the connection automatically.");
                            PrintNextStep();
                            break;

                        case "vpn":
                            PrintHeading("VIRTUAL PRIVATE NETWORK (VPN)");
                            Display.TypeWrite("A VPN creates a secure private tunnel for your internet connection.");
                            Display.TypeWrite("It hides your activity from anyone trying to spy on you.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  You use free wifi at a coffee shop.");
                            Display.TypeWrite("  Without a VPN someone nearby could see your login details.");
                            Display.TypeWrite("  With a VPN on, all your data is encrypted and hidden.");
                            PrintNextStep();
                            break;

                        case "socialengineering":
                            PrintHeading("SOCIAL ENGINEERING");
                            Display.TypeWrite("Social engineering is when criminals manipulate people");
                            Display.TypeWrite("into giving away information instead of hacking systems.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  Someone calls claiming to be from your bank.");
                            Display.TypeWrite("  They ask for your password to fix an urgent problem.");
                            Display.TypeWrite("  They sound convincing but it is a scam.");
                            PrintNextStep();
                            break;

                        case "databreach":
                            PrintHeading("DATA BREACH");
                            Display.TypeWrite("A data breach is when criminals break into a company's systems");
                            Display.TypeWrite("and steal personal information like emails and passwords.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  A shopping site gets hacked.");
                            Display.TypeWrite("  50 million customer passwords are stolen and posted online.");
                            Display.TypeWrite("  Anyone who reused that password on other sites is now at risk.");
                            PrintNextStep();
                            break;

                        case "encryption":
                            PrintHeading("ENCRYPTION");
                            Display.TypeWrite("Encryption scrambles your data so only the right person can read it.");
                            Display.TypeWrite("\nExample:");
                            Display.TypeWrite("  You log in to your bank's website.");
                            Display.TypeWrite("  Your password is scrambled before being sent over the internet.");
                            Display.TypeWrite("  If a criminal intercepts it, they only see random characters.");
                            PrintNextStep();
                            break;

                        case "exit":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Display.TypeWrite("\nGoodbye " + name + "! Stay safe online.");
                            Console.ResetColor();
                            return;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Display.TypeWrite("I did not understand that. Type 'menu' to see what I can help with.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Display.TypeWrite("[Unexpected error: " + ex.Message + "]");
                    Display.TypeWrite("Please try again or type 'exit' to leave.");
                    Console.ResetColor();
                }
            }
        }
    }
}