using BookAppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAppDemo.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
