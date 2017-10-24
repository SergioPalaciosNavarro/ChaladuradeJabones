using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChaladuradeJabones.Models;


namespace ChaladuradeJabones.Controllers
{
    public class ClientesController : Controller
    {
        //private readonly ChaladuraEntities clientesDataContext;
        //public ClientesController()
        //{
        //    clientesDataContext = new ChaladuraEntities();
        //}
        private readonly IClientesRepositorio _repositorio;

        public ClientesController()
            : this(new ClientesRepositorio())
        {
        }
        public ClientesController(IClientesRepositorio repository)
        {
            _repositorio = repository;
        }
        // GET: Clientes

        public ActionResult ClientesIndex()
        {
            var clientes = _repositorio.GetClient();
            return View(clientes);
        }
        public ActionResult Create()
        {
            return View(new ClientesModel());
        }
        //POST:Clientes
        public ActionResult Create(ClientesModel clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositorio.InsertClient(clientes);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Problem in Data Saving");
            }
            return View(clientes);
        }

        public ActionResult Edit(int id)
        {
            ClientesModel model = _repositorio.GetClientById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ClientesModel clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositorio.UpdateClient(clientes);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Problem in Data Saving");
            }
            return View(clientes);
        }


        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Problem in Deleting";
            }
            ClientesModel clientes = _repositorio.GetClientById(id);
            return View(clientes);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                ClientesModel user = _repositorio.GetClientById(id);
                _repositorio.DeleteClient(id);
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                new System.Web.Routing.RouteValueDictionary {
          { "id", id },
          { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }

    }
}