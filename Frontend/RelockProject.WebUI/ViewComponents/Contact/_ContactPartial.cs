using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Contact
{
    public class _ContactPartial  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
