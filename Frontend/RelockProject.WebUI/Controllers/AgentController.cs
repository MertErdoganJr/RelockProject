using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
