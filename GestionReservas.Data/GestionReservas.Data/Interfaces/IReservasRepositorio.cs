﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservas.Data.Interfaces
{
    public interface IReservasRepositorio
    {
        Reservacion GuardarActualizarReservacion(Reservacion reserva);
        void EliminarReservacion(Reservacion reserva);
        IEnumerable<Reservacion> ListarReservacion(Reservacion reserva);

    }
}
