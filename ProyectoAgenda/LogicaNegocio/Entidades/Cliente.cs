using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Cliente : Usuario
    {
        public int Telefono { get; set; }

        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        public Cliente() { }

        public Cliente(string email, string password, string nombre, int telefono)
            : base(email, password, nombre, Rol.Cliente)
        {
            Telefono = telefono;
        }
    }
}
