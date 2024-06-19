using Microsoft.EntityFrameworkCore;
using TestProjectAPI.Models;

namespace TestProjectAPI.Concrete
{
    public class Context:DbContext
    {
        public DbSet<BookModel> Books { get; set; }
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BookModel>()
                .HasIndex(e => e.BookTopic);

            modelBuilder.Entity<BookModel>()
                .ToView("AvailableBooks")
                .HasKey(e => e.Id);

            
        }
    }
}
