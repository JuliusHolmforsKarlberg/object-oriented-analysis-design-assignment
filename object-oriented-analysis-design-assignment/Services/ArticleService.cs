using object_oriented_analysis_design_assignment.Contexts;
using object_oriented_analysis_design_assignment.Models;
using object_oriented_analysis_design_assignment.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using object_oriented_analysis_design_assignment.Models.Entities;

namespace object_oriented_analysis_design_assignment.Services;

public class ArticleService
{
    private List<ArticleEntity> _articles;
    private List<AuthorEntity> _authors;
    private readonly DataContext _context;
    private readonly CategoryService _categories;

    public ArticleService(DataContext context, CategoryService categories)
    {
        _context = context;
        _categories = categories;
    }
    public async Task<IEnumerable<ArticleModel>> GetAllAsync()
    {
        var items = await _context.Articles.Include(x => x.Category).ToListAsync();

        var articles = new List<ArticleModel>();
        foreach (var item in items)
            articles.Add(item);

        return articles;
    }
    public async Task CreateAsync(ArticleRegistrationModel model)
    {
        ArticleEntity articleEntity = model;

        var categoryModel = (await _categories.GetAsync(x => x.CategoryName == model.CategoryName));

        if (categoryModel != null)
            articleEntity.CategoryId = categoryModel.Id;
        else
            articleEntity.CategoryId = await _categories.CreateAsync(model);

        _context.Articles.Add(articleEntity);
        await _context.SaveChangesAsync();
    }

    public ArticleService(Contexts.DataContext context)
    {
        _articles = new List<ArticleEntity>();
        _authors = new List<AuthorEntity>();

        _authors.Add(new AuthorEntity { Id = 1, Name = "Hans Mattin-Lassei", Email = "hans@example.com", Biography = "Hans är en bästsäljande författare noveller!" });
        _authors.Add(new AuthorEntity { Id = 2, Name = "Tommy Mattin-Lassei", Email = "tommy@example.com", Biography = "Tommy är en prisvinnande poet!" });

        _articles.Add(new ArticleEntity { Id = 1, Title = "Konsten om skrivandet", Content = "I den här artikeln utforskar vi de olika teknikerna och strategierna som författare använder för att skapa övertygande berättelser.", PublishedDate = DateTime.Now.AddDays(-2), AuthorId = 1 });
        _articles.Add(new ArticleEntity { Id = 2, Title = "Kraften av poesi", Content = "Poesi har kraften att röra oss, att få oss att känna saker som vi aldrig trodde var möjliga. I den här artikeln utforskar vi poesikonsten.", PublishedDate = DateTime.Now.AddDays(-1), AuthorId = 2 });
    }

    public IEnumerable<ArticleEntity> GetAllArticles()
    {
        return _articles;
    }

    public ArticleEntity GetArticleById(int id)
    {
        return _articles.FirstOrDefault(a => a.Id == id);
    }

    public void AddArticle(ArticleEntity article)
    {
        article.Id = _articles.Max(a => a.Id) + 1;
        _articles.Add(article);
    }

    public void UpdateArticle(int id, ArticleEntity article)
    {
        var existingArticle = _articles.FirstOrDefault(a => a.Id == id);

        if (existingArticle != null)
        {
            existingArticle.Title = article.Title;
            existingArticle.Content = article.Content;
            existingArticle.PublishedDate = article.PublishedDate;
            existingArticle.AuthorId = article.AuthorId;
        }
    }

    public void DeleteArticle(int id)
    {
        var existingArticle = _articles.FirstOrDefault(a => a.Id == id);

        if (existingArticle != null)
        {
            _articles.Remove(existingArticle);
        }
    }

    internal static object Create(Factories.ArticleRequest request)
    {
        throw new NotImplementedException();
    }

    internal static object Get(int id)
    {
        throw new NotImplementedException();
    }

    internal object GetAll()
    {
        throw new NotImplementedException();
    }

    internal object Update(int id, Factories.ArticleRequest request)
    {
        throw new NotImplementedException();
    }

    internal object Delete(int id)
    {
        throw new NotImplementedException();
    }
}
