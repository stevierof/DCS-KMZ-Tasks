using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SandBox.Tasks.Data
{
    public class SandBoxContext : DbContext
    {

        public DbSet<Entities.DestroyedUnit>? DestroyedUnits { get; set; }
        public DbSet<Entities.ReconnedUnit>? ReconnedUnits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = new Config().ConnectionString;


            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}
