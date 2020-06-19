using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEB.Server.src;
using WEB.Server.Utilities;
using WEB.Shared;

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

        private string getData(DataTable table, int iteration, string col)
        {
            return table.Rows[iteration-1][col].ToString();
        }

        [HttpGet]
        public IEnumerable<TeamShared> Get()
        {
            DataManager dm = new DataManager();

            DataTable table = dm.getDBTables("Teams");

            int numOfTeams = table.Rows.Count;

            return Enumerable.Range(1, numOfTeams).Select(index => new TeamShared
            {
                teamID = getData(table,index,"TeamID"),
                teamName = getData(table, index, "TeamName"),
                teamAdmin = getData(table, index, "Admin").Equals("1") ? "True" : "False",
                teamDev = getData(table, index, "Developer").Equals("1") ? "True" : "False",
                teamTest = getData(table, index, "Tester").Equals("1") ? "True" : "False"
            })
            .ToArray();
        }

        [HttpGet("string")]
        public string GetString()
        {
            return "i found the name";
        }
    }
}
