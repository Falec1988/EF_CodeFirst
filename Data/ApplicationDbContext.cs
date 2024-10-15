using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; }

    public DbSet<Grade> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>().HasData(
            new Student { StudentId = 1, StudentName = "Ivan Horvat", DateOfBirth = new DateTime(1998, 1, 1), Height = 178, Weight = 75.5f },
            new Student { StudentId = 2, StudentName = "Matija Kršić", DateOfBirth = new DateTime(1999, 1, 1), Height = 183, Weight = 90.2f },
            new Student { StudentId = 3, StudentName = "Zoran Stipić", DateOfBirth = new DateTime(2000, 1, 1), Height = 175, Weight = 72.2f }
        );

        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "A", Section = "1", StudentId = 1 },
            new Grade { GradeId = 2, GradeName = "B", Section = "1", StudentId = 2 },
            new Grade { GradeId = 3, GradeName = "C", Section = "2", StudentId = 3 }
        );
    }
}