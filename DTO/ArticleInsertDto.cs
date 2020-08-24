using System.ComponentModel.DataAnnotations;

namespace kingpin.DTO
{
    public class ArticleInsertDto 
    {
        [Required]
        public string Date { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string BannerPictureUrl { get; set; }
        [Required]
        public string MainArticleString { get; set; }
        [Required]
        public string Opinion { get; set; }
        [Required]
        public string NotForUserFacing { get; set; }
    }
}