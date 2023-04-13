namespace object_oriented_analysis_design_assignment.Interfaces
{
    public class IArticlesResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public string Author { get; set; } = null!;

        internal static object Create()
        {
            throw new NotImplementedException();
        }
    }
}
