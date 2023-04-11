using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class CountryVisitors : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
