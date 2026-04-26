using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }

        public Usuario() { }

        public Usuario(string email, string passwordPlano, string nombre, Rol rol)
        {
            Email = email;
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(passwordPlano);
            Nombre = nombre;
            Rol = rol;
        }

        public bool VerificarPassword(string passwordPlano)
        {
            return BCrypt.Net.BCrypt.Verify(passwordPlano, PasswordHash);
        }


    }
}
