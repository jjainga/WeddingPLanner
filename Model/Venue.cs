using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace weddingplanner.Model
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("WeddingEvent")]
        public int WeddingEventRefId {get; set;}
        public WeddingEvent WeddingEvent {get; set;}

        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Link {get; set;}
        public int Price { get; set; }
        public int Likes {get; set;}
        public int Dislikes {get; set;}
    }
}