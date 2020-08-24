using AutoMapper;
using kingpin.DTO;
using kingpin.Models;

namespace kingpin.Profiles
{
    public class ArticlesProfile: Profile
    {
        public ArticlesProfile() {
            CreateMap<Article, ArticleReadDto>();
            CreateMap<ArticleInsertDto, Article>();
            CreateMap<ArticleUpdateDto, Article>();
            CreateMap<Article, ArticleUpdateDto>();
        }
    }
}