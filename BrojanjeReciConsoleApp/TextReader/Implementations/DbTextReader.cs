

using BrojanjeReciConsoleApp.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BrojanjeReciConsoleApp
{
    class DbTextReader : ITextReader
    {
        private ITextRepository _textRepository;
        public DbTextReader()
        {
            _textRepository = AppSettings.ServiceProvider.GetService<ITextRepository>();
        }

        public string ReadText()
        {
            Text dbRow = _textRepository.GetByID(1);
            return dbRow.TextInput;
        } 
    }
}
