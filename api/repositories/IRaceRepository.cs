using shared.Models.RepositoryModels;

namespace api.repositories;

public interface IRaceRepository
{
    Task<RaceSeriesCollectionRepositoryModel> GetRacesForAllSeries();
}