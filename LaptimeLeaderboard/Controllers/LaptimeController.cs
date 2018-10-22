using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptimeLeaderboard.Dto;
using LaptimeLeaderboard.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LaptimeLeaderboard.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class LaptimeController : LeaderboardBaseController
    {
        private ILeaderboardRepository repo;
        public LaptimeController(ILeaderboardRepository repo, IConfiguration cfg) : base(cfg)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IEnumerable<TrackDefinition> GetTracks(string apiKey)
        {
            try
            {

                
                return new List<TrackDefinition>();
            }
            catch(Exception ex)
            {
                //todo: Replace with better handling
                throw;
            }
            
        }

        [HttpGet]
        public string GetLaptimeFile(string apiKey, string fileId)
        {
            return "kjdsfghd";
        }
    }
}