using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Interfaces
{
   public interface IComunesRepositorio
    {
        IEnumerable<TipoCualidades> ListarTipoCualidades();
        IEnumerable<TipoEspacio> ListarEspacios();
    }
}
