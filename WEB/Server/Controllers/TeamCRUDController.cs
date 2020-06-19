using System.Collections.Generic;
using System.Linq;
using BlazorCRUDApp.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEB.Server.Controllers;
using WEB.Shared;

namespace BlazorCRUDApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamCRUDController : ControllerBase
    {
        private readonly ILogger<TeamCRUDController> logger;

        public TeamCRUDController(ILogger<TeamCRUDController> logger)
        {
            this.logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<TeamCrud> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new TeamCrud
            {
                name="Albert",
                id="no",
                email="test"
            })
            .ToArray();

            //return dbOpereations.GetAllCRUDS();
        }
    }
}