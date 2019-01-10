using GestionReservas.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Repositorios
{
    public class ReservasRepositorio :RepositorioBase, IReservasRepositorio
    {
        private bool _disposed = false;
        private string connectionString;

        public ReservasRepositorio()
        {
            Context = new GestionContext();
            RequiresContextDisposal = true;
        }


        public void EliminarReservacion(Reservacion reserva)
        {
            throw new NotImplementedException();
        }

        public Reservacion GuardarActualizarReservacion(Reservacion reserva)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservacion> ListarReservacion(Reservacion reserva)
        {
            return Context.Reservacion.ToList();
        }
    }
}
