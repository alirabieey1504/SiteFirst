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

        //public FileResult Index()
        //{
        // // return File("~/text.txt", "text/html");
        // var fileByte = System.IO.File.ReadAllBytes("wwwroot/text.txt");
        // const string fileName = "textFile.txt";
        // return File(fileByte, MediaTypeNames.Text.Plain, fileName);

        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "hosian",
        //        job = "programmer",
        //        site = "ali.ir"
        //    });
        //}

        //public javascriptResult Index()
        //{
        //    return new javascriptResult("alert('salam be karbar hae aziz')");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.emamali.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}


        public IActionResult Index()
        {
          //  return new OkResult();
         // return  new NotFoundResult();
         //return new BadRequestResult();
         //return  new NoContentResult();
         return new StatusCodeResult(300);
        }

    }

    //public class javascriptResult: ContentResult
    //{
    //    public javascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript"; 

    //    }
    //}
}