using Microsoft.EntityFrameworkCore;
using BookStoreWeb.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}
