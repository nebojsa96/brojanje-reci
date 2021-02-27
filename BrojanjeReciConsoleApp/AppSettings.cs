using BrojanjeReciConsoleApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrojanjeReciConsoleApp
{
    public class AppSettings
    {
        public static readonly string API_SERVER_URL = "http://localhost:5000";
        public static readonly string MYSQL_CONNECTION_STRING = "server=localhost;database=text_db;user=root;password=";
        public static readonly string INPUT_FILE_PATH = @"..\..\..\FileInput.txt";

        private static ServiceProvider _serviceProvider;

        public static ServiceProvider ServiceProvider { get
            {
                return _serviceProvider;
            } 
        }

        static AppSettings()
        {
            _serviceProvider = new ServiceCollection()
                .AddDbContext<TextMysqlContext>()
                .AddSingleton<ITextRepository, TextMysqlRepository>()
                .BuildServiceProvider();
        }
    }
}
