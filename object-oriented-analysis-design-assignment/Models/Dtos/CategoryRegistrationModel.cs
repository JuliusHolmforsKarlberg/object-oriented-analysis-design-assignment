using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Models.Dtos
public class CategoryRegistrationModel
{
    public string CategoryName { get; set; } = null!;

    public static implicit operator CategoryEntity(CategoryRegistrationModel model)
    {
        return new CategoryEntity
        {
            CategoryName = model.CategoryName
        };
    }
}
