using object_oriented_analysis_design_assignment.Interfaces;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Models.Dtos
{
    public class ArticlesResponse : Articles
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public string Author { get; set; } = null!;
    }
}
