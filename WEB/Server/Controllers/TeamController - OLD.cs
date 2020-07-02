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
    public class TeamController : ControllerBase
    {

        private readonly ILogger<TeamController> logger;

        public TeamController(ILogger<TeamController> logger)
        {
            this.logger = logger;
        }

        [HttpPut]
        public int Put([FromBody] TeamsModel response)
        {
            return 1;
        }

        [HttpPost]
        public int Post([FromBody] TeamsModel response)
        {

            return 1;
        }

        [HttpDelete("{teamID}")]
        public int Delete(string teamID)
        {
            

            return 1;
        }

        [HttpGet]
        public IEnumerable<TeamsModel> Get()
        {

            int num  = 0;
            return Enumerable.Range(1, 2).Select(index => new TeamsModel
            {
                TeamName = "teamNameTest"+num,
                TeamID = "teamIDTest" + num,
                Admin = num,
                Developer = num,
                Tester = (num++),
            })
            .ToArray();
        }
    }
}
