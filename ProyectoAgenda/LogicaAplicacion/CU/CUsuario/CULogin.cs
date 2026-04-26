using DTOs.DTOs;
using DTOs.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.InterfacesCU;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CU.CUsuario
{
    public class CULogin : ILoginUsuario
    {
        private UsuarioRepository _repo;

        public CULogin(UsuarioRepository repo)
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
