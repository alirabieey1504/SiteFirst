using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace FirstSite.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Iddex()
        //{
        //    return PartialView("Footer");

        //}


        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h2>hello asp .net core pishrafte</h2>", contentType: "text/html");
        //}

        public FileResult Index()
        {
         // return File("~/text.txt", "text/html");
         var fileByte = System.IO.File.ReadAllBytes("wwwroot/text.txt");
         const string fileName = "textFile.txt";
         return File(fileByte, MediaTypeNames.Text.Plain, fileName);

        }



    }
}
