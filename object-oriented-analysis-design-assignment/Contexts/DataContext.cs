using Microsoft.EntityFrameworkCore;
using object_oriented_analysis_design_assignment.Models.Entities;
using System.Collections.Generic;

namespace object_oriented_analysis_design_assignment.Contexts;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ArticlesEntity> Articles { get; set; }

}
