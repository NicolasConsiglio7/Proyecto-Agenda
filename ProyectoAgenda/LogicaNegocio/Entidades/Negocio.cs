using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Negocio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoSuscripcion Suscripcion { get; set; }

        public List<Local> Locales { get; set; } = new List<Local>();
        public Negocio()
        {
            
        }
    }
}
