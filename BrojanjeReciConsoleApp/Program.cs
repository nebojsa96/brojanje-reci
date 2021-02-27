using System;
using System.Collections.Generic;
using BrojanjeReciConsoleApp.Services;

namespace BrojanjeReciConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TextReaderType> readerTypeNames = TextReaderFactory.GetAvailableTextReaders();
  
            // Choosing option for reading text
            Console.WriteLine("Enter the number of text reader type:");
            readerTypeNames.ForEach(type => Console.WriteLine($"[{(int)type}]  {type}"));
            Console.Write("Choose: ");
            TextReaderType type = (TextReaderType)int.Parse(Console.ReadLine());
            
            // Creating proper text reader instance
            ITextReader textReader = TextReaderFactory.CreateTextReader(type);
           
            // Reading text
            string text = textReader.ReadText();
            Console.WriteLine("\nINPUT TEXT:");
            Console.WriteLine(text);


            // Calling text processing API
            int words = TextRestService.CountWordsAsync(text).GetAwaiter().GetResult();
            Console.WriteLine($"\nNUMBER OF WORDS: {words}");


            Console.ReadLine();
        }
    }
}
