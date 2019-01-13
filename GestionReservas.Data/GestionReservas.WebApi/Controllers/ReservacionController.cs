using GestionReservas.Data;
using GestionReservas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestionReservas.WebApi.Controllers
{
    public class ReservacionController : ApiController
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

        // GET: api/Reservacion
        public IEnumerable<Reservacion> Get()
        {
            return _reserva.ListarReservacion(null);
        }

        // GET: api/Reservacion/5
        public Reservacion Get(int id)
        {
            Reservacion reserva = _reserva.BuscarReservaXId(id);
            return reserva;
        }

        // POST: api/Reservacion
        public void Post([FromBody]Reservacion value)
        {
            Reservacion reserva = new Reservacion();
            reserva.HoraInicio = value.HoraInicio;
            reserva.HoraFin = value.HoraFin;
            reserva.Valor = Convert.ToDouble(value.Valor);
            reserva.IdSalon = Convert.ToInt32(value.IdSalon);
            reserva.IdCliente = Convert.ToInt32(value.IdCliente);

            _reserva.GuardarActualizarReservacion(reserva);

        }

        // PUT: api/Reservacion/5
        public void Put(int id, [FromBody]Reservacion value)
        {
            Reservacion reserva = new Reservacion();
            reserva.HoraInicio = value.HoraInicio;
            reserva.HoraFin = value.HoraFin;
            reserva.Valor = Convert.ToDouble(value.Valor);
            reserva.IdSalon = Convert.ToInt32(value.IdSalon);
            reserva.IdCliente = Convert.ToInt32(value.IdCliente);

            _reserva.GuardarActualizarReservacion(reserva);
        }

        // DELETE: api/Reservacion/5
        public void Delete(int id)
        {
            _reserva.EliminarReservacion(id);
        }
    }
}
