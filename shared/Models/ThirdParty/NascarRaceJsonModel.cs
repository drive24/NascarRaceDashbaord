using System.Text.Json.Serialization;

namespace shared.Models.ThirdParty;

public record NascarRaceJsonModel
{
    [JsonPropertyName("race_id")]
    public required int Id { get; init; }
    [JsonPropertyName("race_name")]
    public required string RaceName { get; init; }
    [JsonPropertyName("race_date")]
    public required DateTime RaceDate { get; init; }
    [JsonPropertyName("track_name")]
    public required string TrackName { get; init; }
    [JsonPropertyName("scheduled_distance")]
    public required double ScheduledDistance { get; init; }
    [JsonPropertyName("scheduled_laps")]
    public required double ScheduledLaps { get; init; }
}
