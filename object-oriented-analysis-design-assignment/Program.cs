using object_oriented_analysis_design_assignment.Contexts;
using Microsoft.EntityFrameworkCore;
using object_oriented_analysis_design_assignment.Repositories;
using object_oriented_analysis_design_assignment.Controllers;
using object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Interfaces;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Models.Entities;
using object_oriented_analysis_design_assignment.Models.BaseModels;
using object_oriented_analysis_design_assignment.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<IArticlesRequest>();
        builder.Services.AddScoped<IArticlesResponse>();
        builder.Services.AddScoped<ArticlesRepository>();
        builder.Services.AddScoped<IArticles>();
        builder.Services.AddScoped<IArticlesBlog>();
        builder.Services.AddScoped<IArticlesNews>();
        builder.Services.AddScoped<ICreateArticle>();
        builder.Services.AddScoped<ArticleService>();
        builder.Services.AddScoped<AuthorService>();
        builder.Services.AddScoped<CategoryService>();


        builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString(\"Sql\")));")));


        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.UseFileServer();
        app.UseRouting();

        app.Run();
    }
}