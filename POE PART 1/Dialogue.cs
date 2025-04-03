using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Figgle;

namespace POE_PART_1
{
    internal class Dialogue
    {
        private User user;
        private Chatbot chatbot;

        public Dialogue(User user, Chatbot chatbot)
        {
            this.user = user;
            this.chatbot = chatbot;
        }

        public void StartChat()
        {
            Console.WriteLine(FiggleFonts.Small.Render("Hello " + user.Name + " Welcome to the chatbot"));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CHAT STARTED........");
            Console.WriteLine("Type exit to end the chat!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.White;
                string userMessage = Console.ReadLine();
                Regex.Replace(userMessage, @"[?]", "");
                if (userMessage.ToLower().Equals("exit") || userMessage.ToLower().Contains("bye") ||
                    userMessage.ToLower().Contains("goodbye"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(chatbot.Name + ": ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Goodbye, " + user.Name);

                    break;
                }
                string response = chatbot.Respond(userMessage, user);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(chatbot.Name + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(response);
            }
        }

        public void EndChat()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CHAT ENDED........");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
