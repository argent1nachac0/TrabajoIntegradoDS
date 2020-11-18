using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPDS2.Models;

namespace TPDS2.Controllers
{
    [Authorize]
    public class ClienteController : Controller
    {

        // GET: Cliente
        public ActionResult MenuAdministracionVenta(string message = "")
        {
            ViewBag.Message = message;
            ViewBag.Usuario = "Test";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistraCliente(Cliente c)
        {
            if (!ModelState.IsValid)
            
                return View("MenuAdministracionVenta");

                try
                {
                    using (var db = new ClienteContext())
                    {
                        
                        var existe = db.Cliente.ToList().Exists(x => x.dni == c.dni); 

                        if (!existe)
                        {                                                                           //verifica en la BD si el cliente esta registrado o no
                            db.Cliente.Add(c);
                            db.SaveChanges();
                            return RedirectToAction("MenuAdministracionVenta", new { message = "Cliente Registrado Satisfactoriamente. Su ID es: 11" });
                        }
                        else
                        {
                            return RedirectToAction("MenuAdministracionVenta", new {message = "Cliente ya Registrado" });
                        }

                        
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al registrar un Cliente -" + ex.Message);
                    return View();
                }

            
        }

    }
}