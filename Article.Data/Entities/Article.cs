using Movie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Entities
{
    public class ArticleModel : IEntity
    {
        public int id { get; set; }

        public string name { get; set; }

        public string content { get; set; }

        public string author { get; set; }

        public DateTime date { get; set; }
    }
}
