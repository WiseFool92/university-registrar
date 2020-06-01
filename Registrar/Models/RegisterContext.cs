using Microsoft.EntityFrameworkCore;

namespace Register.Models
{
  public class RegisterContext : DbContext
  {
    public virtual DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<CourseStudent> CourseStudent { get; set; }

    public RegisterContext(DbContextOptions options) : base(options) { }
  }
}