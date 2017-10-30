using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPract.Entity
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [StringLength(maximumLength:255)]
        public string Name { get; set; }

        
        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team team { get; set; }
    }
}
