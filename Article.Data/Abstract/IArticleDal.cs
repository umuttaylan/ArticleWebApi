using Article.Data.Entities;
using Movie.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.Abstract
{
    public interface IArticleDal :  IEntityRepository<ArticleModel>
    {
    }
}
