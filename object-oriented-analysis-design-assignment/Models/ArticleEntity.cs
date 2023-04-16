using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using object_oriented_analysis_design_assignment.Models.Entities;
using object_oriented_analysis_design_assignment.Models.Dtos;

namespace object_oriented_analysis_design_assignment.Models
{
    public class ArticleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;
        public static implicit operator ArticleModel(ArticleEntity entity)
        {
            return new ArticleModel
            {
                Id = entity.Id,
                ArticleNumber = entity.ArticleNumber,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CategoryName = entity.Category.CategoryName
            };
        }

        public string Title { get; set; } = null!;

        public string Body { get; set; } = null!;

        public DateTime Published { get; set; }

        public bool IsPublished { get; set; }

        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Content { get; internal set; }
        public DateTime PublishedDate { get; internal set; }
        public int AuthorId { get; internal set; }
    }
}
