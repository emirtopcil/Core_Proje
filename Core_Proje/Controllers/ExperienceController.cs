using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            return View(experienceManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience parameter)
        {
            experienceManager.TAdd(parameter);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet] 
        public IActionResult EditExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience parameter)
        {
            experienceManager.TUpdate(parameter);

            return RedirectToAction("Index");
        }
    }
}
