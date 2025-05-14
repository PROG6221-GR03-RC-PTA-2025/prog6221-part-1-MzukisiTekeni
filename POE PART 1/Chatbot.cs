using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1
{
    internal class Chatbot
    {
        public string Name { get; set; }
        public Dictionary<string, string> ChatbotResponses;

        public Chatbot(string Name)
        {
            this.Name = Name;
            ChatbotResponses = new Dictionary<string, string>{
                {"what is your purpose","My purpose is to spread cybersecurity awarennes" },
                {"thanks" ,"You're welcome! have a great day"},
                {"what is password safety",
                    "Password Safety refers to the precautions taken to keep passwords and the systems they safeguard safe from compromise or unwanted access" }
            };
        }
        public string Respond(string UserMessage, User newUser)
        {
            if (string.IsNullOrWhiteSpace(UserMessage))//validating empty space
                return "I didn't catch that. could you repeat?";

            UserMessage = UserMessage.ToLower();

            if (UserMessage.Contains("hello") || UserMessage.Contains("hi"))
            {
                return "Hello! " + newUser.Name + " How can i assist you today?";
            }
            else if (UserMessage.Contains("how are you"))
            {
                return "I'm just a bot " + newUser.Name + ", but i'm doing great! what about you?";
            }
            else if (UserMessage.Contains("fine") || UserMessage.Contains("good") || UserMessage.Contains("okay"))
            {
                return "That's good, How can i assist you today? ";
            }
            else if (ChatbotResponses.TryGetValue(UserMessage, out string response))
            {
                return response;
            }
            else
            {
                return "i don't think i understand, could you please paraphrase?";
            }
        }
    }
}
