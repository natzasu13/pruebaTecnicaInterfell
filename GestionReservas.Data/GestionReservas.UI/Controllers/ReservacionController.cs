using GestionReservas.Data;
using GestionReservas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionReservas.UI.Controllers
{
    public class ReservacionController : Controller
    {
        ReservasNegocio _reserva;
        SalaNegocio _salon;
        ClienteNegocio _cliente;

        public ReservacionController()
        {
            if (_reserva == null)
                _reserva = new ReservasNegocio();
            if (_cliente == null)
                _cliente = new ClienteNegocio();
            if (_salon == null)
                _salon = new SalaNegocio();
        }

        // GET: Reservacion
        public ActionResult Index()
        {
            ViewBag.listar = _reserva.ListarReservacion(null);
            return View();
        }

        // GET: Reservacion
        public ActionResult Confirmar()
        {
            ViewBag.listar = _reserva.ListarReservacionSinConfirmar();
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult ConfirmarPost(int idReserva)
        {
            Reservacion reserva = _reserva.BuscarReservaXId(idReserva);
            reserva.Confimada = true;
            _reserva.GuardarActualizarReservacion(reserva);

            ViewBag.listar = _reserva.ListarReservacionSinConfirmar();
            return View();
        }

        // GET: Reservacion
        public ActionResult Pagar()
        {
            ViewBag.listar = _reserva.ListarReservacionSinPagar();
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult PagarPost(int idReserva)
        {
            Reservacion reserva = _reserva.BuscarReservaXId(idReserva);
            reserva.Paga = true;
            _reserva.GuardarActualizarReservacion(reserva);

            ViewBag.listar = _reserva.ListarReservacionSinPagar();
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
            ViewBag.Paga = false;
            ViewBag.Confirmar = false;
            ViewBag.Cliente = _cliente.ListarCliente(null);
            ViewBag.Salon = _salon.ListarSala(null);
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Reservacion reserva = new Reservacion();
            reserva.HoraInicio = collection[1];
            reserva.HoraFin = collection[2];
            //reserva.Paga = Convert.ToBoolean(collection[3]);
            //reserva.Confimada = Convert.ToBoolean(collection[4]);
            reserva.Valor = Convert.ToDouble(collection[3]);
            reserva.IdSalon = Convert.ToInt32(collection[4]);
            reserva.IdCliente = Convert.ToInt32(collection[5]);



            try
            {
                // TODO: Add insert logic here

                _reserva.GuardarActualizarReservacion(reserva);
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

        // GET: Reservacion
        public ActionResult ReportePendientesPago()
        {
            ViewBag.listar = _reserva.ListarReservacionSinPagar();
            return View();
        }

        // GET: Reservacion
        public ActionResult ReportePendientesConfimacion()
        {
            ViewBag.listar = _reserva.ListarReservacionSinConfirmar();
            return View();
        }
        

        // GET: Reservacion
        public ActionResult ReservasCliente()
        {
            ViewBag.Cliente = _cliente.ListarCliente(null);
            ViewBag.listar = _reserva.BuscarReservaXIdCliente(0);
            return View();
        }

        // POST: Reservacion
        public ActionResult ReservasClientePost(int idCliente)
        {
            ViewBag.listar = _reserva.BuscarReservaXIdCliente(idCliente);
            return View();
        }
    }
}

