namespace shared.Models.RepositoryModels;

public record SeriesRepositoryModel
{
    public required string Name { get; set; }
    public required IEnumerable<RaceRepositoryModel> Races { get; set; }
};