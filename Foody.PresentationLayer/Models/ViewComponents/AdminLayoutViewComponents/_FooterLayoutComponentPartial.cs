using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.AdminLayoutViewComponents
{
    public class _FooterLayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
