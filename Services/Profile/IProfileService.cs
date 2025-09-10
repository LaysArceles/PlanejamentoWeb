using PlanejamentoWeb.models;

namespace PlanejamentoWeb.Services.Profiles;

public interface IProfileService
{
    Task<Guid> CreateProfile(Profile profile);
    Task<Profile?> GetProfile(string username);
}