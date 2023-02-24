using Microsoft.AspNetCore.Mvc;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class CatagoriesController : Controller
    {
        public TogetherVM Together;


        public IActionResult About()
        {

            TogetherVM together = new TogetherVM();

            return View(together);
        }
    }
}
