using DTOs.DTOs;
using DTOs.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CU.CUsuario
{
    public class CULogin : ILoginUsuario
    {
        private IRepositorioUsuario _repo;

        public CULogin(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public UsuarioDTO Ejecutar(string email, string password)
        {
            var usuario = _repo.ObtenerPorEmail(email);

            if (usuario == null)
                throw new Exception("Usuario no existe");

            if (!usuario.VerificarPassword(password))
                throw new Exception("Contraseña incorrecta");

            return UsuarioMappers.ToDTO(usuario);
        }
    }
}
