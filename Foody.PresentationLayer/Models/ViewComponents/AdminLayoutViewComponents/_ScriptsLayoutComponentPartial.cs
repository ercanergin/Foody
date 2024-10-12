using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptsLayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
