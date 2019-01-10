using GestionReservas.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Repositorios
{
    public class ClienteRepositorio : RepositorioBase, IClienteRepositorio
    {
        private bool _disposed = false;
        private string connectionString;

        public ClienteRepositorio()
        {
            Context = new GestionContext();
            RequiresContextDisposal = true;
        }

        public void EliminarCliente(Cliente clientes)
        {
            throw new NotImplementedException();
        }

        public Cliente GuardarActualizarCliente(Cliente clientes)
        {
            try
            {
                Cliente modelo = Context.Cliente.Where(a => a.Id == clientes.Id).FirstOrDefault();
                if (modelo != null) //Editar
                {
                    modelo.Nombre = clientes.Nombre;
                    modelo.NumeroIdentificacion = clientes.NumeroIdentificacion;
                    modelo.SaldoActual = clientes.SaldoActual;
                    modelo.Telefono = clientes.Telefono;
                }
                else
                {
                    modelo = new Cliente();
                    modelo.Nombre = clientes.Nombre;
                    modelo.NumeroIdentificacion = clientes.NumeroIdentificacion;
                    modelo.SaldoActual = clientes.SaldoActual;
                    modelo.Telefono = clientes.Telefono;

                    Context.Cliente.Add(modelo);
                }

                Context.SaveChanges();
                return modelo;
            }
            catch (Exception ex)
            {
                return null;
            }
            /*catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
*/
        }

        public IEnumerable<Cliente> ListarCliente(Cliente clientes)
        {
            //return Context.Cliente.Where(x => x.Cedula == cedula).FirstOrDefault();
            return Context.Cliente;
        }
    }
}
