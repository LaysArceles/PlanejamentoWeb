using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace PlanejamentoWeb.models;

public class Profile
{
    public Guid ID { get; set; }
    public required string name { get; set; }
    public required string username { get; set; }
    public required string password { get; set; }

    ICollection<Trip> trips { get; set; } = [];
    ICollection<Tourist> tourists { get; set; } = [];

}