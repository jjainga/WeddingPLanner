using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weddingplanner.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace weddingplanner.Controllers
{
    [Route("api/Event/venue")]
    [ApiController]
    public class VenueController : Controller
    {

        private readonly ApplicationDbContext _db;

        public VenueController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Json(new {data = await _db.Venue.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            var VenueFromDb = await _db.Venue.FirstOrDefaultAsync(u => u.Id == id);
            if(VenueFromDb == null) {
                return Json(new { success = false, message= "Error while Deleting" });
            }
            _db.Venue.Remove(VenueFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful"});
        }
    }
}