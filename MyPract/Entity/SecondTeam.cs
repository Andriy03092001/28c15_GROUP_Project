using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPract.Entity
{
    public class SecondTeam
    {
        [Key, ForeignKey("Team")]
        public int Id { get; set; }


        public Team Team { get; set; }
    }
}
