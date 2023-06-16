using Microsoft.AspNetCore.Mvc;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _AgentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
