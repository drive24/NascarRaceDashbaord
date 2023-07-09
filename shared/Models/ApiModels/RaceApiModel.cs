namespace shared.Models.ApiModels;

public record RaceApiModel
{
    public required int Id { get; init; }

    public required string RaceName { get; init; }
}