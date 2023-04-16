using object_oriented_analysis_design_assignment.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace object_oriented_analysis_design_assignment.Models.Entities;
public class CategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public ICollection<ArticleEntity> Articles { get; set; } = new List<ArticleEntity>();

    public static implicit operator CategoryModel(CategoryEntity entity)
    {
        return new CategoryModel
        {
            Id = entity.Id,
            CategoryName = entity.CategoryName
        };
    }
}
