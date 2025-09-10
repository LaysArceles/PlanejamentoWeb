namespace PlanejamentoWeb.UseCase;

public record LoginPayload(
    string login,
    string password
);