using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;

namespace SimpleNews.Models
{
    public class EFNewsRepository : INewsRepository
    {

        private NewsDbContext db;
        public EFNewsRepository(NewsDbContext ctx)
            => db = ctx;

        public void AddNews(List<News> news)
        {
            var wasAdded = 0;
            for (int i = 0; i < news.Count; i++)
                if (db.NewsTable.Where(n => n.SourceUrl == news[i].SourceUrl).Select(n => n).FirstOrDefault() == null) {
                    db.NewsTable.Add(news[i]);
                    wasAdded++;
                }
            db.SaveChanges();
        }

        public async Task AddNewsAsync(List<News> news)
            => await Task.Run(() => AddNews(news));

        public IQueryable<News> GetNews(string title = "", string tags = "")
            => from i in db.NewsTable.AsNoTracking() where i.Title.Contains(title) && i.Tags.Contains(tags) select i;

        public News GetNewsById(int id)
            => db.NewsTable.Find(id);
        
    }
}
