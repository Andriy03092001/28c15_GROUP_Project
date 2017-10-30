using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPract.Entity
{
    public class EFContext:DbContext
    {
        public EFContext():base("Connection")
        {

        }
        public DbSet<Game> Games{ get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SecondTeam> SecondTeam { get; set; }
    }
}
