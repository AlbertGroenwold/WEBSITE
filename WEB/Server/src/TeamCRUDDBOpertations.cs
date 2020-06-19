using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Server.src;
using WEB.Shared;

namespace BlazorCRUDApp.Server.Data
{
    public class CRUDDbOperations
    {
        TeamCRUDContext rc = new TeamCRUDContext();
        //To Get all cruds
        public IEnumerable<TeamCrud> GetAllCRUDS()
        {
            try
            {
                return rc.tblCRUD.ToList();
            }
            catch { throw; }
        }
        //To Add new recipe
        public void AddCRUD(TeamCrud crud)
        {
            try
            {
                rc.tblCRUD.Add(crud);
                rc.SaveChanges();
            }
            catch { throw; }
        }
        //To Update particular crud
        public void UpdateCRUD(TeamCrud crud)
        {
            try
            {
                rc.Entry(crud).State = EntityState.Modified;
                rc.SaveChanges();
            }
            catch { throw; }
        }
        //Get the particular recipe
        public TeamCrud GetCRUDData(int id)
        {
            try
            {
                TeamCrud crud = rc.tblCRUD.Find(id);
                return crud;
            }
            catch
            {
                throw;
            }
        }
        //To Delete particular recipe
        public void DeleteCRUD(int id)
        {
            try
            {
                TeamCrud crud = rc.tblCRUD.Find(id);
                rc.tblCRUD.Remove(crud);
                rc.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}