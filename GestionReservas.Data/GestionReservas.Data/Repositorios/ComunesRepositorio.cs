using GestionReservas.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Repositorios
{
    public class ComunesRepositorio : RepositorioBase, IComunesRepositorio
    {
        private bool _disposed = false;
        private string connectionString;

        public ComunesRepositorio()
        {
            Context = new GestionContext();
            RequiresContextDisposal = true;
        }

        public IEnumerable<TipoEspacio> ListarEspacios()
        {
            return Context.TipoEspacio.ToList();
        }

        public IEnumerable<TipoCualidades> ListarTipoCualidades()
        {
            return Context.TipoCualidades.ToList();
        }
    }
}
