using GestionReservas.Data;
using GestionReservas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionReservas.UI.Controllers
{
    public class SalaController : Controller
    {
        SalaNegocio _sala;

        public SalaController()
        {
            if (_sala == null)
                _sala = new SalaNegocio();
        }

        // GET: Sala
        public ActionResult Index()
        {
            ViewBag.listar = _sala.ListarSala(null);
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
            Sala sala = new Sala();
            /* reserva.Confimada = collection[1];
             reserva.IdCliente = collection[2];
             reserva.HoraInicio = collection[3];
             reserva.HoraFin = collection[4];
             reserva.IdSalon = collection[5];
             reserva.Paga = collection[6];
             reserva.Valor = collection[7];

             */

            try
            {
                // TODO: Add insert logic here

                _sala.GuardarActualizarSala(sala);
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

