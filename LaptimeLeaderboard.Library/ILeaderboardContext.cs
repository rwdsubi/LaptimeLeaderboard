using LaptimeLeaderboard.Dto;
using MongoDB.Driver;

namespace LaptimeLeaderboard.Library
{
    public interface ILeaderboardContext
    {
        IMongoCollection<TrackDefinition> Tracks { get; }
        IMongoCollection<LapDefinition> Laptimes { get; }
    }
}
