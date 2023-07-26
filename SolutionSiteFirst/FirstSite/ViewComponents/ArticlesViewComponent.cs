using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstSite.ViewComponents
{
    public class ArticlesViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Article=new List<Article>
            {
                new Article(id:1,title:"magale1",description:"اولین پروژه های سایت ما",img:"blog-post-thumb-6.jpg"),
                new Article(id:2,title:"magale2",description:"دومین پروژه های سایت ما",img:"blog-post-thumb-3.jpg"),
                new Article(id:3,title:"magale3",description:"سومین پروژه های سایت ما",img:"blog-post-thumb-4.jpg"),
                new Article(id:4,title:"magale4",description:"چهارمین پروژه های سایت ما",img:"blog-post-thumb-5.jpg"),
            };
            return View("_Articles",Article);
        }
    }
}
