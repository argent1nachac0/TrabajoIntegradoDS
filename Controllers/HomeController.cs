using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TPDS2.Models;

namespace TPDS2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string nombreUser, string password)
        {

                if (!string.IsNullOrEmpty(nombreUser) && !string.IsNullOrEmpty(password))
                {
                    var db = new ClienteContext();
                    var user = db.Usuarios.FirstOrDefault(e => e.nombreUsuario == nombreUser && e.contraseña == password);

                        if (user != null)
                        {
                            FormsAuthentication.SetAuthCookie(user.nombreUsuario, true);

                            return RedirectToAction("MenuAdministracionVenta", "Cliente");
                            
                }
                        else
                        {
                            return RedirectToAction("Index", new { message = "Los datos ingresados son incorrectos" });
                        }
                   
                }
                else
                {
                    return RedirectToAction("Index", new { message = "Llena los campos para poder iniciar sesion" });
                    
                }     
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
            
    }
    
}