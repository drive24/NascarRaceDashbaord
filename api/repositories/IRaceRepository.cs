using api.Models;
using api.Models.ApiModels;
using api.Models.RepositoryModels;

namespace api.repositories;

public interface IRaceRepository
{
    Task<RaceSeriesCollectionRepositoryModel> GetRacesForAllSeries();
}