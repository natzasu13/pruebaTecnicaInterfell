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
    public class ComunesNegocio : IComunesRepositorio
    {
        IComunesRepositorio _Repositorio;

        private IComunesRepositorio Repositorio
        {
            get
            {
                if (_Repositorio == null)
                    _Repositorio = new ComunesRepositorio();
                return _Repositorio;
            }
        }
        public IEnumerable<TipoEspacio> ListarEspacios()
        {
            return Repositorio.ListarEspacios();
        }

        public IEnumerable<TipoCualidades> ListarTipoCualidades()
        {
            return Repositorio.ListarTipoCualidades();
        }
    }
}
