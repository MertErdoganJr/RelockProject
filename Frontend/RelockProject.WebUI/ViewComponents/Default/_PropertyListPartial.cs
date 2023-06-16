using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _PropertyListPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
