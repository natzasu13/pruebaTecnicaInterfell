using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Interfaces
{
    public interface ISalaRepositorio
    {
        Sala GuardarActualizarSala(Sala sala);
        void EliminarSala(Sala sala);
        IEnumerable<Sala> ListarSala(Sala sala);

    }
}
