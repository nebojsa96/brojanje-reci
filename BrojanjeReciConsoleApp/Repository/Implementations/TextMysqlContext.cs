using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BrojanjeReciConsoleApp.Repository
{
    public class TextMysqlContext: DbContext
    {
        public DbSet<Text> Text { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(AppSettings.MYSQL_CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeder
            modelBuilder.Entity<Text>().HasData(
                new Text {  Id = 1, TextInput = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry." });
        }
    }
}
