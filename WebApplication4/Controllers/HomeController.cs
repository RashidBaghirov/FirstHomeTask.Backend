using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public TogetherVM Together;

    
        public IActionResult Index()
        {

            TogetherVM together = new TogetherVM();
         
            return View(together);
        }


 
    }
}
