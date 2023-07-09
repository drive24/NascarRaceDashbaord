using System.Text.Json.Serialization;

namespace shared.Models.ThirdParty;

public record NascarRaceJsonModel
{
    [JsonPropertyName("race_id")]
    public required int Id { get; init; }
    [JsonPropertyName("race_name")]
    public required string RaceName { get; init; }
}
