using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace Supen.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text, string cat)
        {
            using (var db = new SupenEntities())
            {
                var repos = new BloggRepos();
                repos.CreateBlogPost(text, cat);
                return View();
            }
        }
    }
}