using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNews.Models
{
    public interface INewsRepository
    {
        IQueryable<News> GetNews(string title = "", string tags = "");
        News GetNewsById(int id);
        void AddNews(List<News> news);
        Task AddNewsAsync(List<News> news);

    }
}
