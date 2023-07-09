
using System.Net.Http.Json;
using shared.Models.ApiModels;
using shared.Models.RepositoryModels;

namespace ui.Pages;

public partial class NascarRaces
{
    private RaceSeriesCollectionApiModel? _raceSeriesCollectionApiModel;

    protected override async Task OnInitializedAsync()
    { 
        _raceSeriesCollectionApiModel = await Http.GetFromJsonAsync<RaceSeriesCollectionApiModel>("http://localhost:5007/api/races");
    }
}