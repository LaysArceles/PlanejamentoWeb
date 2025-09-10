using System.ComponentModel.DataAnnotations;

namespace PlanejamentoWeb.UseCase;

public record CreateTripPayload
{
    [Required]
    [MaxLength(20)]
    public required string title { get; set; }

    [Required]
    [MinLength(40)]
    [MaxLength(200)]
    public required string destricao { get; set; }
}