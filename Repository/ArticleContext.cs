using kingpin.Models;
using Microsoft.EntityFrameworkCore;

namespace kingpin.Repository
{
    public class ArticleContext:DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> opt) : base(opt)
        {
            
        }
        public DbSet<Article> Articles { get; set; }
    }
}