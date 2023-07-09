using System.Text.Json.Serialization;

namespace api.Models.ThirdParty;

public record NascarRaceSeriesCollectionJsonModel
{
    [JsonPropertyName("series_1")]
    public required IEnumerable<NascarRaceJsonModel> CupSeries { get; init; }
    [JsonPropertyName("series_2")]
    public required IEnumerable<NascarRaceJsonModel> XfinitySeries { get; init; }
    [JsonPropertyName("series_3")]
    public required IEnumerable<NascarRaceJsonModel> TruckSeries { get; init; }
}