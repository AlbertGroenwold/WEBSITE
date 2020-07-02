using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Shared;

namespace BlazorCrud.Server.DataAccess 
{ 
    public class TeamContext : DbContext 
    { 
        public virtual DbSet<TeamsModel> Teams { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            if (!optionsBuilder.IsConfigured) 
            { 
                //optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=CreateWebsite;Integrated Security=True");
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreateWebsite");
            } 
        } 
    } 
}