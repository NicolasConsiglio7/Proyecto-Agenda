using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAccesoDatos.Repositorios
{
    public class UsuarioRepository
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public Usuario ObtenerPorEmail(string email)
        {
            return usuarios.FirstOrDefault(u => u.Email == email);
        }

        public void Agregar(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
