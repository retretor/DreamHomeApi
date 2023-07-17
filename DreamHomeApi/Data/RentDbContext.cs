using DreamHomeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Data;

public class RentDbContext : DbContext
{
    public RentDbContext(DbContextOptions<RentDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=DreamHome;Username=postgres;Password=egoregor");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<Staff> Staff { get; set; } = null!;
    
    public DbSet<Branch> Branches { get; set; } = null!;
    
    public DbSet<Lease> Leases { get; set; } = null!;
    
    public DbSet<PropertyForRent> Properties { get; set; } = null!;
    
    public DbSet<Client> Clients { get; set; } = null!;
    
    public DbSet<PrivateOwner> PrivateOwners { get; set; } = null!;
    
    public DbSet<Viewing> Viewings { get; set; } = null!;
}