using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Supen.Controllers;
using System.Data.SqlClient;

namespace Supen.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=(LocalDb)\\MSSQLLocalDB; Database=Supen; integrated security = SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(string email, string password)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM AppUser WHERE Password = '" + password + "' AND EMAIL ='" + email + "'";
            ViewBag.test = email + password;
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                ViewBag.test = email + password;
                con.Close();
                return View("Success");
            }
            else
            {
                ViewBag.test = email + password;
                con.Close();
                return View("Error");
            }

        }
    }
}
