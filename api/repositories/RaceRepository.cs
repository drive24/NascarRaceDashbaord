using api.Models;
using api.Models.ApiModels;
using api.Models.RepositoryModels;
using api.Models.ThirdParty;

namespace api.repositories;

public class RaceRepository : IRaceRepository
{
    private const string CupSeriesName = "Cup Series";
    private const string XfinitySeriesName = "Xfinity Series";
    private const string CraftsmanTruckSeriesName = "Craftsman Truck Series";
    
    private const string BasicRaceDatasetUri = "https://cf.nascar.com/cacher/2023/race_list_basic.json";
    
    public async Task<RaceSeriesCollectionRepositoryModel> GetRacesForAllSeries()
    {
        using var client = new HttpClient();
        var res = await client.GetAsync(BasicRaceDatasetUri);

        if (res.IsSuccessStatusCode)
        {
            var series = await res.Content.ReadFromJsonAsync<NascarRaceSeriesCollectionJsonModel>();
            if (series is not null)
            {
                return new RaceSeriesCollectionRepositoryModel
                {
                    CupSeries = new SeriesRepositoryModel
                    {
                        Name = CupSeriesName,
                        Races = series.CupSeries.Select(NascarRaceMapper)
                    },
                    XfinitySeries = new SeriesRepositoryModel
                    {
                        Name = XfinitySeriesName,
                        Races = series.XfinitySeries.Select(NascarRaceMapper)
                    },
                    TruckSeries = new SeriesRepositoryModel
                    {
                        Name = CraftsmanTruckSeriesName,
                        Races = series.TruckSeries.Select(NascarRaceMapper)
                    }
                };
            }
                
        }
        
        // TODO: make a custom exception.
        throw new Exception("error getting races");
    }

    private static RaceRepositoryModel NascarRaceMapper(NascarRaceJsonModel race) => new()
        {
            Id = race.Id,
            RaceName = race.RaceName
        };
    
}