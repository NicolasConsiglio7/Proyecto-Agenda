namespace LogicaNegocio.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Local Local { get; set; }

        public List<Horario> Horarios { get; set; } = new List<Horario>();

    }
}