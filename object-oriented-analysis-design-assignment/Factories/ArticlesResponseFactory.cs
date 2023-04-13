using object_oriented_analysis_design_assignment.Models.Dtos;

namespace object_oriented_analysis_design_assignment.Factories
{
    public class ArticlesResponseFactory
    {
        public static ArticlesResponse Create()
        {
            return new ArticlesResponse();
        }
    }
}
