namespace PlanejamentoWeb.models;

public class Trip
{
    public Guid ID { get; set; }
    public required string title { get; set; }
    public required string Descricao { get; set; }
    public Profile Lider { get; set; }
    
    ICollection<Tourist> tourists { get; set; } = [];
     public ICollection<ProfileTrip> profileTrips { get; set; } = [];
}