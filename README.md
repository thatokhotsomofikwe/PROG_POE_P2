# PROG_POE_P2
WPF-based chatbot application built in C# that helps users learn about cybersecurity in an interactive way. It simulates a conversational assistant that provides advice on topics such as passwords, scams, privacy, phishing, and safe browsing. The chatbot uses keyword recognition, sentiment detection, memory, and randomised responses to create a natural conversation experience.

Chatbot Intelligence
The chatbot recognises cybersecurity-related keywords such as password, scam, privacy, phishing, and safe browsing. It responds with relevant advice and can handle follow-up questions like “tell me more” or “give me another tip”. It also supports yes/no responses to keep conversations flowing naturally.

Sentiment Detection
The chatbot detects user emotions including worried, frustrated, sad, happy, and curious. It adjusts responses to be more supportive or encouraging based on the detected sentiment.

Memory Feature
The chatbot remembers the user’s name and their favourite cybersecurity topic. It uses this information later in the conversation to personalise responses.

Random Response System
For topics like phishing and scams, the chatbot selects responses randomly from a predefined list. This prevents repetition and makes conversations feel more natural.

Multimedia Features
The application supports an ASCII art logo and a voice greeting. These files are loaded from an Assets folder:

logo.jpg
greet.wav

WPF User Interface
The interface is designed with WPF and includes a clean chat layout, colour-coded messages, a scrollable chat area, and an input box with a send button. The design is intended to be user-friendly and easy to navigate.

Project Structure
PROG_P2

Assets folder (logo.jpg, greet.wav)
MainWindow.xaml
MainWindow.xaml.cs
ConversationManager.cs
ResponseBank.cs
SentimentService.cs
ChatMessage.cs
README file

How to Run the Project

1. Open the solution file PROG_P2.csproj in Visual Studio
2. Ensure the Assets folder contains logo.jpg and greet.wav
3. Build the solution
4. Run the application using Start (F5)

Example Interactions

User: Tell me about password safety
Bot: Use strong, unique passwords for each account and avoid personal details.

User: I’m worried about scams
Bot: It’s completely understandable to feel that way. Scammers can be very convincing.

User: Thanks
Bot: You’re welcome! Would you like another cybersecurity tip?

Error Handling
The chatbot handles empty or unrecognised input by responding with a default message asking the user to rephrase. It is designed to prevent crashes and maintain smooth conversation flow.
YouTube Unlisted Link:
https://youtube.com/shorts/hLW25mopRms?si=TVJk7oRh5-_2UB7a
