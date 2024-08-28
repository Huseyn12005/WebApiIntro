using Microsoft.EntityFrameworkCore;
using WebApiIntro.Entities.Concretes;

namespace WebApiIntro.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CarGallery> CarGalleries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Cars)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<CarGallery>()
            .HasMany(cg => cg.Cars)
            .WithOne(c => c.CarGallery)
            .HasForeignKey(c => c.CarGalleryId);
    }
}