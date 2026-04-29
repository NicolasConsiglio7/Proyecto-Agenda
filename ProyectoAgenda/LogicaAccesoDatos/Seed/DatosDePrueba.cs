using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
using LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAccesoDatos.Seed
{
    public static class DatosDePrueba
    {
        public static void Cargar(IRepositorioUsuario repo)
        {
            repo.Agregar(new Usuario("admin@mail.com", "1234", "Administrador", Rol.Administrador));
            repo.Agregar(new Usuario("nico@mail.com", "1234", "Nicolas", Rol.Cliente));
            repo.Agregar(new Usuario("cliente@mail.com", "1234", "Cliente", Rol.Cliente));
        }
    }
}
