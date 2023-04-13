using object_oriented_analysis_design_assignment.Interfaces;


namespace object_oriented_analysis_design_assignment.Models.BaseModels
{
    public class Articles : IArticles
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public string Author { get; set; } = null!;
        public string Header { get; set; } = null!;
        public string TextBox { get; set; } = null!;
        public string TextBlock { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
