using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleCode.Models;

namespace ExampleCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ExampleModel
            {
                Messages = new List<ExampleMessage>()
            };

            model.Messages.Add(new ExampleMessage
            {
                DatabaseId = 1,
                Date = DateTime.Now.ToShortDateString(),
                Message = "My first message"
            });

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ExampleModel model)
        {
            var test = model;
            return View(model);
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