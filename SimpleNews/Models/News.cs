using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Summary { get; set; }
        public string SourceUrl { get; set; }
        public string SourceName { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
