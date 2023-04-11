using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            return View(portfolioManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio parameter)
        {
            PortfolioValidator validate = new PortfolioValidator();
            ValidationResult result = validate.Validate(parameter);

            if(result.IsValid)
            {
                portfolioManager.TAdd(parameter);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio parameter)
        {
            portfolioManager.TUpdate(parameter);
            return RedirectToAction("Index");
        }


    }
}
