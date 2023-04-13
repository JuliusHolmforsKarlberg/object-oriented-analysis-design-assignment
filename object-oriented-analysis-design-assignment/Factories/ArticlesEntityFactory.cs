using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Factories
{
    public class ArticlesEntityFactory
    {
        public static ArticlesEntity Create() => new ArticlesEntity()
        {
            Id = Guid.NewGuid(),
            SecurityStamp = Guid.NewGuid().ToString()
        };
    }
}
