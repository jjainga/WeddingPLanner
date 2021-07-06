using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace weddingplanner.Model
{
    public class VenueComments
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Venue")]
        public int VenueRefId {get; set;}
        public Venue Venue {get; set;}

        [Required]
        public string Comment { get; set; }
        public int Likes {get; set;}
        public int Dislikes {get; set;}
    }
}