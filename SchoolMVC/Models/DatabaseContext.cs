using Microsoft.EntityFrameworkCore;
using SchoolMVC.Models.Entities;

namespace SchoolMVC.Model
{
    public class DataaseContext : DbContext
    {
        public DataaseContext(DbContextOptions<DataaseContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
