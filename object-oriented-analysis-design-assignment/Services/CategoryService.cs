using object_oriented_analysis_design_assignment.Contexts;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using object_oriented_analysis_design_assignment.Models.Entities;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Migrations;

namespace object_oriented_analysis_design_assignment.Services
{
    public class CategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<CategoryModel> GetAsync(Expression<Func<CategoryEntity, bool>> expression)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(expression);
            if (category != null)
                return category!;

            return null!;
        }

        public async Task<int> CreateAsync(CategoryRegistrationModel model)
        {
            CategoryEntity categoryEntity = model;
            _context.Categories.Add(categoryEntity);
            await _context.SaveChangesAsync();

            return categoryEntity.Id;
        }
    }
}
