using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcKeyner.Data;

namespace MvcKeyner.Controllers{
public class UsersController : Controller {

   public readonly CrudKeynerContext _contexts;// creacion de variable _context  de tipo CrudKeynerContext

    public UsersController(CrudKeynerContext context){

        _contexts = context;
    }

    public  async Task <IActionResult> Index(){
        return View (await  _context.Users.ToListAsync());// Users es el ailias 
    }



}

}