using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNews.Models.ParserSite
{
    public class ParserNews
    {

        private static bool IsActive = false;
        private static INewsRepository repository;

        ///<summary>
        ///Key is SourceName from object News, first string is url for parsing
        ///</summary>
        public static Dictionary<string, Func<string, List<string>>> ParserFunctionsForOneNews { get; set; } = new Dictionary<string, Func<string, List<string>>>
        {
            ["ria.ru"] = ParserRiaNews.ParseOneRiaNews
        };

        public async void ParseAllPublishingHouse(DbContextOptionsBuilder options)
        {
            if (!IsActive)
            {
                IsActive = true;
                repository = new EFNewsRepository(new NewsDbContext(options.Options));
                while (true)
                {
                    repository.AddNews(await ParserRiaNews.Parse());
                    await Task.Delay(120000);
                }
            }
        }

        public static List<string> ParseOneNews(string NameOfPress, string UrlOfNews)
            => ParserFunctionsForOneNews[NameOfPress](UrlOfNews);
    }
}
