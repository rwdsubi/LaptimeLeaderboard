using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptimeLeaderboard.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LaptimeLeaderboard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : LeaderboardBaseController
    {
        private IAdminRepository adminRepo;

        public AdminController(IAdminRepository adminRepo, IConfiguration cfg) : base(cfg)
        {
            this.adminRepo = adminRepo;
        }
    }
}