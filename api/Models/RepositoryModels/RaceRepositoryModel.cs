namespace api.Models.RepositoryModels;

public record RaceRepositoryModel
{
    public required int Id { get; init; }
    public required string RaceName { get; init; }
}