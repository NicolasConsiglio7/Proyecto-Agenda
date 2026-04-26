using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.IRepositorios
{
    public interface IRepositorioUsuario
    {
        Usuario ObtenerPorEmail(string email);
        void Agregar(Usuario usuario);
    }
}
