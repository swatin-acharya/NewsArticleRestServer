using System.ComponentModel.DataAnnotations;

namespace kingpin.Models{
 
    public class Article {

        [Key]
        public int Id { get; set; }
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