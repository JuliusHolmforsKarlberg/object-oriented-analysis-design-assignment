using Microsoft.AspNetCore.Mvc;
using object_oriented_analysis_design_assignment.Models;
using object_oriented_analysis_design_assignment.Services;

namespace object_oriented_analysis_design_assignment.Controllers
{
    public class AuthorsController : ArticlesController
    {
        private AuthorService _authorService;

        public AuthorsController()
        {
            _authorService = new AuthorService();
        }

        public IEnumerable<AuthorEntity> Get()
        {
            return _authorService.GetAllAuthors();
        }

        public AuthorEntity Get(int id)
        {
            return _authorService.GetAuthorById(id);
        }

        public void Post([FromBody] AuthorEntity author)
        {
            _authorService.AddAuthor(author);
        }

        public void Put(int id, [FromBody] AuthorEntity author)
        {
            _authorService.UpdateAuthor(id, author);
        }

        public void Delete(int id)
        {
            _authorService.DeleteAuthor(id);
        }
    }
}
