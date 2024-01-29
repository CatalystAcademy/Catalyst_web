using System.Reflection;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<News> Newses { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BecomeTeacher> BecomeTeachers { get; set; }
    public DbSet<RegisterForCourse> RegisterForCourses { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        // foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        //     switch (entry.State)
        //     {
        //         case EntityState.Added:
        //             entry.Entity.CreatedBy = _currentUserService.UserId;
        //             entry.Entity.Created = _dateTimeOffset.Now;
        //             break;
        //         case EntityState.Modified:
        //             entry.Entity.ModifiedBy = _currentUserService.UserId;
        //             entry.Entity.Modified = _dateTimeOffset.Now;
        //             break;
        //     }

        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}