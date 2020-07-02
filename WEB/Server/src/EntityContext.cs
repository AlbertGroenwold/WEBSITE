using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Shared;

namespace WEB.Server.src 
{ 
    public class EntityContext : DbContext 
    { 
        public virtual DbSet<TeamsModel> Teams { get; set; }
        public virtual DbSet<UsersModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            if (!optionsBuilder.IsConfigured) 
            { 
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreateWebsite");
            } 
        } 
    } 
}