using Microsoft.AspNetCore.Mvc;
using RelockProject.EntityLayer.Concrete;

namespace RelockProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

