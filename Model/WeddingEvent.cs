using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weddingplanner.Model
{
    public class WeddingEvent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string GroomName { get; set; }
        public string GroomEmail { get; set; }
        public string GroomPassword { get; set;} 
        public int GroomPhoneNumber { get; set; }
        public string BrideName { get; set; }
        public string BrideEmail { get; set; }
        public string BridePassword { get; set;} 
        public int BridePhoneNumber { get; set; }
    
        
    }
}