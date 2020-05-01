using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PositiveReminder
{
    public class MessageHolder
    {
        public static List<string> messages;
        public static void Start()
        {
            messages = new List<string>();
            string[] lines = File.ReadAllLines("Messages.txt");

            foreach (string line in lines)
                messages.Add(line);
            
         /*   messages.Add("You are Appreciated");
            messages.Add("You are popular");
            messages.Add("You are awesome");
            messages.Add("You are useful");*/
        }

        public static string GetRandomMessage()
        {
            int random = RandomNumber(0, messages.Count);
            return messages[random];
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
