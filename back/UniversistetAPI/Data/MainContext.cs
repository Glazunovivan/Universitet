using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Models;

namespace UniversistetAPI.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public MainContext(DbContextOptions options): base(options)
        {
        }
    }
}
