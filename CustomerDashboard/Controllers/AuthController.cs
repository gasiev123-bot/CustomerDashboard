using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Auth/Login
        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            string validEmail = ConfigurationManager.AppSettings["LoginEmail"];
            string validPassword = ConfigurationManager.AppSettings["LoginPassword"];

            if ( email == validEmail && password == validPassword)
            {
                Session["User"] = email; // store email in session
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid login credentials.";
            return View();
        }

        // POST: Auth/Logout
        [HttpPost]
        public ActionResult Logout()
        {
            // Clear session
            Session.Clear();
            Session.Abandon();

            // Expire authentication cookie
            if (Request.Cookies["LoginEmail"] != null)
            {
                var cookie = new HttpCookie("LoginEmail")
                {
                    Expires = DateTime.Now.AddDays(-1)
                };
                Response.Cookies.Add(cookie);
            }

            // Redirect to Login page
            return RedirectToAction("Login", "Auth");
        }
    }
}
