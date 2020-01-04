using Microsoft.AspNetCore.Mvc;
using SimpleNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNews.Components
{
    public class NavMenuViewComponent:ViewComponent
    {
        INewsRepository repository;
        public NavMenuViewComponent(INewsRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
            => View(repository.GetNews().Select(x => x.Tags).Distinct().OrderBy(x => x));
    }
}
