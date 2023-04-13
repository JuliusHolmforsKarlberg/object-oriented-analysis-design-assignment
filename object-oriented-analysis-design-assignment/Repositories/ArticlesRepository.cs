using object_oriented_analysis_design_assignment.Contexts;
using object_oriented_analysis_design_assignment.Interfaces;
using object_oriented_analysis_design_assignment.Models;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Repositories
{
    public class ArticlesRepository : Repository<ArticlesEntity>
    {
        public ArticlesRepository(DataContext context) : base(context)
        {
        }

        public override Task<ArticlesEntity> GetAsync()
        {
            throw new NotImplementedException();
        }

        internal Task<IArticlesResponse> CreateAsync(IArticlesRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
