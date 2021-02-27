using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrojanjeReciWebAPI.Services
{
    public class TextProcessingService: ITextProcessingService
    {
        public TextProcessingService()
        {
        }

        public int CountWords(string text)
        {
            int words = 0;
            int ind = 0;

            while (ind < text.Length && char.IsWhiteSpace(text[ind]))
                ind++;

            while (ind < text.Length)
            {
                while (ind < text.Length && !char.IsWhiteSpace(text[ind]))
                    ind++;
                words++;

                while (ind < text.Length && char.IsWhiteSpace(text[ind]))
                    ind++;
            }

            return words;
        } 
    }
}
