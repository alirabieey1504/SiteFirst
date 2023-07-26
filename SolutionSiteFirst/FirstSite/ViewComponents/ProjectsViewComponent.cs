using System.Collections.Generic;
using FirstSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstSite.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Project=new List<Project>
            {
                new Project(id:1,name:"پروژه دی جی کالا",description:"سفارش کالا  با بهترین کیفیت در کمترین زمان",client:"digikala",img:"project-7.jpg"),
                new Project(id:2,name:"شاپ مارکت",description:"درخواست میوه و سبزیجات در کمترین زمان ",client:"shapmarket",img:"project-1.jpg"),
                new Project(id:3,name:"mobilenet",description:"سفارش کالا  با بهترین کیفیت در کمترین زمان",client:"mobilenet  ",img:"project-2.jpg"),
                new Project(id:4,name:"berandsho",description:"سفارش کالا  با بهترین کیفیت در کمترین زمان",client:"berandsho  ",img:"project-3.jpg"),
            };
            return View("_Projects",Project);
        }
    }
}
