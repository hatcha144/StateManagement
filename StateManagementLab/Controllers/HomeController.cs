using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateManagementLab.Models;


namespace StateManagementLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Register";
            return View();
        }
        public ActionResult Result(User r)
        {
            if (r.UserName != null)
            {
                Session["UserName"] = r.UserName;
                Session["Email"] = r.Email;
                Session["Password"] = r.Password;
                Session["Age"] = r.Age;
            }
            return View();
        }
        public ActionResult Logout()
        {
            
            ViewBag.name = Session["UserName"];
            Session["UserName"] = null;
            return View();
        }
        public ActionResult UserInfo(User r)
        {
            if (r.UserName != null)
            {
                Session["UserName"] = r.UserName;
                Session["Email"] = r.Email;
                Session["Passwrod"] = r.Password;
                Session["Age"] = r.Age;

            }
        
            return View();
        }


    }
}