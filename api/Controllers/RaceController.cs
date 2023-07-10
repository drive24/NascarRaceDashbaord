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
    private readonly ILogger<RaceController> _logger;

    public RaceController(IRaceRepository raceRepository, ILogger<RaceController> logger)
    {
        _raceRepository = raceRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<RaceSeriesCollectionApiModel>> GetRaces()
    {
        RaceSeriesCollectionRepositoryModel series;
        try
        {
            series = await _raceRepository.GetRacesForAllSeries();
        }
        catch (Exception ex)
        {
            const string message = "error retrieving races from server";
            _logger.LogError(ex, message);
            return StatusCode(500, message);
        }

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
        RaceDate = race.RaceDate,
        ScheduledDistance = race.ScheduledDistance,
        ScheduledLaps = race.ScheduledLaps,
        TrackName = race.TrackName
    };
}