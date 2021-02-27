

namespace BrojanjeReciConsoleApp
{
    class FileTextReader : ITextReader
    {   
        private string _filePath;

        public FileTextReader(string fpath = null)
        {
            if(fpath != null) { 
                _filePath = fpath;
            }
            else
            {
                _filePath = AppSettings.INPUT_FILE_PATH;
            }
        }

        public string ReadText()
        {
            string text = System.IO.File.ReadAllText(_filePath);
            return text;
        }
    }
}
