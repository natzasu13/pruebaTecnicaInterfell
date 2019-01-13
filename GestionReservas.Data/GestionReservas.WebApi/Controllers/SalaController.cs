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
    public class SalaController : ApiController
    {
        SalaNegocio _sala;
        ComunesNegocio _comunes;


        public SalaController()
        {
            if (_sala == null)
                _sala = new SalaNegocio();
            if (_comunes == null)
                _comunes = new ComunesNegocio();
        }

        // GET: api/Sala
        public IEnumerable<Sala> Get()
        {
            return _sala.ListarSala(null);
        }

        // GET: api/Sala/5
        public Sala Get(int id)
        {
            Sala sala = _sala.BuscarSala(id);
            return sala;
        }

        // POST: api/Sala
        public void Post([FromBody]Sala value)
        {
            Sala sala = new Sala();
            sala.Nombre = value.Nombre;
            sala.Descripcion = value.Descripcion;
            sala.Precio = Convert.ToDouble(sala.Precio);
            sala.IdTipoEspacio = Convert.ToInt32(value.IdTipoEspacio);
            sala.IdCualidades = Convert.ToInt32(value.IdCualidades);

            _sala.GuardarActualizarSala(sala);
        }

        // PUT: api/Sala/5
        public void Put(int id, [FromBody]Sala value)
        {
            Sala sala = new Sala();
            sala.Nombre = value.Nombre;
            sala.Descripcion = value.Descripcion;
            sala.Precio = Convert.ToDouble(sala.Precio);
            sala.IdTipoEspacio = Convert.ToInt32(value.IdTipoEspacio);
            sala.IdCualidades = Convert.ToInt32(value.IdCualidades);

            _sala.GuardarActualizarSala(sala);
        }

        // DELETE: api/Sala/5
        public void Delete(int id)
        {
            _sala.EliminarSala(id);
        }
    }
}
