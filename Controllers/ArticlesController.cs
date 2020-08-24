using System.Collections.Generic;
using AutoMapper;
using kingpin.DTO;
using kingpin.Models;
using kingpin.Repository;
using kingpin.Security;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace kingpin.Controllers{
    //api/articles
    [Route("api/articles")]
    [ApiController]
    [ApikeySecurityCheck]
    public class ArticlesController:ControllerBase{
        private readonly IArticleRepo _articleRepo;
        private readonly IMapper _mapper;
        public ArticlesController(IArticleRepo articleRepo, IMapper mapper)
        {
            _articleRepo = articleRepo;
            _mapper = mapper;
        }
        
        //GET api/articles
        [HttpGet]
        public ActionResult <IEnumerable<ArticleReadDto>> getArticles() {
            var articles = _articleRepo.GetArticles();
            return Ok(_mapper.Map<IEnumerable<ArticleReadDto>>(articles));
        }

        //GET api/articles/5
        [HttpGet("{id}")]
        public ActionResult<ArticleReadDto> getArticleById(int id) {
            var articleItem = _articleRepo.GetArticleById(id);
            if (articleItem != null) {
                return Ok(_mapper.Map<ArticleReadDto>(articleItem));
            }
            else return NotFound();
        }

        //POST api/articles
        [HttpPost]
        public ActionResult<ArticleReadDto> insertArticle(ArticleInsertDto articleInsertDto)
        {
            var article = _mapper.Map<Article>(articleInsertDto);
            _articleRepo.InsertArticle(article);
            _articleRepo.SaveChanges();
            var articleReadDto = _mapper.Map<ArticleReadDto>(article);

            return Ok(articleReadDto);
        }

        //PUT api/articles/5
        [HttpPut("{id}")]
        public ActionResult updateArticle(int id, ArticleUpdateDto articleUpdateDto) 
        {
            var article = _articleRepo.GetArticleById(id);
            if (article == null) {
                return NotFound();
            }
            var articleMapped = _mapper.Map(articleUpdateDto, article);
            _articleRepo.UpdateArticle(article);
            _articleRepo.SaveChanges();
            return NoContent();
        }

        //PATCH api/articles/5
        [HttpPatch("{id}")]
        public ActionResult PartialArticleUpdate(int id, JsonPatchDocument<ArticleUpdateDto> patchDoc)
        {
            var articleRepo = _articleRepo.GetArticleById(id);
            if (articleRepo == null) 
            {
                return NotFound();
            }
            var articleMapped = _mapper.Map<ArticleUpdateDto>(articleRepo);
            patchDoc.ApplyTo(articleMapped, ModelState);
            if(!TryValidateModel(articleMapped))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(articleMapped, articleRepo);
            _articleRepo.UpdateArticle(articleRepo);
            _articleRepo.SaveChanges();
            return NoContent();
        }

        //DELETE api/article/5
        [HttpDelete]
        public ActionResult deleteArticle(int id)
        {
            var article = _articleRepo.GetArticleById(id);
            if (article == null) 
            {
                return NotFound();
            }
            _articleRepo.DeleteArticle(article);
            _articleRepo.SaveChanges();
            return NoContent();
        }
    }
}