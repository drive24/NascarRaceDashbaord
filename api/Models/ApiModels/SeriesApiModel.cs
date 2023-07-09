namespace api.Models.ApiModels;

public record SeriesApiModel
{
    public required string Name { get; set; }
    public required IEnumerable<RaceApiModel> Races { get; set; }
};