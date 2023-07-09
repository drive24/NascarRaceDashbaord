using api.repositories;

namespace api.Models.ApiModels;

public record RaceSeriesCollectionApiModel
{
    public required SeriesApiModel CupSeries { get; init; }
    public required SeriesApiModel XfinitySeries { get; init; }
    public required SeriesApiModel TruckSeries { get; init; }
}