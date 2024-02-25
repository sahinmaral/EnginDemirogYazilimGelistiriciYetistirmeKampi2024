using KodlamaIOSimulation.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIOSimulation.DataAccess.Concrete.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseInstructor>()
            .HasKey(ci => new { ci.CourseId, ci.InstructorId });

        modelBuilder.SeedData();
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructor { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CourseInstructor> CourseInstructors { get; set; }
}