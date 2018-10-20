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
    [Route("api/[controller]")]
    [ApiController]
    public class LaptimeController : ControllerBase
    {
        private ILeaderboardRepository repo;
        private IConfiguration cfg;
        private readonly string apiKey;

        public LaptimeController(ILeaderboardRepository repo, IConfiguration cfg)
        {
            this.repo = repo;
            this.cfg = cfg;
            apiKey = cfg.GetSection("ApiKey").Value;
        }

        private bool ApiKeyValid(string apiKey)
        {
            return apiKey == this.apiKey;
        }

        public IEnumerable<TrackDefinition> GetTracks()
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
    }
}