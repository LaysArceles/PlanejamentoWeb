using Microsoft.EntityFrameworkCore;
using PlanejamentoWeb.models;

namespace PlanejamentoWeb.UseCase;

public class EditTripUseCase(TripDbContext ctx)
{
    public async Task<Result<EditTripResponse>> Do(EditTripPayload payload)
    {
        var lider = await ctx.Profiles.Include()
    }

    
}