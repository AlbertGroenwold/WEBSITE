using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Shared;

namespace BlazorCrud.Server.DataAccess
{
    public class TeamDataAccessLayer
    {
        TeamContext db = new TeamContext();
        //To Get all teams details           
        public IEnumerable<TeamsModel> GetAllTeams()
        {
            try
            {
                return db.Teams.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new team record             
        public void AddTeam(TeamsModel team)
        {
            try
            {
                db.Teams.Add(team);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar team   
        public void UpdateTeam(TeamsModel team)
        {
            try
            {
                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }            //Get the details of a particular team    
        public TeamsModel GetTeamData(string id)
        {
            try
            {
                TeamsModel team = db.Teams.Find(id);
                return team;
            }
            catch
            {
                throw;
            }
        }            //To Delete the record of a particular team     
        public void DeleteTeam(string id)
        {
            try
            {
                TeamsModel emp = db.Teams.Find(id);
                db.Teams.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}