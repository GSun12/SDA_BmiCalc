using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.BusinessLogic;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BmiController : Controller
    {
        private readonly BmiBusinessLogic _bmiBusinessLogic;

        public BmiController()
        {
            _bmiBusinessLogic = new BmiBusinessLogic();
        }
        public ActionResult CountBmi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CountBmi(BmiForm model)
        {
            var validator = new BmiValidator();
            var result = validator.Validate(model);
            if (result.IsValid)
            {
                _bmiBusinessLogic.CountBmi(model);
                return View(_bmiBusinessLogic.CheckBmi(model.Result), model);
            }
            ModelState.Clear();
            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.ErrorMessage);
            return View(model);
        }
    }
}