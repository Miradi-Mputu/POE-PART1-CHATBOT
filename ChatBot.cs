using System;
using System.Threading;

namespace POE_PART1_CHATBOT
{
    public class ChatBot
    {
        // Prints text one character at a time to create a typewriter effect
        private void TypeWrite(string text, int delayMs = 18)
        {
            try
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(delayMs);
                }
                Console.WriteLine();
            }
            catch
            {
                // If the typewriter effect fails, print the text normally so the user still sees the response
                Console.WriteLine(text);
            }
        }

        // Shows the navigation options after the chatbot finishes responding to a topic
        // Reminds the user they can go back to the menu, exit, or ask about another topic
        private void ShowMenuPrompt(string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("  What would you like to do next?");
            Console.WriteLine("  Type 'menu'  to go back to the topic list.");
            Console.WriteLine("  Type 'exit'  to leave the chat.");
            Console.WriteLine("  Or type another topic to keep learning.");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();
        }

        // Displays the full list of topics the chatbot can answer
        // Called when the user types 'menu' or when the chat first starts
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========================================");
            Console.WriteLine("       HERE IS WHAT YOU CAN ASK ME");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine("  1.  passwords");
            Console.WriteLine("  2.  phishing");
            Console.WriteLine("  3.  safe browsing");
            Console.WriteLine("  4.  two factor authentication");
            Console.WriteLine("  5.  malware");
            Console.WriteLine("  6.  ransomware");
            Console.WriteLine("  7.  firewall");
            Console.WriteLine("  8.  virtual private network");
            Console.WriteLine("  9.  social engineering");
            Console.WriteLine("  10. data breach");
            Console.WriteLine("  11. encryption");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================\n");
            Console.WriteLine("\n  Type any topic above to learn more.");
            Console.WriteLine("  Type 'exit' when you are done.");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        // Reads the user's input and maps it to a topic keyword
        // The returned keyword is used by the switch statement in StartChat to pick the right response
        private string GetTopic(string input)
        {
            if (input.Contains("menu")) return "menu";
            if (input.Contains("exit")) return "exit";
            if (input.Contains("how are you")) return "howareyou";
            if (input.Contains("what is your purpose")) return "purpose";
            if (input.Contains("what can i ask you about?")) return "whatcaniask";
            if (input.Contains("password")) return "password";
            if (input.Contains("phishing")) return "phishing";
            if (input.Contains("safe browsing")) return "safebrowsing";
            if (input.Contains("two factor") || input.Contains("two-factor")
            || input.Contains("double verification") || input.Contains("authentication")
            || input.Contains("verification code")) return "2fa";
            if (input.Contains("malware") || input.Contains("virus")
            || input.Contains("trojan") || input.Contains("spyware")) return "malware";
            if (input.Contains("ransomware") || input.Contains("ransom")) return "ransomware";
            if (input.Contains("firewall")) return "firewall";
            if (input.Contains("virtual private network") || input.Contains("vpn")
            || input.Contains("private network")) return "vpn";
            if (input.Contains("social engineering") || input.Contains("manipulation")
            || input.Contains("pretexting")) return "socialengineering";
            if (input.Contains("data breach") || input.Contains("data leak")
            || input.Contains("information leaked")) return "databreach";
            if (input.Contains("encryption") || input.Contains("encrypted")
            || input.Contains("scramble")) return "encryption";

            // No matching topic was found, return unknown so the default case handles it
            return "unknown";
        }

        // The main chat loop - keeps the conversation going until the user types 'exit'
        // Reads input, identifies the topic, and displays the matching response
        public void StartChat(string name)
        {
            // Loop runs continuously so the user can ask multiple questions in one session
            while (true)
            {
                try
                {
                    // Prompt the user to type their question or topic
                    Console.Write("\nYou: ");
                    string input = Console.ReadLine();

                    // If ReadLine returns null it means the input stream closed unexpectedly
                    if (input == null)
                    {
                        throw new InvalidOperationException("Input stream closed unexpectedly.");
                    }

                    // Convert to lowercase so the comparison works regardless of how the user typed it
                    input = input.ToLower();

                    // Reject blank input and ask the user to try again
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a valid question.");
                        continue;
                    }

                    // Pass input to GetTopic and use the returned keyword to select the correct response
                    switch (GetTopic(input))
                    {

                        // Shows the topic list when the user asks for the menu
                        case "menu":
                            ShowMenu();
                            break;

                        // Responds when the user asks how the chatbot is doing
                        case "howareyou":
                            Console.Write("\nChatBot: ");
                            TypeWrite("I am running smoothly and ready to help you stay safe online!");
                            ShowMenuPrompt(name);
                            break;

                        // Explains what the chatbot was built to do
                        case "purpose":
                            Console.Write("\nChatBot: ");
                            TypeWrite("I am designed to help you learn about how to stay safe online as well as answer your questions on new terms.");
                            ShowMenuPrompt(name);
                            break;

                        // Lists all the topics the user can ask about
                        case "whatcaniask":
                            Console.Write("\nChatBot: ");
                            TypeWrite("You can ask me questions on anything about online security specifically on passwords, phishing, malware, ransomware, firewall, VPN, social engineering, data breach, encryption.");
                            ShowMenuPrompt(name);
                            break;

                        // Explains what a password is and shows a weak vs strong example
                        case "password":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("             PASSWORDS");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            TypeWrite("\nWhat is a password?");
                            TypeWrite("  A password is a secret word or combination of letters, numbers,");
                            TypeWrite("  and symbols that only you know. You use it to prove who you are");
                            TypeWrite("  when logging in to websites, apps, or devices.");
                            TypeWrite("\nExample:");
                            TypeWrite("  Weak password   : password123");
                            TypeWrite("  Strong password : $uN#8kPz!mQ2@");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains what phishing is and gives a real-world email scam example
                        case "phishing":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("              PHISHING");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is phishing?");
                            TypeWrite("  Phishing is when a criminal pretends to be someone you trust, like your bank, a delivery company, or even a friend, in order");
                            TypeWrite("  to trick you into giving away your personal information such as");
                            TypeWrite("  your password, credit card number, or identity number.");
                            TypeWrite("  It usually happens through fake emails, messages, or websites.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You receive an email that looks exactly like it is from your bank.");
                            TypeWrite("  It says: 'Your account has been locked. Click here to verify your details.'");
                            TypeWrite("  You click the link and it takes you to a fake website that looks real.");
                            TypeWrite("  When you type your password, the criminals capture it.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains safe browsing habits and warns about fake prize pop-ups
                        case "safebrowsing":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("           SAFE BROWSING");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is safe browsing?");
                            TypeWrite("  Safe browsing means being careful about which websites you visit");
                            TypeWrite("  and what you click on while using the internet.");
                            TypeWrite("  It helps protect your device and personal information from criminals.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You see a pop-up message that says: 'Congratulations! You have won");
                            TypeWrite("  an iPhone! Click here to claim your prize.'");
                            TypeWrite("  If you click it, harmful software could be installed on your device,");
                            TypeWrite("  or you could be taken to a site that steals your information.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains two factor authentication and how the second login step works
                        case "2fa":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("     TWO FACTOR AUTHENTICATION");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is two factor authentication?");
                            TypeWrite("  Two factor authentication is an extra security step when logging in.");
                            TypeWrite("  Instead of just entering your password, you also need to prove");
                            TypeWrite("  your identity a second time, usually with a code sent to your phone.");
                            TypeWrite("  Think of it like a door that needs two different keys to open.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You log in to your email using your password.");
                            TypeWrite("  The website then sends a 6 digit code to your phone via text message.");
                            TypeWrite("  You type in that code and only then are you allowed in.");
                            TypeWrite("  Even if someone stole your password, they cannot log in without your phone.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains what malware is and covers viruses, trojans, and spyware
                        case "malware":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("               MALWARE");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is malware?");
                            TypeWrite("  Malware means malicious software. It is any program or file");
                            TypeWrite("  that is designed to harm your device, steal your information,");
                            TypeWrite("  or give a criminal control over your computer.");
                            TypeWrite("  Common types include viruses, trojans, and spyware.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You download what looks like a free game from an untrusted website.");
                            TypeWrite("  Hidden inside the game is a trojan that silently records every");
                            TypeWrite("  key you press on your keyboard, including your passwords,");
                            TypeWrite("  and sends that information to a criminal.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains ransomware and how it locks files and demands payment
                        case "ransomware":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("             RANSOMWARE");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is ransomware?");
                            TypeWrite("  Ransomware is a type of harmful software that locks all the files");
                            TypeWrite("  on your device so you cannot open them. The criminal then demands");
                            TypeWrite("  that you pay money to get your files back.");
                            TypeWrite("  It is similar to someone locking your house and demanding payment");
                            TypeWrite("  before giving you the key.");
                            TypeWrite("\nExample:");
                            TypeWrite("  An employee at a company opens an email attachment.");
                            TypeWrite("  Ransomware spreads across the company's computers and locks every file.");
                            TypeWrite("  A message appears on screen saying: 'Pay money or lose everything.'");
                            TypeWrite("  The company is forced to shut down for days.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains what a firewall does and how it blocks suspicious connections
                        case "firewall":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("               FIREWALL");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is a firewall?");
                            TypeWrite("  A firewall is a security guard for your device or network.");
                            TypeWrite("  It watches all the information coming in and going out,");
                            TypeWrite("  and blocks anything that looks suspicious or dangerous.");
                            TypeWrite("  Think of it like a security guard at the entrance of a building");
                            TypeWrite("  who checks everyone before letting them in.");
                            TypeWrite("\nExample:");
                            TypeWrite("  A criminal tries to connect to your computer directly over the internet.");
                            TypeWrite("  Your firewall detects that this connection was not requested by you");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains what a VPN is and why it protects you on public networks
                        case "vpn":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("      VIRTUAL PRIVATE NETWORK");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is a Virtual Private Network?");
                            TypeWrite("  A Virtual Private Network is a tool that creates a secure,");
                            TypeWrite("  private tunnel for your internet connection.");
                            TypeWrite("  It hides your online activity and makes it much harder for");
                            TypeWrite("  anyone to spy on what you are doing online.");
                            TypeWrite("  Think of it like sending a letter in a locked box instead of");
                            TypeWrite("  an open envelope that anyone can read.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You connect to the free internet at a coffee shop.");
                            TypeWrite("  Without a Virtual Private Network, someone nearby on the same");
                            TypeWrite("  connection could see your emails and login details.");
                            TypeWrite("  With a Virtual Private Network switched on, all your data is");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains social engineering and how criminals manipulate people instead of systems
                        case "socialengineering":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("          SOCIAL ENGINEERING");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is social engineering?");
                            TypeWrite("  Social engineering is when a criminal uses tricks and manipulation");
                            TypeWrite("  to convince you to hand over private information or do something");
                            TypeWrite("  that puts your security at risk.");
                            TypeWrite("  Instead of hacking technology, they hack people.");
                            TypeWrite("\nExample:");
                            TypeWrite("  You receive a phone call from someone claiming to be from your bank.");
                            TypeWrite("  They say there is an urgent problem with your account and they need");
                            TypeWrite("  you to confirm your password to fix it immediately.");
                            TypeWrite("  They sound professional and friendly, so you trust them.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains what a data breach is and how stolen information spreads online
                        case "databreach":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("             DATA BREACH");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is a data breach?");
                            TypeWrite("  A data breach happens when a criminal breaks into a company's");
                            TypeWrite("  computer systems and steals personal information about customers.");
                            TypeWrite("  This stolen information can include email addresses, passwords,");
                            TypeWrite("  identity numbers, phone numbers, and banking details.");
                            TypeWrite("\nExample:");
                            TypeWrite("  A popular online shopping website gets hacked.");
                            TypeWrite("  The criminals steal the email addresses and passwords of");
                            TypeWrite("  50 million customers and publish them online for other criminals to use.");
                            TypeWrite("  If you used the same password on other sites, those accounts are now at risk.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Explains encryption and how it scrambles data to keep it safe during transfer
                        case "encryption":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nChatBot: ");
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("              ENCRYPTION");
                            Console.WriteLine("========================================");
                            Console.ResetColor();
                            TypeWrite("\nWhat is encryption?");
                            TypeWrite("  Encryption is the process of scrambling information so that only");
                            TypeWrite("  the intended person can read it.");
                            TypeWrite("  When data is encrypted, it looks like a completely random jumble");
                            TypeWrite("  of characters to anyone who does not have the special key to unlock it.");
                            TypeWrite("  Think of it like writing a secret message in a code that only");
                            TypeWrite("  you and the receiver know how to decode.");
                            TypeWrite("\nExample:");
                            TypeWrite("  When you log in to your bank's website, your password is scrambled");
                            TypeWrite("  before it is sent over the internet.");
                            TypeWrite("  If a criminal managed to intercept it along the way,");
                            TypeWrite("  all they would see is a random jumble of characters");
                            TypeWrite("  which is completely useless to them.");
                            ShowMenuPrompt(name);
                            Console.ResetColor();
                            break;

                        // Ends the chat session and says goodbye to the user by name
                        case "exit":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nGoodbye {name}! Stay safe online.");
                            Console.ResetColor();
                            return;

                        // Runs when the user types something the chatbot does not recognise
                        default:
                            Console.WriteLine("\nI did not quite understand that. Could you try rephrasing?");
                            Console.WriteLine("Type 'menu' to see all topics, or 'exit' to leave.");
                            break;

                    }
                }
                catch (InvalidOperationException ioe)
                {
                    // Handles the case where the input stream closes before the user types anything
                    Console.WriteLine($"[Error] {ioe.Message}");
                    break;
                }
                catch (Exception ex)
                {
                    // Catches any other unexpected error, prints it, and lets the user keep chatting
                    Console.WriteLine($"[Unexpected Error] {ex.Message}");
                    Console.WriteLine("Please try again or type 'exit' to leave.");
                }
            }
        }
    }
}