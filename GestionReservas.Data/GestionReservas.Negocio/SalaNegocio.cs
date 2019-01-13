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
    public class SalaNegocio : ISalaRepositorio
    {
        ISalaRepositorio _Repositorio;

        private ISalaRepositorio Repositorio
        {
            get
            {
                if (_Repositorio == null)
                    _Repositorio = new SalaRepositorio();
                return _Repositorio;
            }
        }

        public Sala BuscarSala(int id)
        {
            return Repositorio.BuscarSala(id);
        }

        public void EliminarSala(int id)
        {
            Repositorio.EliminarSala(id);
        }

        public Sala GuardarActualizarSala(Sala sala)
        {
            return Repositorio.GuardarActualizarSala(sala);
        }

        public IEnumerable<Sala> ListarSala(Sala sala)
        {
            return Repositorio.ListarSala(sala);
        }
    }
}
