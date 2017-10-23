using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaladuradeJabones.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult PedidosIndex()
        {
            return View();
        }
    }
}