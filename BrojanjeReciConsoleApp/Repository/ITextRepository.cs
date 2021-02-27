using System;
using System.Collections.Generic;
using System.Text;

namespace BrojanjeReciConsoleApp.Repository
{
    public interface ITextRepository: IRepository<Text>
    {
        public string GetFirstRowText();
    }
}
