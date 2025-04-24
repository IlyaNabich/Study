using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
{ 
    public DbSet<Note> Notes { get; set; }
    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Note>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Note>()
                .Property(x => x.Text)
                .HasMaxLength(140);
            
            modelBuilder.Entity<Book>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Book>()
                .Property(x => x.Name)
                .HasMaxLength(300);
            modelBuilder.Entity<Book>()
                .Property(x => x.Author)
                .HasMaxLength(30);
            modelBuilder.Entity<Book>()
                .Property(x => x.Publisher)
                .HasMaxLength(70);
            modelBuilder.Entity<Book>()
                .Property(x => x.PublishDate);
                
            
        base.OnModelCreating(modelBuilder);
    }
}
