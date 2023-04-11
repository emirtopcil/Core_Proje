using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Revenue : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Projects = c.Portfolios.Count();
            ViewBag.Messages = c.Messages.Count();
            ViewBag.Services = c.Services.Count();
            return View();
        }
    }
}
