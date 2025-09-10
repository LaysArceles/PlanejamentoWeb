using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PlanejamentoWeb.models;

public class TripDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Profile> profiles => Set<Profile>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<Tourist> tourists => Set<Tourist>();
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Profile>();
        mb.Entity<Trip>();
        mb.Entity<Tourist>();
    }
    
}