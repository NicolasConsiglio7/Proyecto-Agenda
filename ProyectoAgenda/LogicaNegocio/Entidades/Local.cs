namespace LogicaNegocio.Entidades
{
    public class Local
    {
        public int Id { get; set; }
        public string Direccion { get; set; }

        public Negocio Negocio { get; set; }

        public List<Empleado> Barberos { get; set; } = new List<Empleado>();
        public List<Servicio> Servicios { get; set; } = new List<Servicio>();
    }
}