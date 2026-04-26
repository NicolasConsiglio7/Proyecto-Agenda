using DTOs.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.InterfacesCU
{
    public interface ILoginUsuario
    {
        UsuarioDTO Ejecutar(string email, string password);
    }
}
