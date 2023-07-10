namespace shared.Models.ApiModels;

public record RaceApiModel
{
    public required int Id { get; init; }
    public required string RaceName { get; init; }
    public required DateTime RaceDate { get; init; }
    public required string TrackName { get; init; }
    public required double ScheduledDistance { get; init; }
    public required double ScheduledLaps { get; init; }
}