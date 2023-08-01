using System.Collections.Generic;
using FirstSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "طلا"),
            new Service(2, "پلاتین"),
            new Service(3, "نقره"),
            new Service(4, "الماس")
        };

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactModel()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست.لطفا دوباره تلاش کنید.";
                return View(model);
            }

            ModelState.Clear();
            model = new ContactModel
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "اطلاعات شما با موفقیت ثبت شد";
            return View(model);
            //   return RedirectToAction("Index");
        }

        private readonly List<Wzfrs> _wzfrs = new List<Wzfrs>
        {
             new Wzfrs(1,"اراک"), 
             new Wzfrs(2,"تهران")
        };
        [HttpGet]
        public IActionResult formexe()
        {
            
            var key = new FormKeyModel
            {
                Wzfr  =new SelectList(_wzfrs,"Id","Name")
            };
            return View(key);
        }

        [HttpPost]
        public IActionResult formexe(FormKeyModel model)
        {
            model.Wzfr = new SelectList(_wzfrs, "Id", "Name");
            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model =new FormKeyModel
            {
                Wzfr = new SelectList(_wzfrs, "Id", "Name")
            };
                ViewBag.success = "با موفقیت ثبت شد";
                return View(model);
            
        }

        public IActionResult Index()
        {
            return View();
        }


        //  [HttpPost]
        //public JsonResult Contact(IFormCollection model)
        //{
        //    var email = model["email"];

        //    return Json(Ok());
        //}


        //[HttpPost]
        //public JsonResult Contact(ContactModel model)
        //{
        //    Console.WriteLine(model.ToString());
        //    return Json(Ok());
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}