using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace POE_PART_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer soundPlayer = new SoundPlayer("MzuraVoice.wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();
            Console.WriteLine("Sound finished playing........");

            Console.WriteLine(FiggleFonts.Standard.Render("Cybersecurity Awareness"));

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Chatbot chatbot = new Chatbot("Chatbot");
            Dialogue dialogue = new Dialogue(user, chatbot);
            dialogue.StartChat();
            dialogue.EndChat();
        }
    }
}
