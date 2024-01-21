using Catalyst_web.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Course> Courses { get; set; }
    DbSet<RegisterForCourse> RegisterForCourses { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}