using GestionReservas.Data;
using GestionReservas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestionReservas.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteNegocio _cliente;

        public ClienteController()
        {
            if (_cliente == null)
                _cliente = new ClienteNegocio();
        }

        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            return _cliente.ListarCliente(null);
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Cliente/5
        public Cliente Get(int id)
        {
            Cliente cliente = _cliente.BuscarCliente(id);
            return cliente;
        }

        // POST: api/Cliente
        public void Post([FromBody]Cliente value)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = value.Nombre;
            cliente.NumeroIdentificacion = value.NumeroIdentificacion;
            cliente.SaldoActual = Convert.ToDouble(value.SaldoActual);
            cliente.Telefono = value.Telefono;


            _cliente.GuardarActualizarCliente(cliente);

        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]Cliente value)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = value.Nombre;
            cliente.NumeroIdentificacion = value.NumeroIdentificacion;
            cliente.SaldoActual = Convert.ToDouble(value.SaldoActual);
            cliente.Telefono = value.Telefono;


            _cliente.GuardarActualizarCliente(cliente);
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            _cliente.EliminarCliente(id);
        }
    }
}
