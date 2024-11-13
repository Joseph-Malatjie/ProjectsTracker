using Domain.Address;
using Domain.Project;
using Domain.Rating;
using Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Developer> Developers { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Address> Addresses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure inheritance using TPH
        modelBuilder.Entity<User>()
            .HasDiscriminator<UserType>("UserType")
            .HasValue<Developer>(UserType.Developer)
            .HasValue<Manager>(UserType.Manager);
        
        base.OnModelCreating(modelBuilder);
    }
}