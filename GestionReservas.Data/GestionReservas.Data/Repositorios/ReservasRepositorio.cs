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
            try
            {
                Reservacion modelo = Context.Reservacion.Where(a => a.Id == reserva.Id).FirstOrDefault();
                if (modelo != null) //Editar
                {
                    modelo.HoraInicio = reserva.HoraInicio;
                    modelo.HoraFin = reserva.HoraFin;
                    modelo.Valor = reserva.Valor;
                    modelo.IdSalon = reserva.IdSalon;
                    modelo.IdCliente = reserva.IdCliente;
                    modelo.C_updated = DateTime.Now;
                }
                else
                {
                    modelo = new Reservacion();
                    modelo.HoraInicio = reserva.HoraInicio;
                    modelo.HoraFin = reserva.HoraFin;
                    modelo.Valor = reserva.Valor;
                    modelo.IdSalon = reserva.IdSalon;
                    modelo.IdCliente = reserva.IdCliente;
                    modelo.C_created = DateTime.Now;

                    Context.Reservacion.Add(modelo);
                }

                Context.SaveChanges();
                return modelo;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Reservacion> ListarReservacion(Reservacion reserva)
        {
            return Context.Reservacion.ToList();
        }
    }
}
