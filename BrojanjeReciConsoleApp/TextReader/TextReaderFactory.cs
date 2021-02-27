using System;
using System.Collections.Generic;
using System.Text;

namespace BrojanjeReciConsoleApp
{
    public enum TextReaderType
    {
        CONSOLE,
        FILE,
        DATABASE
    }
    class TextReaderFactory
    {
        private static List<TextReaderType> readerTypeNames = new List<TextReaderType>() {
                TextReaderType.CONSOLE,
                TextReaderType.FILE,
                TextReaderType.DATABASE
        };
        public static ITextReader CreateTextReader(TextReaderType type)
        {
            switch(type)
            {
                case TextReaderType.CONSOLE:
                    return new ConsoleTextReader();
                case TextReaderType.FILE:
                    return new FileTextReader();
                case TextReaderType.DATABASE:
                    return new DbTextReader();
                default:
                    return null;
            }
        }

        public static List<TextReaderType> GetAvailableTextReaders()
        {
            return readerTypeNames;
        }
    }
}
