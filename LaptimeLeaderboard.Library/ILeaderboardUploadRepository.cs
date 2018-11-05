using LaptimeLeaderboard.Dto;
using System.Collections.Generic;

namespace LaptimeLeaderboard.Library
{
    public interface ILeaderboardUploadRepository
    {
        bool SaveFile(byte[] filestream);
        LapDefinition ParseLapFile(string fileId);
        bool SaveLapRecord(LapDefinition lapDef);
        IEnumerable<LapDefinition> GetLeaderboard(string trackId, int skip, int take);
    }
}