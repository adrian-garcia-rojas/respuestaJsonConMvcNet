using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using respuestaJsonConMvcNet.Models;

namespace respuestaJsonConMvcNet.Controllers
{
    public class RespuestaJsonController : Controller
    {
        // GET: RespuestaJson
        public ActionResult Index()
        {
            List<personas> lista;
            using (dbCursosEntities db = new dbCursosEntities())
            {
                lista = (from d in db.personas
                            select d).ToList();
            }

                return View(lista);
        }
    }
}