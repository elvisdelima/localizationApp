using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using localizationApp.Resources;
using Microsoft.AspNet.Localization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Localization;

namespace localizationApp.Controllers
{
    public class HomeController : Controller
    {        
        private IHtmlLocalizer<AppResources> _localizer; 
        
        public HomeController(IHtmlLocalizer<AppResources> htmlLocalizer)
        {
            _localizer = htmlLocalizer;            
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = AppResources.WelcomeText  + " >>>  " + _localizer["WellcomeText"];

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
