using Microsoft.EntityFrameworkCore;
using object_oriented_analysis_design_assignment.Contexts;
using System.Linq.Expressions;

namespace object_oriented_analysis_design_assignment.Repositories;

public abstract class Repository<TEntity> where TEntity : class
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public abstract Task<TEntity> GetAsync();

}
