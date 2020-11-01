using Calculartor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculartor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Expression model, string command)
        {
            if (ModelState.IsValid)
            {
                switch (command)
                {
                    case "+":
                        model.Result = model.Num1 + model.Num2;
                        break;
                    case "-":
                        model.Result = model.Num1 - model.Num2;
                        break;
                    case "x":
                        model.Result = model.Num1 * model.Num2;
                        break;
                    case "/":
                        if (model.Num2 != 0)
                            model.Result = model.Num1 / model.Num2;
                        break;
                }
                return View(model);
            }
            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    
}