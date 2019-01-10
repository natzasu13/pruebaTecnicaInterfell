using GestionReservas.Data;
using GestionReservas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionReservas.UI.Controllers
{
    public class ClienteController : Controller
    {
        ClienteNegocio _cliente;

        public ClienteController()
        {
            if (_cliente == null)
                _cliente = new ClienteNegocio();
        }

        // GET: Default
        public ActionResult Index()
        {
            ViewBag.listar = _cliente.ListarCliente(null);
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = collection[1];
            cliente.NumeroIdentificacion = collection[2];
            cliente.SaldoActual = Convert.ToDouble(collection[3]);
            cliente.Telefono = collection[4];

            try
            {
                // TODO: Add insert logic here

                _cliente.GuardarActualizarCliente(cliente);
               return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
