# POE-PART1-CHATBOT
# Cybersecurity Awareness Chatbot

A C# console application that functions as a cybersecurity awareness chatbot, allowing users to engage in a simulated conversation about online safety practices.

## Description

This chatbot was developed as Part 1 of the PROG6221 Portfolio of Evidence (POE). It provides users with information on key cybersecurity topics through an interactive console interface. The application features a personalised greeting, coloured console output, ASCII art, and input validation to handle unexpected entries gracefully.

## Features

- ASCII art logo displayed on launch
- Personalised greeting using the user's name
- Responses to cybersecurity topics including:
  - Password safety
  - Phishing awareness
  - Safe browsing
- Input validation for empty or unrecognised inputs
- Coloured console text for improved readability
- Typing effect to simulate a conversational feel
- Clean code structure using multiple classes

## How to Use

1. The chatbot launches and displays the ASCII logo
2. Enter your name when prompted
3. Type any of the following to get a response:
   - `password` - get password safety tips
   - `phishing` - learn about phishing attacks
   - `browsing` or `safe` - get safe browsing advice
   - `how are you` - general conversation
   - `what can I ask` - see available topics
4. Type `exit` to quit the chatbot



## Example Interaction

Bot: Hello! What is your name?
You: Miradi
Bot: Nice to meet you, Miradi! I'm here to help you stay safe online.
Bot: You can ask me about: passwords, phishing, safe browsing.

Miradi: password
Bot: Use strong passwords with a mix of letters, numbers, and symbols.
     Never reuse passwords across different sites.
     Consider using a password manager like Bitwarden or LastPass!

Miradi: exit
Bot: Goodbye, Miradi! Stay safe online!

## Commit History

This project was developed with a minimum of six meaningful commits:

1. `Initial commit: Set up project structure and files`
2. `Added ASCII logo and display class`
3. `Added text greeting and user name input`
4. `Added cybersecurity response system`
5. `Added input validation`
6. `Added enhanced console UI with colours and typing effect`

