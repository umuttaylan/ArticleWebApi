using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Business.Abstract;
using Article.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost("Add")]
        public IActionResult Add(ArticleDto articleDto)
        {
            var response = _articleService.Add(articleDto);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpPut("Update")]
        public IActionResult Update(ArticleDto articleDto)
        {
            var response = _articleService.Update(articleDto);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var response = _articleService.Delete(id);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }


            return Ok(response);
        }
        [HttpGet("GetArticleById")]
        public IActionResult Get(int id)
        {
            var response = _articleService.GetArticle(id);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpGet("GetArticleByName")]
        public IActionResult GetArticleName(string name)
        {
            var response = _articleService.GetArticleByName(name);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("GetArticles")]
        public IActionResult GetArticles()
        {
            var response = _articleService.GetArticleList();

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}