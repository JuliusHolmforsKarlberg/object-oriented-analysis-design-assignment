using object_oriented_analysis_design_assignment.Models.BaseModels;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Models.Entities;


namespace object_oriented_analysis_design_assignment.Interfaces
{
    public class IArticles
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public string Author { get; set; } = null!;
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}