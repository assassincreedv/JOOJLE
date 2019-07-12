using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using eCommerceMVC.Service;
using eCommerceMVC.UoW;

namespace eCommerceMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            if (Session["error"] == null) ViewData["erroeinfo"] = "Please check login credentials!!";
            else ViewData["errorinfo"] = "";
            return View("login");
        }
        [HttpPost]
        public ActionResult LoginUser() {
            UserServicecs user = new UserServicecs();
            string username = Request["UserName"].ToString().ToLower();
            string password = Request["UserPassword"].ToString();
            if (user.Login(username, password))
            {
                Console.WriteLine("FIND !");
                return View();
            }
            else {
                Console.WriteLine("ERROR !");
                Session["error"] = 1;
                return View("Login");
            }
        }
        public ActionResult Register() {
            UserServicecs user = new UserServicecs();
            user.register("AllenHu", "125643", "123@gmail.com");
            return View();
        }
    }
}