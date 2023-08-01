using System.Collections.Generic;
using FirstSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {

        readonly private List<Service> _services = new List<Service>
        {
            new Service(1,"طلا"),
            new Service(2,"پلاتین"),
            new Service(3,"نقره"),
            new Service(4,"الماس")
           
        };



        [HttpGet]
        public IActionResult formexe()
        {
            var key=new FormKeyModel();
            return View(key);
        }

        [HttpPost]
        public IActionResult formexe(FormKeyModel model)
        {
            if (ModelState.IsValid==false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید";
                return View(model);
            }
            else
            {
                ViewBag.success = "با موفقیت ثبت شد";
                return View();
            }
            
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


        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست.لطفا دوباره تلاش کنید.";
                return View(model);

            }
            else
            {
                ViewBag.success = "اطلاعات شما با موفقیت ثبت شد";
                return View();
                //   return RedirectToAction("Index");
            }
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
