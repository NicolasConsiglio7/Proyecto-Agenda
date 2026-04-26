using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Administrador : Usuario
    {

        public Administrador(string email, string password, string nombre)
        : base(email, password, nombre, Rol.Administrador)
        {
        }
    }
}
