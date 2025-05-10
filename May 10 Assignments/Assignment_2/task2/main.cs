using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main()
        {
            ChatBot bot = new ChatBot();
            Console.WriteLine(bot.Respond("Hello"));
            Console.WriteLine(bot.Respond("What’s the weather like?", false));
            Console.WriteLine(bot.Respond(42));
        }
    }
}
