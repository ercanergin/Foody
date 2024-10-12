using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.AdminLayoutViewComponents
{
    public class _MainPanelLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoike()
        {
            return View();
        }
    }
}
