using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _HeadTitlePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
