using BookWebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookWebApi.Repostory;

public class BaseDbContect : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Database=tc_book_db; Trusted_Connection=true");
    }

    public DbSet<Book> Books { get; set; } 
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Author { get; set; }

}
