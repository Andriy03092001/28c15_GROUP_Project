using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPract.Entity
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [StringLength(maximumLength: 255)]
        public string Name { get; set; }

        [ForeignKey("team1")]
        public int Team1Id { get; set; }
        public Team team1 { get; set; }

        [ForeignKey("team2")]
        public int Team2Id { get; set; }
        public SecondTeam team2 { get; set; }
    }
}
