namespace PlanejamentoWeb.Services.JWT;

public record ProfileAuth(
  Guid ID,
  String username,
  Guid TuristicosID
);