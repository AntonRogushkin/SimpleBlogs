using Microsoft.EntityFrameworkCore;
using SimpleBlogs.Db.Model;

namespace SimpleBlogs.Db;

public class SimpleBlogsDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SimpleBlogsDbContext).Assembly);
        modelBuilder.HasDefaultSchema("SimpleBlogs");
    }
}