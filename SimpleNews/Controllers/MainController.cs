using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleNews.Models;
using SimpleNews.Models.ParserSite;

namespace SimpleNews.Controllers
{
    public class MainController : Controller
    {
        INewsRepository repository { get; set; }
        public MainController(INewsRepository repo)
            => repository = repo;
        
        [Route("{tag}")]
        [Route("")]
        public IActionResult Index(string tag = "", int page = 1)
        {
            var model = repository.GetNews(tags: tag).OrderByDescending(n => n.DatePublished).Take(5);
            return View(model);
        }

        [Route("[action]/{id}")]
        public IActionResult ViewNews(int id)
            => View(ParserNews.ParseOneNews(repository.GetNewsById(id).SourceName, repository.GetNewsById(id).SourceUrl));
    }
}
