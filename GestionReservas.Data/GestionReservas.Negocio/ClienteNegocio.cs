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
    public class ClienteNegocio : IClienteRepositorio
    {
        IClienteRepositorio _Repositorio;

        private IClienteRepositorio Repositorio
        {
            get
            {
                if (_Repositorio == null)
                    _Repositorio = new ClienteRepositorio();
                return _Repositorio;
            }
        }

        public void EliminarCliente(Cliente clientes)
        {
            Repositorio.EliminarCliente(clientes);
        }

        public Cliente GuardarActualizarCliente(Cliente clientes)
        {
            return Repositorio.GuardarActualizarCliente(clientes);
        }

        public IEnumerable<Cliente> ListarCliente(Cliente clientes)
        {
            return Repositorio.ListarCliente(clientes);
        }
    }
}
