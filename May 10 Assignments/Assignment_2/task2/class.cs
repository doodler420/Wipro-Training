using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ChatBot
    {
        public void string Respond(string greeting)
        {
            return $"Hello! You said: {greeting}";
        }

        public string Respond(string question, bool formal)
        {
            return formal ? $"Regarding: {question}" :
                              $"Hey! Here's something about: {question}";
        }

        public string Respond(int number)
        {
            return $"You entered {number}";
        }
    }
}
