using Microsoft.AspNetCore.Mvc;

namespace TagHelpersMVC.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
