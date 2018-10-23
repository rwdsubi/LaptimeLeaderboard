using LaptimeLeaderboard.HelperFunctions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptimeLeaderboard.Dto
{
    public class LapDefinition
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string TrackName { get; set; }
        public string TrackCode { get => Codify.Get(TrackName); }
        public double LapTime { get; set; } // Lap duration in seconds
        public string fileId { get; set; }
        public LapFileType FileFormat { get; set; }
    }
}
