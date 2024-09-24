using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_PagoHaberes.Models;

namespace WebApplication_PagoHaberes.Controllers
{
    public class PagoHaberesController : Controller
    {
        // GET: PagoHaberes
        public ActionResult Planilla()
        {
            return View(new Haberes());
        }

        [HttpPost]
        public ActionResult Planilla(Haberes reg)
        {
            ViewBag.Bonificacion = reg.Bonificacion();
            ViewBag.remuneracion = reg.Remuneracion();
            ViewBag.aportacion = reg.Aportacion();
            ViewBag.neto = reg.Neto();
            return View(reg);

        }
    }
}