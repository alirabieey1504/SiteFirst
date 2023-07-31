using System;
using System.ComponentModel.DataAnnotations;
using FirstSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model=new ContactModel();
            return View(model);

          
        }

      //  [HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var email = form["email"];

        //    return Json(Ok());
        //}


        [HttpPost]
        public JsonResult Contact(ContactModel form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
