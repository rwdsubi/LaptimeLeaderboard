using LaptimeLeaderboard.Dto;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace LaptimeLeaderboard.Library
{
    public class LeaderboardRepository : ILeaderboardRepository
    {
        private readonly ILeaderboardContext context;
        public LeaderboardRepository(ILeaderboardContext context)
        {
            this.context = context;
        }

        public IEnumerable<LapDefinition> GetLeaderboard(string trackId, int skip = 0, int take = 20)
        {
            var records = context.Records.Aggregate().Match(x => x.TrackCode == trackId).Skip(skip).Limit(take).ToList();

            return records;
        }

        public LapDefinition ParseLapFile(string fileId)
        {
            throw new NotImplementedException();
        }

        public bool SaveFile(byte[] filestream)
        {
            throw new NotImplementedException();
        }

        public bool SaveLapRecord(LapDefinition lapDef)
        {
            // TODO: try catch
            var trackExist = this.context.Tracks.Aggregate().Match(a => a.TrackCode == lapDef.TrackCode).Any();

            if (!trackExist)
            {
                this.context.Tracks.InsertOne(new TrackDefinition()
                {
                    TrackCode = lapDef.TrackCode,
                    TrackName = lapDef.TrackName
                });
            }

            // TODO: seperate external dto from internal. do data validation

            this.context.Records.InsertOne(lapDef);

            return true;
        }
    }
}
