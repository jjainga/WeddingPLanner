using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weddingplanner.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<WeddingEvent> WeddingEvent { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Dress> Dress { get; set; }
        public DbSet<DressComments> DressComments { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<VenueComments> VenueComments { get; set; }
    }
}
