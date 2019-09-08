using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kalkulator.Logic;
using kalkulator.Models;

namespace kalkulator.Controllers
{
    public class KalkulatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ExpressionModel expressionModel = new ExpressionModel()
            {
                expression = "0"
            };
            return View(expressionModel);
        }

        [HttpPost]
        public ActionResult Index(ExpressionModel expressionModel)
        {
            InterpretExpression interpretExpression = new InterpretExpression(expressionModel.expression);
            expressionModel.expression = expressionModel.expression + "=" + interpretExpression.Result();
            return View(expressionModel);
        }
    }
}