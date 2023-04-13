using object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Interfaces
{
    public class ICreateArticle : ArticleEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Body { get; set; } = null!;

        public DateTime Published { get; set; }

        public bool IsPublished { get; set; }

        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
