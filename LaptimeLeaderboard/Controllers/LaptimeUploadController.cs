using System;
using System.Collections.Generic;
using LaptimeLeaderboard.Dto;
using LaptimeLeaderboard.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LaptimeLeaderboard.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class LaptimeUploadController : LeaderboardBaseController
    {
        private ILeaderboardUploadRepository repo;
        public LaptimeUploadController(ILeaderboardUploadRepository repo, IConfiguration cfg) : base(cfg)
        {
            this.repo = repo;
        }

        [HttpPost]
        public LapDefinition UploadLapTime()
        {
            return new LapDefinition();
        }

        [HttpPost]
        public string SaveLaptimeDetails(LapDefinition lapDetails)
        {
            return string.Empty;
        }
    }
}