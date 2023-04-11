using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Skill = c.Skills.Count();
            ViewBag.Message1 = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.Message2 = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.Experience = c.Experiences.Count();
            return View();
        }
    }
}
