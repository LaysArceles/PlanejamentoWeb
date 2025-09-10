namespace PlanejamentoWeb.models;

public class ProfileTrip
{
    public Guid ID { get; set; }
    public Guid ProfileID { get; set; }
    public Guid TripID { get; set; }
    public Trip Trip { get; set; }
    public Profile Profile { get; set; }
}