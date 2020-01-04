using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleNews.Models.ParserSite
{
    public static class ParserRiaNews
    {
        private static string url { get; set; } = @"https://ria.ru/";
        private static Dictionary<string, string> tags { get; set; } = new Dictionary<string, string>();
        static ParserRiaNews()
        {
            tags.Add("world", "Мир");
            tags.Add("politics", "Политика");
            tags.Add("economy", "Экономика");
            tags.Add("society", "Общество");
            tags.Add("defense_safety", "Армия");
        }
        public static async Task<List<News>> Parse()
        {
            var allNews = new List<News>();
            var html = new HtmlDocument();
            HtmlNode listNews;
            var stringHtml = "";

            using (var httpClient = new HttpClient())
            {
                foreach (var tag in tags)
                {
                    stringHtml = await httpClient.GetStringAsync(url + tag.Key);
                    html.LoadHtml(stringHtml);
                    listNews = html.DocumentNode.Descendants("div")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Contains("list list-tags"))
                            .FirstOrDefault();
                    foreach (var item in listNews.Descendants("div").Where(node => node.GetAttributeValue("class", "").Contains("list-item")))
                    {
                        try
                        {
                            allNews.Add(new News()
                            {
                                Title = item.Descendants("a").Where(a => a.GetAttributeValue("class", "").Contains("list-item__title")).FirstOrDefault().InnerText,
                                DatePublished = DateTime.Parse(item.Descendants("div").Where(a => a.GetAttributeValue("class", "").Contains("list-item__date")).FirstOrDefault().InnerText),
                                SourceName = "ria.ru",
                                SourceUrl = item.Descendants("a").Where(a => a.GetAttributeValue("class", "").Contains("list-item__title")).FirstOrDefault().GetAttributeValue("href", ""),
                                Tags = tag.Value
                            });
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }


            return allNews;
        }
        public static List<string> ParseOneRiaNews(string url)
        {
            var text = new List<string>();
            var html = new HtmlDocument();
            using(var httpClient = new HttpClient())
            {
                var stringHtml = httpClient.GetStringAsync(url).Result;
                html.LoadHtml(stringHtml);
                var articles = from i in html.DocumentNode.Descendants("div") where i.GetAttributeValue("class", "").Contains("article__block") select i;
                foreach (var item in articles.Where(n=>n.GetAttributeValue("data-type", "").Contains("text") || n.GetAttributeValue("data-type", "").Contains("h3")))
                    text.Add(item.InnerText);
            }
            return text;
        }
    }
}