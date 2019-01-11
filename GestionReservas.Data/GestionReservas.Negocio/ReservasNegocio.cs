using GestionReservas.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionReservas.Data;
using GestionReservas.Data.Repositorios;

namespace GestionReservas.Negocio
{
    public class ReservasNegocio : IReservasRepositorio
    {
        IReservasRepositorio _Repositorio;

        private IReservasRepositorio Repositorio
        {
            get
            {
                if (_Repositorio == null)
                    _Repositorio = new ReservasRepositorio();
                return _Repositorio;
            }
        }

        public Reservacion BuscarReservaXId(int id)
        {
            return Repositorio.BuscarReservaXId(id);
        }

        public IEnumerable<Reservacion> BuscarReservaXIdCliente(int idCliente)
        {
            return Repositorio.BuscarReservaXIdCliente(idCliente);
        }

        public void EliminarReservacion(int idReserva)
        {
            Repositorio.EliminarReservacion(idReserva);
        }

        public Reservacion GuardarActualizarReservacion(Reservacion reserva)
        {
            return Repositorio.GuardarActualizarReservacion(reserva);
        }

        public IEnumerable<Reservacion> ListarReservacion(Reservacion reserva)
        {
            return Repositorio.ListarReservacion(reserva);
        }

        public IEnumerable<Reservacion> ListarReservacionSinConfirmar()
        {
            return Repositorio.ListarReservacionSinConfirmar();
        }

        public IEnumerable<Reservacion> ListarReservacionSinPagar()
        {
            return Repositorio.ListarReservacionSinPagar();
        }
    }
}
