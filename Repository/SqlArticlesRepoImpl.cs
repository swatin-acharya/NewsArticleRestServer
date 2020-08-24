using System;
using System.Collections.Generic;
using System.Linq;
using kingpin.Models;

namespace kingpin.Repository
{
    public class SqlArticlesRepoImpl : IArticleRepo
    {
        private readonly ArticleContext _context;

        public SqlArticlesRepoImpl(ArticleContext dbContext)
        {
            _context = dbContext;
        }
        public void DeleteArticle(Article article)
        {
            if(article == null) 
            {
                throw new ArgumentNullException();
            }
            _context.Articles.Remove(article);
        }

        public Article GetArticleById(int Id)
        {
            return _context.Articles.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Article> GetArticles()
        {
            return _context.Articles.ToList();
        }

        public void InsertArticle(Article article)
        {
            if(article == null)
            {
                throw new ArgumentNullException();
            }
            _context.Articles.Add(article);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateArticle(Article article)
        {
           //nothing
        }
    }
}