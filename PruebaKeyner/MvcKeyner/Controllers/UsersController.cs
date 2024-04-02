using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcKeyner.Data;

namespace MvcKeyner.Controllers{
    public class UsersController : Controller{

        readonly CrudKeynerContext _context;

        public UsersController(CrudKeynerContext context){
            _context =context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Users.ToListAsync());
        }

          public async  Task<IActionResult> Detalles(int? id ){
            return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
        } 


    }
}