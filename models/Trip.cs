namespace PlanejamentoWeb.models;

public class Trip
{
    public Guid ID { get; set; }
    public required string title { get; set; }
    public required string Descricao { get; set; }
    public Guid liderID { get; set; }
    public Guid TouristID { get; set; }

    public Profile Lider { get; set; }
    public Tourist Tourist{ get; set; }
    ICollection<Tourist> tourists { get; set; } = [];
}