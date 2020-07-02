using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Shared;

namespace WEB.Server.src
{
    public class UserDataAccessLayer
    {
        EntityContext db = new EntityContext();

        //To Get all user details           
        public IEnumerable<UsersModel> GetAllUsers()
        {
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new user record             
        public void AddUser(UsersModel user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar user   
        public void UpdateUser(UsersModel user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }            
        
        //Get the details of a particular user    
        public UsersModel GetUserData(string id)
        {
            try
            {
                UsersModel user = db.Users.Find(id);
                return user;
            }
            catch
            {
                throw;
            }
        }            
        
        //To Delete the record of a particular user     
        public void DeleteUser(string id)
        {
            try
            {
                UsersModel emp = db.Users.Find(id);
                db.Users.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}