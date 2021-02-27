using System;

namespace BrojanjeReciConsoleApp
{
    class ConsoleTextReader : ITextReader
    {
        public ConsoleTextReader()
        {
        }

        public string ReadText()
        {
            Console.WriteLine("\nEnter text:");
            string text = Console.ReadLine();
            return text;
        }
    }
}
