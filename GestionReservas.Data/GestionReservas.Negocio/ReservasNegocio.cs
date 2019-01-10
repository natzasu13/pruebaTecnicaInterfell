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



        public void EliminarReservacion(Reservacion reserva)
        {
            Repositorio.EliminarReservacion(reserva);
        }

        public Reservacion GuardarActualizarReservacion(Reservacion reserva)
        {
            return Repositorio.GuardarActualizarReservacion(reserva);
        }

        public IEnumerable<Reservacion> ListarReservacion(Reservacion reserva)
        {
            return Repositorio.ListarReservacion(reserva);
        }
    }
}
