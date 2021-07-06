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
        
    }
}