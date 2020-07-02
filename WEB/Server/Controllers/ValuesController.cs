using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB.Shared;

namespace BlazorCrud.Server.Controllers
{
    [Authorize]
    public class TeamController : Controller 
    {
        TeamDataAccessLayer objteam = new TeamDataAccessLayer();
        [HttpGet] [Route("api/Team/Index")] 
        public IEnumerable<TeamsModel> Index() 
        { 
            return objteam.GetAllTeams(); 
        }
        [HttpPost] [Route("api/Team/Create")] 
        public void Create([FromBody] TeamsModel team) 
        { 
            if (ModelState.IsValid) objteam.AddTeam(team); 
        }
        [HttpGet] [Route("api/Team/Details/{id}")]
        public TeamsModel Details(string id) 
        { 
            return objteam.GetTeamData(id); 
        }
        [HttpPut] [Route("api/Team/Edit")] 
        public void Edit([FromBody] TeamsModel team)
        { 
            if (ModelState.IsValid) objteam.UpdateTeam(team); 
        }
        [HttpDelete] [Route("api/Team/Delete/{id}")] 
        public void Delete(string id) 
        { 
            objteam.DeleteTeam(id);
        }
    } 
}