using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data;


// This class is responsible for connecting
// our application models to the database using EF Core.
public class ApplicationDbContext : DbContext
{
    // Constructor:
    // Receives the database configuration from Program.cs
    // and sends it to the parent DbContext class.
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    // Represents the Students table in the database.
    // Each Student object represents one row in the table.
    public DbSet<Student> Students { get; set; }
}