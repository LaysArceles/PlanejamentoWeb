using PlanejamentoWeb.models;
using Microsoft.EntityFrameworkCore;

namespace PlanejamentoWeb.Services.Profiles;

public class ProfileService(TripDbContext ctx) : IProfileService
{
    Task<Guid> IProfileService.CreateProfile(Profile profile)
    {
        ctx.Profiles.Add(profile);
        await ctx.SaveChangesAsync();
        return profile.ID;
    }
    
    public async Task<Profile?> GetProfile(string login)
    {
        return await ctx.Profiles.FirstOrDefaultAsync(
            p => p.username == login
        );
    }
}

