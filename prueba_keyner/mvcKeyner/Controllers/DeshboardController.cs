using Microsoft.AspNetCore.Mvc;

namespace Mvc.controller{
    public class DeshboardController : Controller{

        public IActionResult Index(){
            return View();
        }
    }
}