using login_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace login_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(loginViewModel model)
        {

            if (ModelState.IsValid)
                return RedirectToAction("Index", "Home");

            ViewBag.Error = "Ha fallado el login";
            return View(model);
        }
    }
}