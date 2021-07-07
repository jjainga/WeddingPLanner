using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weddingplanner.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace weddingplanner.Controllers
{
    [Route("api/Event/user")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Json(new {data = await _db.User.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            var UserFromDb = await _db.User.FirstOrDefaultAsync(u => u.Id == id);
            if(UserFromDb == null) {
                return Json(new { success = false, message= "Error while Deleting" });
            }
            _db.User.Remove(UserFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful"});
        }
    }
}