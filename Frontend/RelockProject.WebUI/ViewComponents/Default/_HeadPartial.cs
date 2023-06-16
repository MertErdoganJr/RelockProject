using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
