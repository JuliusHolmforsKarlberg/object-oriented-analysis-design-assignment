using object_oriented_analysis_design_assignment.Models;

namespace object_oriented_analysis_design_assignment.Services;

public class AuthorService
{
    private List<Author> _authors;

    public AuthorService()
    {
        _authors = new List<Author>();

        _authors.Add(new Author { Id = 1, Name = "Hans Mattin-Lassei ", Email = "hans@domain.com", Biography = "Hans Mattin-Lassei är en bästsäljande författare!" });
        _authors.Add(new Author { Id = 2, Name = "Tommy Mattin-Lassei", Email = "tommy@example.com", Biography = "Tommy Mattin-Lassei är en prisvinnande författare!" });
    }

    public IEnumerable<Author> GetAllAuthors()
    {
        return _authors;
    }

    public Author GetAuthorById(int id)
    {
        return _authors.FirstOrDefault(a => a.Id == id);
    }

    public void AddAuthor(Author author)
    {
        author.Id = _authors.Max(a => a.Id) + 1;
        _authors.Add(author);
    }

    public void UpdateAuthor(int id, Author author)
    {
        var existingAuthor = _authors.FirstOrDefault(a => a.Id == id);

        if (existingAuthor != null)
        {
            existingAuthor.Name = author.Name;
            existingAuthor.Email = author.Email;
            existingAuthor.Biography = author.Biography;
        }
    }

    public void DeleteAuthor(int id)
    {
        var existingAuthor = _authors.FirstOrDefault(a => a.Id == id);

        if (existingAuthor != null)
        {
            _authors.Remove(existingAuthor);
        }
    }
}

