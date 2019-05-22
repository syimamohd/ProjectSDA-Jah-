using PatientCarePlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PatientCarePlan.Controllers
{
    [AllowAnonymous]
    public class AuthAuthController : Controller
    {
        // GET: AuthAuth
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User user)
        {
            //access your database, get user with the username and password
            PatientCarePlanContext db = new PatientCarePlanContext();
            int count = db.Users.Where(x => x.UserName == user.UserName
                        && x.password == user.password).Count();

            if (count == 0)
            {
                ViewBag.errMsg = "No Match Found";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            //signout/logout
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //return View();
    }
}
