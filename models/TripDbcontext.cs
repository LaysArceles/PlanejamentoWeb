using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PlanejamentoWeb.models;

public class TripDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<Tourist> Tourists => Set<Tourist>();
    public DbSet<ProfileTrip> profileTrips => Set<ProfileTrip>();
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<ProfileTrip>()
        .HasOne(u => u.Profile)
        .WithMany(r => r.profileTrips)
        .HasForeignKey(ur => ur.ProfileID)
        .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ProfileTrip>()
       .HasOne(u => u.Trip)
       .WithMany(r => r.profileTrips)
       .HasForeignKey(ur => ur.TripID)
       .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Profile>();

        mb.Entity<Trip>();
        mb.Entity<Tourist>();
    
        
    }
    
}