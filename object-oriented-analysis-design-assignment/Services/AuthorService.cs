using object_oriented_analysis_design_assignment.Models;

namespace object_oriented_analysis_design_assignment.Services;

public class AuthorService
{
    private List<AuthorEntity> _authors;

    public AuthorService()
    {
        _authors = new List<AuthorEntity>();

        _authors.Add(new AuthorEntity { Id = 1, Name = "Hans Mattin-Lassei ", Email = "hans@domain.com", Biography = "Hans Mattin-Lassei är en bästsäljande författare!" });
        _authors.Add(new AuthorEntity { Id = 2, Name = "Tommy Mattin-Lassei", Email = "tommy@example.com", Biography = "Tommy Mattin-Lassei är en prisvinnande författare!" });
    }

    public IEnumerable<AuthorEntity> GetAllAuthors()
    {
        return _authors;
    }

    public AuthorEntity GetAuthorById(int id)
    {
        return _authors.FirstOrDefault(a => a.Id == id);
    }

    public void AddAuthor(AuthorEntity author)
    {
        author.Id = _authors.Max(a => a.Id) + 1;
        _authors.Add(author);
    }

    public void UpdateAuthor(int id, AuthorEntity author)
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

