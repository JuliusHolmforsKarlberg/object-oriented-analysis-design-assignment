using Microsoft.AspNetCore.Mvc;
using object_oriented_analysis_design_assignment.Contexts;
using object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Services;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ArticlesController : Controller
    {
        private readonly ArticleService _articles;

        public ArticlesController(ArticleService articles)
        {
            _articles = articles;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _articles.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleRegistrationModel model)
        {
            await _articles.CreateAsync(model);
            return NoContent();
        }
    }
}
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticlesController(DataContext context)
        {
            _articleService = new ArticleService(context);
        }

        [HttpPost]

        public IActionResult CreateArticle(ArticleRequest request)
        {
            var result = ArticleService.Create(request);

            if (result == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetArticle), new { result = request.Id }, result);
        }

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var result = ArticleService.Get(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var result = _articleService.GetAll();

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateArticle(int id, ArticleRequest request)
        {
            var result = _articleService.Update(id, request);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var result = _articleService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
