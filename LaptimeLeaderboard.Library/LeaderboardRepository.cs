using MongoDB.Driver;
using System;

namespace LaptimeLeaderboard.Library
{
    public class LeaderboardRepository : ILeaderboardRepository
    {
        private readonly ILeaderboardContext context;
        public LeaderboardRepository(ILeaderboardContext context)
        {
            this.context = context;
        }

        public void SaveString(string testString)
        {
            
        }
    }
}
