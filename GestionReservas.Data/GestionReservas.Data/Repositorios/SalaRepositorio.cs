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
            try
            {
                Sala modelo = Context.Sala.Where(a => a.Id == sala.Id).FirstOrDefault();
                if (modelo != null) //Editar
                {
                    modelo.Nombre = sala.Nombre;
                    modelo.Descripcion = sala.Descripcion;
                    modelo.Precio = sala.Precio;
                    modelo.IdTipoEspacio = sala.IdTipoEspacio;
                    modelo.IdCualidades = sala.IdCualidades;
                    modelo.C_updated = DateTime.Now;
                }
                else
                {
                    modelo = new Sala();
                    modelo.Nombre = sala.Nombre;
                    modelo.Descripcion = sala.Descripcion;
                    modelo.Precio = sala.Precio;
                    modelo.IdTipoEspacio = sala.IdTipoEspacio;
                    modelo.IdCualidades = sala.IdCualidades;
                    modelo.C_created = DateTime.Now;

                    Context.Sala.Add(modelo);
                }

                Context.SaveChanges();
                return modelo;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Sala> ListarSala(Sala sala)
        {
            IEnumerable<Sala> listar = Context.Sala.ToList();
            return listar;
        }
    }
}
