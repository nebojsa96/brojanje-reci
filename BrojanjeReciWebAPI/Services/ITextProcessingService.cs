using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrojanjeReciWebAPI.Services
{
    public interface ITextProcessingService
    {
        public int CountWords(string text);
    }
}
