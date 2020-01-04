using Microsoft.AspNetCore.Mvc;
using SimpleNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNews.Controllers
{
    [Route("api")]
    public class RESTController:Controller
    {
        private INewsRepository repository;
        public RESTController(INewsRepository repo)
            => repository = repo;

        [HttpGet("{tag}")]
        public List<News> Get(string tag)
            => repository.GetNews(tags: tag).OrderByDescending(n => n.DatePublished).ToList();

        [HttpGet]
        public List<News> Get()
            => repository.GetNews().OrderByDescending(n => n.DatePublished).ToList();
    }
}
