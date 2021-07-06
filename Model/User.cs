using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace weddingplanner.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("WeddingEvent")]
        public int WeddingEventRefId {get; set;}
        public WeddingEvent WeddingEvent {get; set;}

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Role { get; set;}
    }
}