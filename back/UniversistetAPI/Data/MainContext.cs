using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Models;

namespace UniversistetAPI.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<GroupStudent> GroupStudents { get; set; }
        public DbSet<GroupTeacher> GroupTeachers { get; set; }

        public MainContext(DbContextOptions options): base(options)
        {
        }
    }
}
