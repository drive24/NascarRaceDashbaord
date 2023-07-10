
using System.Net.Http.Json;
using shared.Models.ApiModels;

namespace ui.Pages;

public partial class NascarRaces
{
    private string? Error { get; set; }
    private RaceSeriesCollectionApiModel? _raceSeriesCollectionApiModel;

    protected override async Task OnInitializedAsync()
    { 
        for (var i = 0; i < 5; i++)
        {
            try
            {
                _raceSeriesCollectionApiModel = await Http.GetFromJsonAsync<RaceSeriesCollectionApiModel>("http://localhost:5007/api/races");
                break;
            } 
            catch (HttpRequestException)
            {
                await Task.Delay(1000);
            }
        }

        if (_raceSeriesCollectionApiModel is null)
        {
            Error = "Could not retrieve data from the server.";
        }
    }
}