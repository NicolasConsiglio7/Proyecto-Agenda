namespace LogicaNegocio.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }
        public Empleado Barbero { get; set; }
        public Servicio Servicio { get; set; }
        public Local Local { get; set; }

        public DateTime FechaHora { get; set; }

        public decimal Precio { get; set; } // precio congelado

        public EstadoReserva Estado { get; set; }

        public Pago Pago { get; set; }

        public void Cancelar()
        {
            Estado = EstadoReserva.Cancelada;
        }
    }
}