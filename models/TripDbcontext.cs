using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PlanejamentoWeb.models;

public class TripDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<Tourist> Tourists => Set<Tourist>();
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Profile>();
        mb.Entity<Trip>()
        .HasOne(u => u.Lider);
        //.WithMany(u => u.Tourists)
        mb.Entity<Tourist>();
    }
    
}