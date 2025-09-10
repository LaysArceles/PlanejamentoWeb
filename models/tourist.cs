namespace PlanejamentoWeb.models;

public class Tourist
{
    public Guid ID { get; set; }
    public required string title { get; set; }
    public Guid EquipeID { get; set; }
    public required Profile Equipe { get; set; }
    public ICollection<Profile> Profiles { get; set; } = [];
    
}