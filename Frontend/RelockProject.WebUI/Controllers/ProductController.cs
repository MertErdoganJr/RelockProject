using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
