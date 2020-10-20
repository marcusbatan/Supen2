using Database;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Supen.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Games game)
        {
            using (var db = new SupenEntities())
            {
                var teams = new Team();
                ViewBag.Team = db.TeamSet.ToList();
                ViewBag.Team2 = db.TeamSet.ToList();
                return View();
            }
        }
    }
}