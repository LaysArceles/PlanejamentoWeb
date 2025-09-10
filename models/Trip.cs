namespace PlanejamentoWeb.models;

public class Trip
{
    public Guid ID { get; set; }
    public required string title { get; set; }
    public required string Descricao { get; set; }
    
}