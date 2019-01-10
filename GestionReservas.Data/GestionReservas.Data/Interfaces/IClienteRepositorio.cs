using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Interfaces
{
    public interface IClienteRepositorio
    {
        Cliente GuardarActualizarCliente(Cliente clientes);
        void EliminarCliente(Cliente clientes);
        IEnumerable<Cliente> ListarCliente(Cliente clientes);

    }
}
