using System.Collections.Generic;
using kingpin.Models;

namespace kingpin.Repository {
    public class ArticleRepoImpl : IArticleRepo
    {
        public void DeleteArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Article GetArticleById(int Id)
        {
            return new Article{Id=0, Date="12/12/20", Header= "Hi", BannerPictureUrl= "http://", MainArticleString= "Good", Opinion= "Opinion"};
        }

        public IEnumerable<Article> GetArticles()
        {
            var articles = new List<Article>{
                new Article{Id=0, Date="12/12/20", Header= "Hi", BannerPictureUrl= "http://", MainArticleString= "Good", Opinion= "Opinion"},
                new Article{Id=0, Date="12/12/20", Header= "Hi", BannerPictureUrl= "http://", MainArticleString= "Good", Opinion= "Opinion"},
                new Article{Id=0, Date="12/12/20", Header= "Hi", BannerPictureUrl= "http://", MainArticleString= "Good", Opinion= "Opinion"},
                new Article{Id=0, Date="12/12/20", Header= "Hi", BannerPictureUrl= "http://", MainArticleString= "Good", Opinion= "Opinion"}
            };
            return articles;
        }

        public void InsertArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateArticle(Article article)
        {
            throw new System.NotImplementedException();
        }
    }
}