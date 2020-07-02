using WEB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WEB.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<UsersModel> Get()
        {
            var rng = new Random();
            int num = 0;
            return Enumerable.Range(1, 6).Select(index => new UsersModel
            {
                userName = "userNameTest" + num,
                userID = "userIDTest" + (num++),
                userTeamID = "teamIDTest" + rng.Next(0,2),
            })
            .ToArray();
        }
    }
}
