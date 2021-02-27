using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrojanjeReciConsoleApp.Repository
{
    public class TextMysqlRepository: BaseRepository<Text, TextMysqlContext>, ITextRepository
    {
        public TextMysqlRepository(TextMysqlContext context): base(context)
        {

        }

        public string GetFirstRowText()
        {
            return GetByID(1).TextInput;
        }
    }
}
