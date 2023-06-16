using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
