namespace PlanejamentoWeb.UseCase;

public record EditTripPayload
{

    public Guid TouristID { get; set; }
    public Guid TripID { get; set; }

}