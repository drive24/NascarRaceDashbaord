using api.repositories;
using Microsoft.AspNetCore.Mvc;
using shared.Models.ApiModels;
using shared.Models.RepositoryModels;

namespace api.Controllers;

[Route("api/races")]
[ApiController]
public class RaceController : ControllerBase
{
    private readonly IRaceRepository _raceRepository;

    public RaceController(IRaceRepository raceRepository)
    {
        _raceRepository = raceRepository;
    }

    [HttpGet]
    public async Task<ActionResult<RaceSeriesCollectionApiModel>> GetRaces()
    {
        var series = await _raceRepository.GetRacesForAllSeries();

        return new RaceSeriesCollectionApiModel
        {
            CupSeries = new SeriesApiModel
            {
                Name = series.CupSeries.Name,
                Races = series.CupSeries.Races.Select(RaceMapper)
            },
            XfinitySeries = new SeriesApiModel
            {
                Name = series.XfinitySeries.Name,
                Races = series.XfinitySeries.Races.Select(RaceMapper)
            },
            TruckSeries = new SeriesApiModel
            {
                Name = series.TruckSeries.Name,
                Races = series.TruckSeries.Races.Select(RaceMapper)
            }
        };
    }

    private static RaceApiModel RaceMapper(RaceRepositoryModel race) => new()
    {
        Id = race.Id,
        RaceName = race.RaceName,
    };
}