using Microsoft.EntityFrameworkCore;
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
            string connectionString = "server=localhost;port=3306;database=mydb;uid=root;password=6yy@mrCCTpw!4W@0;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}
