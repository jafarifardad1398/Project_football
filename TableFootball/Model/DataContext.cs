using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TableFootball.Model
{
    class DataContext:DbContext
    {
        static DataContext()
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext,Migrations.Configuration>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Lig> Ligs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Play> plays { get; set; }

    }
}
