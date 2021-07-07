using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace weddingplanner.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class WeddingEventController : Controller
    {

        private readonly ApplicationDbContext _db;

        public WeddingEventController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Json(new {data = await _db.WeddingEvent.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            var WeddingEventFromDb = await _db.WeddingEvent.FirstOrDefaultAsync(u => u.Id == id);
            if(WeddingEventFromDb == null) {
                return Json(new { success = false, message= "Error while Deleting" });
            }
            _db.WeddingEvent.Remove(WeddingEventFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful"});
        }
    }
}