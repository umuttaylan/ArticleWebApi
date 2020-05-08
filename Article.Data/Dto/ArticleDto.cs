using Article.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Dto
{
    public class ArticleDto
    {
        public string name { get; set; }

        public string content { get; set; }

        public string authorName { get; set; }

        public DateTime date { get; set; }
    }
}
