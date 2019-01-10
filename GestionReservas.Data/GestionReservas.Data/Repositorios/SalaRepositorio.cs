using GestionReservas.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Repositorios
{
    public class SalaRepositorio : RepositorioBase, ISalaRepositorio
    {
        private bool _disposed = false;
        private string connectionString;

        public SalaRepositorio()
        {
            Context = new GestionContext();
            RequiresContextDisposal = true;
        }

        public void EliminarSala(Sala sala)
        {
            throw new NotImplementedException();
        }

        public Sala GuardarActualizarSala(Sala sala)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sala> ListarSala(Sala sala)
        {
            throw new NotImplementedException();
        }
    }
}
