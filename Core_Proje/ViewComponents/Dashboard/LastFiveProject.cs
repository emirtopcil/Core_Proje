using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class LastFiveProject : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.First = "Ticari Otomasyon";
            return View();
        }
    }
}
