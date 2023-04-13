using object_oriented_analysis_design_assignment.Interfaces;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Models.Entities;
using object_oriented_analysis_design_assignment.Models.BaseModels;

namespace object_oriented_analysis_design_assignment.Factories
{
    public class ArticlesFactory
    {
        public static ArticleEntity CreateUserEntity() => new();
        public static ArticleRequest CreateUserRequest() => new();
        public static ArticleResponse CreateUserResponse() => new();

        internal static object ArticleEntityFactory()
        {
            throw new NotImplementedException();
        }
    }
}
