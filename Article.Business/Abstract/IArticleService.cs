using Article.Data.Dto;
using Article.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Business.Abstract
{
    public interface IArticleService
    {
        ResponseViewModel GetArticle(int id);
        ResponseViewModel GetArticleByName(string name);
        ResponseViewModel GetArticleList();
        ResponseViewModel Add(ArticleDto catalogDto);
        ResponseViewModel Update(ArticleDto catalogDto);
        ResponseViewModel Delete(int id);
    }
}
