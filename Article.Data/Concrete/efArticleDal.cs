using Article.Data.Abstract;
using Article.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Movie.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Concrete
{
    public class efArticleDal :  efRepositoryBase<ArticleModel>, IArticleDal
    {
        public efArticleDal(DbContext dbContext): base(dbContext)
        {

        }
    }
}
