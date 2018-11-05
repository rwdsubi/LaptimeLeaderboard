using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptimeLeaderboard.Api.Middlewares
{
    internal class AccessLogMiddlewhere
    {
        private readonly RequestDelegate next;

        public AccessLogMiddlewhere(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Log input
            await this.next.Invoke(context);
            //Log output
        }
    }
}
