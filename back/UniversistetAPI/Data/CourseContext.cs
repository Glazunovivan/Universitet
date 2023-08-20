using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Models;

namespace UniversistetAPI.Data
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }

        public CourseContext(DbContextOptions options): base(options)
        {
        }
    }
}
