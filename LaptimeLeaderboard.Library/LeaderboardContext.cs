using LaptimeLeaderboard.Dto;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptimeLeaderboard.Library
{
    public class LeaderboardContext : ILeaderboardContext
    {
        private readonly IMongoDatabase _db;
        public LeaderboardContext(IOptions<MongoDbSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
            EnsureIndexes();
        }

        private void EnsureIndexes()
        {
            Laptimes.Indexes.CreateOne(Builders<LapDefinition>.IndexKeys.Ascending(x => x.TrackCode).Ascending(x => x.LapTime));

            Tracks.Indexes.CreateOne(Builders<TrackDefinition>.IndexKeys.Ascending(x => x.TrackCode));
        }

        public IMongoCollection<TrackDefinition> Tracks => _db.GetCollection<TrackDefinition>("Tracks");
        public IMongoCollection<LapDefinition> Laptimes => _db.GetCollection<LapDefinition>("Laptimes");
    }
}
