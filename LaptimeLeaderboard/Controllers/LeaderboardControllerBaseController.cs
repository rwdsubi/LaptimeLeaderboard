using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptimeLeaderboard.Library.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LaptimeLeaderboard.Api.Controllers
{
    public class LeaderboardBaseController : Controller
    {
        private string apiKey;
        private IConfiguration cfg;

        public LeaderboardBaseController(IConfiguration cfg)
        {
            this.cfg = cfg;
        }
    }
}