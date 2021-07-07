using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weddingplanner.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace weddingplanner.Controllers
{
    [Route("api/Event/guestlist")]
    [ApiController]
    public class GuestListController : Controller
    {

        private readonly ApplicationDbContext _db;

        public GuestListController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int id) 
        {
            return Json(new {data = await _db.Guest.ToListAsync(u => u.WeddingEventRefId == id) });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            var GuestFromDb = await _db.Guest.FirstOrDefaultAsync(u => u.Id == id);
            if(GuestFromDb == null) {
                return Json(new { success = false, message= "Error while Deleting" });
            }
            _db.Guest.Remove(GuestFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful"});
        }
    }
}