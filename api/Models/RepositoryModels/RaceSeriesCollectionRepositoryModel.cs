namespace api.Models.RepositoryModels;

public record RaceSeriesCollectionRepositoryModel
{ 
    public required SeriesRepositoryModel CupSeries { get; init; }
    public required SeriesRepositoryModel XfinitySeries { get; init; }
    public required SeriesRepositoryModel TruckSeries { get; init; }
}