namespace api.Models;

public record RaceApiModel
{
    public required int Id { get; init; }

    public required string RaceName { get; init; }
}