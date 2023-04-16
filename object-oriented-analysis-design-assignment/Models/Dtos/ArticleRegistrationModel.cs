using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Models.Dtos
{
    public class ArticleRegistrationModel
    {
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;

        public static implicit operator ArticleEntity(ArticleRegistrationModel model)
        {
            return new ArticleEntity
            {
                ArticleNumber = model.ArticleNumber,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
            };
        }
        public static implicit operator CategoryEntity(ArticleRegistrationModel model)
        {
            return new CategoryEntity
            {
                CategoryName = model.CategoryName
            };
        }
        public static implicit operator CategoryRegistrationModel(ArticleRegistrationModel model)
        {
            return new CategoryRegistrationModel
            {
                CategoryName = model.CategoryName
            };
        }
    }
}
