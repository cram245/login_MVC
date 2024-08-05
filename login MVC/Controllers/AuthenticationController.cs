using login_MVC.DAL;
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
            {
                UsuarioDAL u = new UsuarioDAL();
                Usuario usuario = new Usuario(model.Email, model.Password);
                if (u.CheckExists(usuario))
                    return RedirectToAction("Index", "Home");
                else
                    ViewBag.Error = "Ha fallado el login";
            }
                

            ViewBag.Error = "Ha fallado el login";
            return View(model);
        }
    }
}