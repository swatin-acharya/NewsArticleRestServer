using System.Collections.Generic;
using kingpin.Models;

namespace kingpin.Repository{
    public interface IArticleRepo
    {
        IEnumerable<Article> GetArticles();
        Article GetArticleById(int Id);
        void InsertArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(Article article);
        bool SaveChanges();
        
    }
}