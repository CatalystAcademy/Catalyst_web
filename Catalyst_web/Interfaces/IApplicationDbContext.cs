using Catalyst_web.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Course> Courses { get; set; }
    DbSet<Curriculum> Curriculums { get; set; }
    DbSet<CurriculumSection> CurriculumSections { get; set; }
    DbSet<News> Newses { get; set; }
    DbSet<Blog> Blogs { get; set; }
    DbSet<Video> Videos { get; set; }
    DbSet<Visit> Visits { get; set; }
    DbSet<Teacher> Teachers { get; set; }
    DbSet<BecomeTeacher> BecomeTeachers { get; set; }
    DbSet<RegisterForCourse> RegisterForCourses { get; set; }
    DbSet<RegisterForCurriculum> RegisterForCurriculums { get; set; }
    DbSet<FormData> FormDatas { get; set; }
    DbSet<Contact> Contacts { get; set; }
    DbSet<Testimonial> Testimonials { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}