using MongoDB.Bson.Serialization.Attributes;

namespace LaptimeLeaderboard.Dto
{
    public class TrackDefinition
    {
        [BsonId]
        public string TrackCode { get; set; }
        public string TrackName { get; set; }
    }
}
