using Article.Business.Abstract;
using Article.Data.Abstract;
using Article.Data.Dto;
using Article.Data.Entities;
using Article.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Article.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private  IArticleDal _articleDal{ get; set; }

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public ResponseViewModel Add(ArticleDto articleDto)
        {
            var response = new ResponseViewModel();

            var article = ArticleModelMapping(articleDto);

            _articleDal.Add(article);
            var saving = _articleDal.SaveChanges();
            if (!saving)
            {
                response.IsSuccess = false;
                response.Message = "db error while add article";
            }

            return response;
        }

        public ResponseViewModel Delete(int id)
        {
            var response = new ResponseViewModel();

            var entity = _articleDal.Get(p => p.id == id);
            _articleDal.Delete(entity);
            var saving = _articleDal.SaveChanges();

            if (saving)
            {
                response.Message = "Article is deleted : " + id;
            }
            else
            {
                response.Message = "db error while article delete";
                response.IsSuccess = false;
            }

            return response;
        }

        public ResponseViewModel GetArticle(int id)
        {
            var response = new ResponseViewModel();

            var article = _articleDal.Get(x => x.id == id);
            if (article == null)
            {
                response.IsSuccess = false;
                response.Message = "Article Not Found!";
                response.Data = null;
                return response;
            }

            var articleDto = ArticleDtoMapping(article);
            var saving = _articleDal.SaveChanges();

            if (saving)
            {
                response.Data = articleDto;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "db error while article get";
            }

            return response;
        }

       
        public ResponseViewModel GetArticleByName(string name)
        {
            var response = new ResponseViewModel();

            var article = _articleDal.Get(x => x.name == name);
            if (article == null)
            {
                response.IsSuccess = false;
                response.Message = "Article Not Found!";
                response.Data = null;
                return response;
            }

            var articleDto = ArticleDtoMapping(article);

            if (_articleDal.SaveChanges())
            {
                response.Data = articleDto;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "db error while article get";
            }

            return response;
        }

        public ResponseViewModel Update(ArticleDto articleDto)
        {
            var response = new ResponseViewModel();

            var article = ArticleModelMapping(articleDto);

            _articleDal.Update(article);
            var saving = _articleDal.SaveChanges();

            if (!saving)
            {
                response.IsSuccess = false;
                response.Message = "db error while update article";
            }


            return response;
        }
        public ResponseViewModel GetArticleList()
        {
            var response = new ResponseViewModel();

            var articles = _articleDal.GetList();

            if (!articles.Any())
            {
                response.IsSuccess = false;
                response.Message = "Hiç store bulunamadı.";
                return response;
            }

            var articleDtos = new List<ArticleDto>();
            foreach (var item in articles)
            {
                var storeDto = ArticleDtoMapping(item);
                articleDtos.Add(storeDto);
            }

            response.Data = articleDtos;

            return response;
        }

        private ArticleDto ArticleDtoMapping(ArticleModel article)
        {
            var articleDto = new ArticleDto()
            {
                name = article.name,
                authorName = article.author,
                content = article.content,
                date = article.date
            };

            return articleDto;

        }

        private ArticleModel ArticleModelMapping(ArticleDto articleDto)
        {
            var article = new ArticleModel()
            {
                name = articleDto.name,
                author = articleDto.authorName,
                content = articleDto.content,
                date = articleDto.date
            };
            return article;
        }
        
    }
}
