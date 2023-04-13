using object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Models.Dtos
{
    public class ArticlesRequest
    {
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Password { get; set; } = null!;


        public static implicit operator ArticlesEntity(ArticlesRequest articlesRequest)
        {
            var entity = ArticlesFactory.ArticleEntityFactory();
            return entity;
        }
    }
}
