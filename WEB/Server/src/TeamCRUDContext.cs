using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB.Shared;

namespace WEB.Server.src
{
    public class TeamCRUDContext:DbContext
    {

        public virtual DbSet<TeamCrud> tblCRUD { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=root;Password=admin123!;Host=localhost;Port=5432;Database=myDataBase;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;");
            }
        }
    }
}
