namespace object_oriented_analysis_design_assignment.Interfaces
{
    public class IArticlesRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; } 
        public bool IsPublished { get; set; } public bool IsDeleted { get; set; }
        public string Author { get; set; } = null!;
        public string Header { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
